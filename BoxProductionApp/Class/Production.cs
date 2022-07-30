using System.ComponentModel;

namespace BoxProductionApp.Class
{
    public class Production
    {
        // Evenement qui permet de s'abonner aux changement de la Production.
        public event PropertyChangedEventHandler OnChange;

        private CancellationTokenSource ctx;

        // Nom + prod par heure.
        public readonly TypeOfBox boxType;

        // Temp de production d'une boite.
        public readonly int prodTimeOfABox;

        // Total de la production.
        public readonly int totalProduction;

        // Etat de la production.
        public bool ProdStarted { get; set; }

        // Nombre de boites.
        private int boxCounter;
        public int BoxCounter 
        {
            get => boxCounter; 
            private set
            {
                if (value > 0 && value <= totalProduction && !ProdEnding)
                {
                    boxCounter = value;
                    GetGlobalDefectRate();
                    GetDefectRateLastHour();
                    Update();
                }
            }
        }

        // Création du Thread.
        public Thread Thread { get; set; }

        // Méttre en pause la Production
        public bool ProdEnding { get; set; }

        private List<Box> BoxListDefect { get; set; }

        // Défault de production sur 1h.
        private double defectRateLastHour;
        public double DefectRateLastHour 
        {
            get => defectRateLastHour;
            private set
            {
                defectRateLastHour = value;
                Update();
            } 
        }

        // Taux de défault global.
        private double globalDefectRate;
        public double GlobalDefectRate 
        {
            get => globalDefectRate; 
            private set
            {
                globalDefectRate = value;
                Update();
            } 
        }

        /// <summary>
        /// Construction d'une Production.
        /// </summary>
        /// <param name="_boxType">Type de la boite produite</param>
        /// <param name="_totalProduction">Total des boite demandé pour términer la Production</param>
        public Production(TypeOfBox _boxType, int _totalProduction)
        {
            this.boxType = _boxType;
            this.totalProduction = _totalProduction;
            this.boxCounter = 0;
            BoxListDefect = new List<Box>();
            DefectRateLastHour = 0;
            GlobalDefectRate = 0;
            ProdStarted = false;
            ProdEnding = false;
            Thread = new Thread(this.StartedProd);
            prodTimeOfABox = (int)(3600d / (double)boxType * 1000d);
            ctx = new CancellationTokenSource();
        }

        /// <summary>
        /// Réinitialisation des valeur,
        /// on passe le boolean à true
        /// Lancement du Thread.
        /// </summary>
        public void Start()
        {
            if (ctx == null)
            {
                ctx = new CancellationTokenSource();
            }
            if (!ProdStarted)
            {
                Thread = new Thread(this.StartedProd);
                this.boxCounter = 0;
                DefectRateLastHour = 0;
                GlobalDefectRate = 0;
                ProdStarted = true;
                Thread.Start();
            }
        }

        /// <summary>
        /// Lancement de la Production.
        /// </summary>
        private void StartedProd()
        {
            if (ProdStarted)
            {
                try
                {
                    while (!ProdEnding && BoxCounter != totalProduction)
                    {
                        ctx.Token.ThrowIfCancellationRequested();
                        if (ProdStarted)
                        {
                            ctx.Token.WaitHandle.WaitOne(this.prodTimeOfABox);
                            Box box = new Box(this.boxType);
                            if (box.isOk)
                            {
                                ++BoxCounter;
                            }
                            else
                            {
                                BoxListDefect.Add(box);
                                GetGlobalDefectRate();
                                GetDefectRateLastHour();
                            }
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    ctx.Dispose();
                    ctx = new CancellationTokenSource();
                }
            }
        }

        /// <summary>
        /// Taux de d'erreur sur la dernière heure.
        /// </summary>
        private void GetDefectRateLastHour()
        {
            if(BoxListDefect.Count == 0)
            {
                return;
            }
            int defaultCounter = 0;
            TimeSpan interval = TimeSpan.FromHours(1);
            foreach (Box box in BoxListDefect)
            {
                if(box.manufacturingTime > DateTime.Now.TimeOfDay - interval)
                {
                    ++defaultCounter;
                }
            }
            DefectRateLastHour = (double)defaultCounter / (double)this.boxType;
        }

        /// <summary>
        /// Taux d'erreur global de la production.
        /// </summary>
        private void GetGlobalDefectRate()
        {
            // Nombre de boite défectueuse / nombre de boite produite 
            globalDefectRate = (double)BoxListDefect.Count / (double)BoxCounter;
        }

        /// <summary>
        /// Mise en pause la production.
        /// </summary>
        public void StandBy()
        {
            ProdStarted = false;
            ctx.Cancel();
        }

        /// <summary>
        /// redémarage de la Production.
        /// </summary>
        public void Restart()
        {
            ctx = new CancellationTokenSource();
            this.ProdStarted = true;
            Thread = new Thread(this.StartedProd);
            Thread.Start();
        }

        /// <summary>
        /// Arret de la production.
        /// </summary>
        public void Stop()
        {
            StandBy();
        }

        /// <summary>
        /// Lancement de la mise a jour des valeurs de la Production qui on changées.
        /// </summary>
        private void Update()
        {
            if (this.OnChange != null)
            {
                OnChange(this, new PropertyChangedEventArgs(nameof(BoxCounter)));
            }
        }
    }
}

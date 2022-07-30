using BoxProductionApp.Class;

namespace BoxProductionApp.UserControls
{
    public partial class ButtonsControl : UserControl
    {
        Production prod;
        ProductionForm parent;

        public ButtonsControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Liaison du UserControl à sa Production.
        /// Mise à jour des noms dans le userControl.
        /// </summary>
        /// <param name="prod">Production à lier</param>
        public void ProdLink(Production prod, ProductionForm _parent)
        {
            this.parent = _parent;
            this.prod = prod;
            groupBox.Text += " " + prod.boxType;
            btnEndedProd.Text += " " + prod.boxType;
        }

        /// <summary>
        /// Manage le feu et les bouttons de la production.
        /// </summary>
        /// <param name="_prod"></param>
        public void ChangeTrafficLightState(Production _prod)
        {
            trafficLight.BackgroundImage = _prod.ProdStarted ?
                                            Properties.Resources.Green :
                                            Properties.Resources.Orange;
            ManageButtons(_prod);
        }


        /// <summary>
        /// Démarre la production avec le boutton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartProd_Click(object sender, EventArgs e)
        {
            prod.Start();
            ManageMenu();
        }

        /// <summary>
        /// Redémarre la production avec le boutton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestartProd_Click(object sender, EventArgs e)
        {
            prod.Restart();
            ManageMenu();
        }

        /// <summary>
        /// Met en pause la production avec le boutton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StanByProd_Click(object sender, EventArgs e)
        {
            prod.StandBy();
            ManageMenu();
        }

        /// <summary>
        /// Termine la production avec le boutton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndedProd_Click(object sender, EventArgs e)
        {
            prod.Stop();
            btnEndedProd.Enabled = false;
            ManageMenu();
            btnRestart.Enabled = false;
            trafficLight.BackgroundImage = Properties.Resources.Red;
        }

        /// <summary>
        /// Manage l'état de visibilité des menus du formulaire parent.
        /// </summary>
        private void ManageMenu()
        {
            parent.ChangeMenuStates(this.prod);
        }

        /// <summary>
        /// Manage les boutons de la production.
        /// </summary>
        /// <param name="prod"></param>
        private void ManageButtons(Production prod)
        {
            if (prod.ProdStarted)
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                btnEndedProd.Enabled = true;
                btnRestart.Enabled = false;
                trafficLight.BackgroundImage = Properties.Resources.Green;
            }
            else
            {
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                btnRestart.Enabled = true;
                trafficLight.BackgroundImage = Properties.Resources.Orange;
            }
        }
    }
}

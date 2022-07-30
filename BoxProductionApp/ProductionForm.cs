using BoxProductionApp.Class;

namespace BoxProductionApp
{
    public partial class ProductionForm : Form
    {
        Production prod;

        public ProductionForm()
        {
            InitializeComponent();
            // Cr�ation des instances de mes productions
            ProdManager.MakeProdInstancies();
        }

        /// <summary>
        /// Stockage des productions dans le tag de leur controleur resp�ctif.
        /// Liaison des productions � leurs userControls.
        /// Mise en forme de l'affichage des menus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            btnsControlA.Tag = ProdManager.GetOneProdInstance("A");
            btnsControlB.Tag = ProdManager.GetOneProdInstance("B");
            btnsControlC.Tag = ProdManager.GetOneProdInstance("C");
            btnsControlA.ProdLink((Production)btnsControlA.Tag, this);
            btnsControlB.ProdLink((Production)btnsControlB.Tag, this);
            btnsControlC.ProdLink((Production)btnsControlC.Tag, this);
            prodControlA.ProdLink((Production)btnsControlA.Tag);
            prodControlB.ProdLink((Production)btnsControlB.Tag);
            prodControlC.ProdLink((Production)btnsControlC.Tag);
            progressBarControlA.ProdLink((Production)btnsControlA.Tag);
            progressBarControlB.ProdLink((Production)btnsControlB.Tag);
            progressBarControlC.ProdLink((Production)btnsControlC.Tag);
            stopAMenu.BackColor = Color.Gray;
            continueAMenu.BackColor = Color.Gray;
            stopBMenu.BackColor = Color.Gray;
            continueBMenu.BackColor = Color.Gray;
            stopCMenu.BackColor = Color.Gray;
            continueCMenu.BackColor = Color.Gray;
            timer1.Start();
        }

        /// <summary>
        /// Permet de quitter l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitMenu_Click(object sender, EventArgs e)
        {
            foreach (Production prod in ProdManager.Productions)
            {
                if (prod.ProdStarted)
                {
                    prod.ProdEnding = true;
                }
            }
            this.Close();
        }

        /// <summary>
        /// Permet de changer l'�tat des menus selon la production concern�.
        /// </summary>
        /// <param name="prod">Production concern�</param>
        public void ChangeMenuStates(Production prod)
        {
            switch (prod.boxType.ToString())
            {
                case "A":
                    ManageMenu(prod, startAMenu, stopAMenu, continueAMenu);
                    btnsControlA.ChangeTrafficLightState(prod);
                    break;
                case "B":
                    ManageMenu(prod, startBMenu, stopBMenu, continueBMenu);
                    btnsControlB.ChangeTrafficLightState(prod);
                    break;
                case "C":
                    ManageMenu(prod, startCMenu, stopCMenu, continueCMenu);
                    btnsControlC.ChangeTrafficLightState(prod);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Manage l'etat des menus selon la production.
        /// </summary>
        /// <param name="_prod">Production concern�</param>
        /// <param name="_menuStart">Menu de d�marage de la production</param>
        /// <param name="_menuStop">Menu de d'arret de la production</param>
        /// <param name="_menuRestart">Menu de red�marage de la production</param>
        private void ManageMenu(
            Production _prod,
            ToolStripMenuItem _menuStart,
            ToolStripMenuItem _menuStop,
            ToolStripMenuItem _menuRestart)
        {
            if (!_prod.ProdStarted)
            {
                _menuStart.Enabled = true;
                _menuStart.BackColor = Color.Transparent;
                _menuStop.Enabled = false;
                _menuStop.BackColor = Color.Gray;
                _menuRestart.Enabled = true;
                _menuRestart.BackColor = Color.Transparent;
            }
            else
            {
                _menuStart.Enabled = false;
                _menuStart.BackColor = Color.Gray;
                _menuStop.Enabled = true;
                _menuStop.BackColor = Color.Transparent;
                _menuRestart.Enabled = false;
                _menuRestart.BackColor = Color.Gray;
            }
        }

        /// <summary>
        /// Permet de r�cup�rer la production stock� dans le tag du groupBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>Retourne la production stock�</returns>
        private Production GetProduction(object sender)
        {
            if (sender is Button btn)
            {
                if (btn.Parent is GroupBox)
                {
                    prod = (Production)btn.Parent.Tag;
                    string c = prod.boxType.ToString();
                }
            }
            else if (sender is ToolStripMenuItem prodName)
            {
                prod = ProdManager.GetOneProdInstance(prodName.Text);
            }
            return prod;
        }

        /// <summary>
        /// R�cup�re la production concern�.
        /// D�marer la production avec le menu.
        /// Met a jour l'�tat des menus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartProd_Click(object sender, EventArgs e)
        {
            Production prod = GetProduction(sender);
            prod.Start();
            ChangeMenuStates(prod);
        }

        /// <summary>
        /// R�cup�re la production concern�.
        /// Met en pause la production avec le menu.
        /// Met a jour l'�tat des menus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopProd_Click(object sender, EventArgs e)
        {
            Production prod = GetProduction(sender);
            prod.StandBy();
            ChangeMenuStates(prod);
        }

        /// <summary>
        /// R�cup�re la production concern�.
        /// Red�marer la production avec le menu.
        /// Met a jour l'�tat des menus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContinueProd_Click(object sender, EventArgs e)
        {
            Production prod = GetProduction(sender);
            prod.Restart();
            ChangeMenuStates(prod);
        }

        /// <summary>
        /// Affichage de l'heure dans la barre de statu.
        /// Met a jour le nombre de boite de chaques production.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            statusTime.Text = DateTime.Now.ToLongTimeString();
            boxA.Text = ((Production)btnsControlA.Tag).BoxCounter.ToString();
            boxB.Text = ((Production)btnsControlB.Tag).BoxCounter.ToString();
            boxC.Text = ((Production)btnsControlC.Tag).BoxCounter.ToString();
        }

        /*private void EndedProduction_Click(object sender, EventArgs e)
        {
            if(sender is Button btn)
            {
                if(btn.Parent is GroupBox group)
                {
                    Production prod = (Production)group.Tag;
                    prod.StandBy();

                    foreach (Control c in group.Controls)
                    {
                        if(c.BackgroundImage != null)
                        {
                            c.BackgroundImage = Properties.Resources.Red;
                        }
                        if(c.Text.Equals("D�marer"))
                        {
                            c.Enabled = true;
                        }
                        else
                        {
                            c.Enabled = false;
                        }
                    }
                    foreach (ToolStripItem menu in productionMenu.DropDownItems)
                    {
                        foreach (ToolStripItem item in startMenu.DropDownItems)
                        {

                        }
                        if (menu.Text == prod.boxType.ToString())
                        {
                            menu.Enabled = true;
                        }
                        else
                        { 
                            menu.Enabled = false;
                        }
                    }
                }
            }
        }*/
    }
}
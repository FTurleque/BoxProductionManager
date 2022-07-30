using BoxProductionApp.Class;
using System.ComponentModel;

namespace BoxProductionApp.UserControls
{
    public partial class ProgressBarControl : UserControl
    {
        private Production prod;

        public ProgressBarControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Liaison du UserControl à sa Production.
        /// Mise à jour du nom de la progressBar et de son maximum.
        /// Abonnement au changement de la production.
        /// </summary>
        /// <param name="prod">Production à lier</param>
        public void ProdLink(Production prod)
        {
            this.prod = prod;
            lblProdName.Text = "Production " + prod.boxType.ToString();
            progressBarProd.Maximum = this.prod.totalProduction;
            this.prod.OnChange += ProdChange;
        }

        /// <summary>
        /// Mise à jour des ProgressBar en temps réel.
        /// </summary>
        /// <param name="sender">Production concerné par le changement</param>
        /// <param name="e">Evenement de changement de propriété</param>
        private void ProdChange(object? sender, PropertyChangedEventArgs e)
        {
            if (sender is Production prod)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    if (!prod.ProdEnding)
                    {
                        progressBarProd.Value = prod.BoxCounter;
                    }
                }));
            }
        }
    }
}

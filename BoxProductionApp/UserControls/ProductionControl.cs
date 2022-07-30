using BoxProductionApp.Class;
using System.ComponentModel;

namespace BoxProductionApp.UserControls
{
    public partial class ProductionControl : UserControl
    {
        private Production prod;

        public string BoxNumber => txtBoxBoxNumber.Text;

        public ProductionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Liaison du UserControl à sa Production.
        /// </summary>
        /// <param name="prod">Production à lier</param>
        public void ProdLink(Production prod)
        {
            this.prod = prod;
            this.prod.OnChange += ProdChange;
        }

        /// <summary>
        /// Mise à jour des TextBox en temps réel.
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
                        txtBoxBoxNumber.Text = prod.BoxCounter.ToString();
                        txtBoxDefectRatePerHour.Text = Math.Round(prod.DefectRateLastHour, 4).ToString("0.0000");
                        txtBoxGlobalDefectRate.Text = Math.Round(prod.GlobalDefectRate, 4).ToString("0.0000");
                    }
                }));
            }
        }
    }
}

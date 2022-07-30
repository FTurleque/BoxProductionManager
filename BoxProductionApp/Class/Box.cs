using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProductionApp.Class
{
    public class Box
    {
        // Boite défectueuse ou non.
        public readonly bool isOk;

        // Type de la boite produite.
        public readonly TypeOfBox boxType;

        // Date et heure de fabrication de la boite.
        public readonly TimeSpan manufacturingTime;

        // Génération d'un random pour générer le défault.
        private readonly Random random;

        /// <summary>
        /// Construction d'une boite avec génération aléatoire d'une boite défectueuse.
        /// </summary>
        /// <param name="_boxType">Type de la boite</param>
        public Box(TypeOfBox _boxType)
        {
            random = new Random();
            this.boxType = _boxType;
            isOk = BoxDefect();
            manufacturingTime = DateTime.Now.TimeOfDay;
        }

        /// <summary>
        /// Génération aléatoire d'une box déféctueuse.
        /// </summary>
        /// <returns>Boite déféctueuse ou non</returns>
        private bool BoxDefect()
        {
            // Trouver une meilleur méthode en lien avec une info de la prod.
            return random.NextDouble() > 0.1;
        }
    }
}

namespace BoxProductionApp.Class
{
    public static class ProdManager
    {
        // Liste des production
        public  static List<Production> Productions { get; private set; }
        private static Production? _prodByName;
        private static List<TypeOfBox> _types = new List<TypeOfBox>();
        private static List<ProdCreator> _prods = new List<ProdCreator>();

        /// <summary>
        /// Création d'instances de la class Production.
        /// </summary>
        public static void MakeProdInstancies()
        {
            Productions = new List<Production>();
            GetAllTypeOfBox();
            GetAllProdCreator();
            if (_types.Count == _prods.Count)
            {
                for (int i = 0; i < _prods.Count; i++)
                {
                    Productions.Add(new Production(_types[i], (int)_prods[i]));
                }
            }
            /*Productions.Add(new Production(TypeOfBox.A, 10000)); // 10000
            Productions.Add(new Production(TypeOfBox.B, 25000)); // 25000
            Productions.Add(new Production(TypeOfBox.C, 120000)); // 120000*/
        }

        /// <summary>
        /// Récupère toute les valeurs de l'enum TypeOfBox et les stockent dans une liste.
        /// </summary>
        private static void GetAllTypeOfBox()
        {
            foreach (TypeOfBox _type in Enum.GetValues(typeof(TypeOfBox)))
            {
                _types.Add(_type);
            }
        }

        /// <summary>
        /// Récupère toute les valeurs de l'enum ProdCreator et les stockent dans une liste.
        /// </summary>
        private static void GetAllProdCreator()
        {
            foreach (ProdCreator _prod in Enum.GetValues(typeof(ProdCreator)))
            {
                _prods.Add(_prod);
            }
        }

        /// <summary>
        /// Parcour de la liste de production.
        /// </summary>
        /// <param name="_type">Type de la production</param>
        /// <returns>Retourne une instance de Production spécifique par son type</returns>
        public static Production GetOneProdInstance(string _type)
        {
            foreach (Production prod in Productions)
            {
                if (prod.boxType.ToString() == _type)
                {
                    _prodByName = prod;
                }
            }
            return _prodByName;
        }
    }
}

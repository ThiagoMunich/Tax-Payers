namespace TaxPayers.Entities {
    abstract class TaxPayer {
        // Atributes
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        // Constructors
        protected TaxPayer(string name, double anualIncome) {
            Name = name;
            AnualIncome = anualIncome;
        }

        // Methods
        public abstract double Tax();

    } // end Class
} // end Namespace

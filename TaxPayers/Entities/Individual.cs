namespace TaxPayers.Entities {
    class Individual : TaxPayer {
        // Atributes
        public double HealthExpenditures { get; set; }

        // Constructors
        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome) {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax() {
            if(AnualIncome <= 20000.00) {
                if (HealthExpenditures > 0.0)
                    return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
                else
                    return (AnualIncome * 0.15);
            }
            else {
                if (HealthExpenditures > 0.0)
                    return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
                else
                    return (AnualIncome * 0.25);
            }
        } // end Tax()
    } // end Class
} // end Namespace

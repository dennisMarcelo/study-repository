using Contract.Calculator.Entities.Enums;

namespace Contract.Calculator.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } // Enumeração (enum)
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // Composição
        public List<HourCrontract> Contracts { get; set; } = new List<HourCrontract>(); // Foi feito isso para o atributo Contracts não ficar nulo

        // Via de regra nunca instancie associações para muitos, como é o caso de Crontracts, pois geralmente as listas são pupuladas depois
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourCrontract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourCrontract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourCrontract contract in Contracts)
            {   
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}

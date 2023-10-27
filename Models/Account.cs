using System;

namespace Models
{
    [Serializable]
    public class Account
    {
        public int Id { get; set; }
        public FinancialState FinancialState { get; set; }
        public string Name { get; set; }

        public Account()
        {
        }

        public Account(int id, FinancialState financialState, string name)
        {
            Id = id;
            FinancialState = financialState;
            Name = name;
        }
    }
}
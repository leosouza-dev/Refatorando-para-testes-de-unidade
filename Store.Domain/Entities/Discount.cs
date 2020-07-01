using System;

namespace Store.Domain.Entities
{
    public class Discount : Entity
    {
        public Discount(decimal amount, DateTime expireDate)
        {
            Amount = amount;
            ExpireDate = expireDate;
        }

        public decimal Amount { get; private set; }
        public DateTime ExpireDate { get; private set; }

        public bool IsValid()
        {
            // se DateTime.Now for menor que expire, o compare devolve que é menor que 0, então compara se é menor que zero
            return DateTime.Compare(DateTime.Now, ExpireDate) < 0;
        }

        public decimal Value()
        {
            if(IsValid())
            {
                return Amount;
            }
            else
            {
                return 0;
            }
        }
    }
}
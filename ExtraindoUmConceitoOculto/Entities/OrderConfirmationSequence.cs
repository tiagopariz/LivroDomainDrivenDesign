using System;

namespace ExtraindoUmConceitoOculto.Entities
{
    public class OrderConfirmationSequence
    {
        public OrderConfirmationSequence()
        {
            
        }

        public int Next()
        {
            var rnd = new Random();
            return rnd.Next(1, 999);
        }
    }
}
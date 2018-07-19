namespace ExtraindoUmConceitoOculto.Entities
{
    public class Booking
    {
        private OrderConfirmationSequence orderConfirmationSequence = new OrderConfirmationSequence();
        private OverbookingPolicy overbookingPolicy = new OverbookingPolicy();

        public Booking() { }

        public int MakeBooking(Cargo cargo, Voyage voyage)
        {
            // Permitir 10% de overbooking
            // double maxBooking = voyage.Capacity * 1.1;
            // if ((voyage.BookedCargoSize() + cargo.Size) > maxBooking)
            //     return -1;

            // Permitir 10% de overbooking
            if (!overbookingPolicy.IsAllowed(cargo, voyage))
                return -1;

            int confirmation = orderConfirmationSequence.Next();
            voyage.AddCargo(cargo, confirmation);
            return confirmation;
        }
    }
}
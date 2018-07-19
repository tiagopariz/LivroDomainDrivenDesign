namespace ExtraindoUmConceitoOculto.Entities
{
    public class OverbookingPolicy
    {
        public bool IsAllowed(Cargo cargo, Voyage voyage)
        {
            return (cargo.Size + voyage.BookedCargoSize()) <= 
                (voyage.Capacity * 1.1);
        }
    }
}
using System;
using System.Collections.Generic;

namespace ExtraindoUmConceitoOculto.Entities
{
    public class Cargo
    {
        private int _confirmation;

        public Cargo(double size)
        {
            Size = size;
        }

        public int Confirmation { get; }
        public double Size { get; }

        public void SetConfirmation(int confirmation)
        {
            _confirmation = confirmation;
        }
    }
}
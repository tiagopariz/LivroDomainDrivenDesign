using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtraindoUmConceitoOculto.Entities
{
    public class Voyage
    {
        private readonly List<Cargo> _cargos;

        public Voyage(Ship ship,
                      double overbooking,
                      double capacity)
        {
            Ship = ship;
            Overbooking = overbooking;
            Capacity = capacity;
            _cargos = new List<Cargo>();
        }

        public IReadOnlyCollection<Cargo> Cargos => _cargos;
        public Ship Ship { get; }
        public double Overbooking { get; }
        public double Capacity { get; }

        public void AddCargo(Cargo cargo, int confirmation)
        {
            cargo.SetConfirmation(confirmation);
            _cargos.Add(cargo);
        }

        public double BookedCargoSize()
        {
            return _cargos.Sum(x => x.Size);
        }
    }
}
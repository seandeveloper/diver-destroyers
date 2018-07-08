using System;

namespace DiverDestroyers.Equipment.Weapons
{
    public class HeavyLoads
    {
        private int _damage;

        public int Damage
        {
            get => _damage;
            set => _damage = value;
        }

        public HeavyLoads()
        {
            
        }

        public void DropAndCrush()
        {
            throw new NotImplementedException();
        }
    }
}
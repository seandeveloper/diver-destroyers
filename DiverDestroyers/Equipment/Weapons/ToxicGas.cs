using System;

namespace DiverDestroyers.Equipment.Weapons
{
    public class ToxicGas
    {
        private int _damage;

        public int Damage
        {
            get => _damage;
            set => _damage = value;
        }

        public ToxicGas()
        {
            
        }

        public void SwithGasAndPoison()
        {
            throw new NotImplementedException();
        }
    }
}
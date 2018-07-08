using System;

namespace DiverDestroyers.Equipment.Weapons
{
    public class Blades
    {
        private int _damage;

        public int Damage
        {
            get => _damage;
            set => _damage = value;
        }

        public Blades()
        {
            
        }

        public void StabAndSlash()
        {
            throw new NotImplementedException();
        }
    }
}
using System;

namespace DiverDestroyers.Equipment.Weapons
{
    public class Axes
    {
        private int _damage;

        public int Damage
        {
            get => _damage;
            set => _damage = value;
        }

        public Axes()
        {
            
        }

        public void HackAndSlash()
        {
            throw new NotImplementedException();
        }
    }
}
using System;

namespace DiverDestroyers.Equipment.Weapons
{
    public class Catheter
    {
        private int _damage;

        public int Damage
        {
            get => _damage;
            set => _damage = value;
        }

        public void InsertAndRemove()
        {
            throw new NotImplementedException();
        }
    }
}
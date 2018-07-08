using System;

namespace DiverDestroyers.Equipment.Weapons
{
    public class HpGuns
    {
        private int _damage;

        public int Damage
        {
            get => _damage;
            set => _damage = value;
        }

        public HpGuns()
        {
            
        }

        public void ShootAndCut()
        {
            throw new NotImplementedException();
        }
    }
}
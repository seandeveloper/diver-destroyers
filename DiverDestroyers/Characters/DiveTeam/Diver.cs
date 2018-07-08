using System;
using System.Threading;
using DiverDestroyers.Equipment.Armour;
using DiverDestroyers.Equipment.Weapons;

namespace DiverDestroyers.Characters.DiveTeam
{
    public class Diver
    {
        // Fields internal use
        private int _abilityPoints;
        private int _healthPoints;
        private int _level;
        private string _name;
        private string _faction;
        private Blades _greenRiver;
        private Arvests _arvest;


        // Properties getters/setters
        public int AbilityPoints
        {
            get => _abilityPoints;
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _abilityPoints = value;
                }
            }
        }

        public int HealthPoints
        {
            get => _healthPoints;
            set => _healthPoints = value;
        }

        public int Level
        {
            get => _level;
            set => _level = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Faction
        {
            get => _faction;
            set => _faction = value;
        }

        public Blades GreenRiver
        {
            get => _greenRiver;
            set
            {
                if (value.Damage >= 1)
                {
                    _greenRiver = value;
                }
            }
        }

        public Axes Axe { get; set; }

        public Arvests Arvest
        {
            get => _arvest;
            set => _arvest = value;
        }

        // Constructor
        public Diver()
        {
            
        }

        // Methods
        public void GreenRiverAttack()
        {
            throw new NotImplementedException();
        }

        public void HpGunAttack()
        {
            throw new NotImplementedException();
        }

        public void DiverGotLostDiffence()
        {
            throw new NotImplementedException();
        }
    }
}
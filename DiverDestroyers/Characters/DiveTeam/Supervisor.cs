﻿using DiverDestroyers.Equipment.Armour;
using DiverDestroyers.Equipment.Weapons;

namespace DiverDestroyers.Characters.DiveTeam
{
    public class Supervisor
    {
        // Fields internal use
        private int _abilityPoints;
        private int _healthPoints;
        private int _level;
        private string _name;
        private string _faction;
        private Blades _greenRiver;
        private Arvests _arvests;


        // Properties getters/setters
        public int AbilityPoints
        {
            get => _abilityPoints;
            set => _abilityPoints = value;
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
            set => _greenRiver = value;
        }

        public Arvests Arvests
        {
            get => _arvests;
            set => _arvests = value;
        }
        
        // Constructor 
        public Supervisor()
        {
            
        }
        
        // Methods
        public void ExtendShiftAttack()
        {
            
        }

        public void BabyDiverRoastingAttack()
        {
            
        }

        public void DownOnWeatherDefence()
        {
            
        }
    }
}
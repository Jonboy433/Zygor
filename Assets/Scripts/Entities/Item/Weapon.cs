using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Scriptable;

namespace Entities.Item
{
    public class Weapon : Item
    {

        [SerializeField]
        WeaponData stats;


        private int attackPower;
        private int attackSpeed;
        private bool equipable;
        private int requiredLvl;

        void Awake()
        {
            id = stats.ID;
            type = stats.Type;
            name = stats.Name;
            description = stats.Description;
            attackPower = stats.AttackPower;
            attackSpeed = stats.AttackSpeed;
            equipable = stats.Equipable;
            requiredLvl = stats.RequiredLevel;

        }

        // Start is called before the first frame update
        protected override void Start()
        {
            base.Start();

        }

        // Update is called once per frame
        protected override void Update()
        {
            //Nothing in base Update yet
        }

        public int AttackPower
        {
            get { return attackPower; }
        }

        public int AttackSpeed
        {
            get { return attackSpeed; }
        }

        public bool isEquipable
        {
            get { return equipable; }
        }

        public int RequiredLevel
        {
            get { return requiredLvl; }
        }
        //Make easy to access outside of this component?
        //or have a bunch of methods that can send data elsewhere?7
    }
}

/*
Base class for all characters in the game. 
 */
using UnityEngine;
using Scripts.Scriptable;

namespace Entities.Character
{
    public abstract class Character : MonoBehaviour
    {

        [SerializeField]
        new protected string name;

        [SerializeField]
        protected StartingCharAttributes attributes;

        [Space]
        [Header("Stats")]
        [SerializeField]
        private int strength;
        [SerializeField]
        private int intelligence;
        [SerializeField]
        private int stamina;
        [SerializeField]
        private int dexterity;

        [SerializeField]
        protected int currentHealth;

        [SerializeField]
        protected int maxHealth;

        [SerializeField]
        protected int currentMana;

        [SerializeField]
        protected int maxMana;

        [SerializeField]
        protected int currentLevel;

        [Space]
        [SerializeField]
        protected Vector3 spawnPoint;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Level
        {
            get { return currentLevel; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }

        public int Stamina
        {
            get { return stamina; }
            set { stamina = value; }
        }

        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }


        public int CurrentHealth
        {
            get { return currentHealth; }
            set { currentHealth = value; }
        }

        public int MaxHealth
        {
            get { return maxHealth; }
            set { maxHealth = value; }
        }

        public int CurrentMana
        {
            get { return currentMana; }
            set { currentMana = value; }
        }

        public int MaxMana
        {
            get { return maxMana; }
            set { maxMana = value; }
        }

        public Vector3 SpawnPoint
        {
            get { return spawnPoint; }
            set { spawnPoint = value; }
        }

        public virtual void Awake()
        {
            currentLevel = 1;
            Strength = attributes.Strength.BaseValue;
            Intelligence = attributes.Intelligence.BaseValue;
            Stamina = attributes.Stamina.BaseValue;
            Dexterity = attributes.Dexterity.BaseValue;
            CalcMaxHealth();
            CalcMaxMana();
        }

        public virtual void Start()
        {
            //Grab spawn point from scene for respawn purposes
            spawnPoint = transform.position;
        }

        public virtual void CalcMaxHealth()
        {
            CurrentHealth = Stamina * 5;
            MaxHealth = CurrentHealth;
        }
        public virtual void CalcMaxMana()
        {
            CurrentMana = Intelligence * 5;
            MaxMana = CurrentMana;
        }

        public abstract void Update();
    }
}

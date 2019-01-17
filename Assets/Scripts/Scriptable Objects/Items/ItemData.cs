using UnityEngine;
using Entities.Item;

namespace Scripts.Scriptable
{

    public abstract class ItemData : ScriptableObject
    {

        [SerializeField]
        protected new string name;

        [SerializeField]
        protected int id;

        [SerializeField]
        protected string description;

        [SerializeField]
        protected ItemType itemType;

        [SerializeField]
        protected int value;

        [SerializeField]
        protected float weight;

        [SerializeField]
        protected Sprite icon;

        [SerializeField]
        protected bool equipable;

        public string Name
        {
            get { return name; }
        }

        public int ID
        {
            get { return id; }
        }

        public ItemType Type
        {
            get { return itemType; }
        }

        public string Description
        {
            get { return description; }
        }

        public int Value
        {
            get { return value; }
        }

        public float Weight
        {
            get { return weight; }
        }

        public Sprite Icon
        {
            get { return icon; }
        }
        public bool Equipable
        {
            get { return equipable; }
        }
    }
}

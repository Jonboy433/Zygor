using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Scriptable
{

    [System.Serializable]
    public abstract class CharAttributes : ScriptableObject
    {
        [SerializeField]
        protected List<Attribute> attributes;

        public abstract List<Attribute> TheList();
        //public abstract Attribute Strength();
        //public abstract Attribute Stamina();
        //public abstract Attribute Intelligence();
        //public abstract Attribute Dexterity();

        public abstract Attribute Strength
        {
            get;
        }

        public abstract Attribute Stamina
        {
            get;
        }

        public abstract Attribute Intelligence
        {
            get;
        }

        public abstract Attribute Dexterity
        {
            get;
        }

    }
}
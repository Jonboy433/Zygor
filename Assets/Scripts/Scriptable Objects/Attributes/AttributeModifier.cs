/*
    Modifier.cs

    This class is used for keeping track of all of the different types of
    attribute modifiers. They can be added to Items, Spells, etc
 */

using UnityEngine;

namespace Scripts.Scriptable
{

    [System.Serializable]
    [CreateAssetMenu(fileName = "New Attr Modifier", menuName = "Attribute Modifer")]
    public class AttributeModifier : ScriptableObject
    {
        [SerializeField]
        new string name;

        [SerializeField]
        int id; // Give each modifier an ID for use with the DB

        [SerializeField]
        AttributeType attributeType;

        [SerializeField]
        int attrValue; // the value to increase/decrease the attribute

        public string Name
        {
            get { return name; }
        }

        public int ID
        {
            get { return id; }
        }

        public AttributeType Type
        {
            get { return attributeType; }
        }

        public int ModValue
        {
            get { return attrValue; }
        }
    }
}

using UnityEngine;

namespace Scripts.Scriptable
{

    [System.Serializable]
    public class Attribute
    {

        [SerializeField]
        new string name;

        [SerializeField]
        int baseValue;

        [SerializeField]
        int currentValue;

        [SerializeField]
        AttributeType attributeType;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int BaseValue
        {
            get { return baseValue; }
            set
            {
                if (value < 1)
                {
                    baseValue = 1;
                }
                else
                {
                    baseValue = value;
                }
            }
        }

        public int CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }

        public void BaseAttributeIncrease(int amt)
        {
            baseValue += amt;
        }

        public void BaseAttributeIncreaseByPercent(int amtPercent)
        {
            baseValue += (baseValue * (amtPercent / 100));
        }

        public void CurrentAttributeIncrease(int amt)
        {
            currentValue += amt;
        }

        public void CurrentAttributeIncreaseByPercent(int amtPercent)
        {
            currentValue += (currentValue * (amtPercent / 100));
        }

        public AttributeType GetAttributeType
        {
            get { return attributeType; }
        }

        public Attribute(AttributeType type)
        {
            attributeType = type;
            switch (type)
            {
                case AttributeType.STRENGTH:
                    name = "Strength";
                    break;

                case AttributeType.INTELLIGENCE:
                    name = "Intelligence";
                    break;

                case AttributeType.DEXTERITY:
                    name = "Dexterity";
                    break;

                case AttributeType.STAMINA:
                    name = "Stamina";
                    break;
                case AttributeType.MAX_HEALTH:
                    name = "Max Health";
                    break;
                case AttributeType.MAX_MANA:
                    name = "Max Mana";
                    break;
                default:
                    name = "";
                    break;
            }
        }

        public Attribute(int value, AttributeType type)
        {
            //Set the base value and then current to it
            baseValue = value;
            currentValue = baseValue;
            attributeType = type;

            switch (type)
            {
                case AttributeType.STRENGTH:
                    name = "Strength";
                    break;

                case AttributeType.INTELLIGENCE:
                    name = "Intelligence";
                    break;

                case AttributeType.DEXTERITY:
                    name = "Dexterity";
                    break;

                case AttributeType.STAMINA:
                    name = "Stamina";
                    break;
                case AttributeType.MAX_HEALTH:
                    name = "Max Health";
                    break;
                case AttributeType.MAX_MANA:
                    name = "Max Mana";
                    break;
                default:
                    name = "";
                    break;
            }
        }
    }
}
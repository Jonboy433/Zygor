using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Scriptable;

[CreateAssetMenu(fileName = "New Starting Attribute", menuName = "CharAttributes/Starting")]
public class StartingCharAttributes : CharAttributes
{
    public override Attribute Strength
    {
        get
        {
            return attributes
      .Find(attr => attr.GetAttributeType == AttributeType.STRENGTH);
        }
    }

    public override Attribute Stamina
    {
        get
        {
            return attributes
        .Find(attr => attr.GetAttributeType == AttributeType.STAMINA);
        }
    }

    public override Attribute Intelligence
    {
        get
        {
            return attributes
        .Find(attr => attr.GetAttributeType == AttributeType.INTELLIGENCE);
        }
    }

    public override Attribute Dexterity
    {
        get
        {
            return attributes
        .Find(attr => attr.GetAttributeType == AttributeType.DEXTERITY);
        }
    }

    public override List<Attribute> TheList()
    {
        return attributes;
    }
}

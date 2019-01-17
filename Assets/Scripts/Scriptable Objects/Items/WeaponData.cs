using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Scriptable;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Item - Weapon")]
public class WeaponData : ItemData
{
    [SerializeField]
    int attackPower;
    [SerializeField]
    int attackSpeed;
    [SerializeField]
    int requiredLevel;
    [SerializeField]
    List<AttributeModifier> modifiers;

    public int AttackPower
    {
        get { return attackPower; }
    }

    public int AttackSpeed
    {
        get { return attackSpeed; }
    }

    public int RequiredLevel
    {
        get { return requiredLevel; }
    }

    public List<AttributeModifier> Modifiers
    {
        get { return modifiers; }
    }
}

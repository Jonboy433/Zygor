using UnityEngine;
using Entities.Character;
using Scripts.Scriptable;

public class Character_Player : Character
{
    [SerializeField]
    int currentXP;

    [SerializeField]
    int XPtoNextLevel;

    #region MonoEvents
    public override void Awake()
    {
        base.Awake();
        //Setup data here
        Init();
    }

    void Init()
    {
        XPtoNextLevel = 100;
    }
    #endregion

    void LevelUp()
    {
        currentLevel += 1;
    }

    void GainExperience(int amt)
    {
        currentXP += amt;
        XPtoNextLevel -= amt;

        if (XPtoNextLevel < 1)
        {
            LevelUp();
        }
    }

    public override void Start()
    {
        base.Start();
    }

    public override void Update()
    {
        // Calc max health

        // Calc max mana

    }
}
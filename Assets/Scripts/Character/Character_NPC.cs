using UnityEngine;
using Entities.Character;

public class Character_NPC : Character
{

    [SerializeField]
    AggroType aggroType;

    public void Awake()
    {
        base.Awake();
        //Setup data here
        Init();
    }

    void Init()
    {

    }

    // Calc max health

    // Calc max mana

    public AggroType AggroType
    {
        get { return aggroType; }
    }

    public override void Start()
    {
        base.Start();
    }

    public override void Update()
    {

    }
}
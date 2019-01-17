using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Controller : MonoBehaviour
{

    Animator _anim;
    //Base class for each NPC in the scene    


    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

    }
}

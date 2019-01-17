using UnityEngine;
using UnityEngine.AI;
using Controllers.Movement;

public class NPCMovement : MonoBehaviour
{
    NavMeshAgent _agent;
    Vector3 currentPos;
    Vector3 lastPos;
    Animator anim;

    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {

    }

    void Update()
    {
        Wander();
        currentPos = transform.position;
        if (currentPos == lastPos)
        {
            Debug.Log("Not walking");
            anim.SetBool("isWalking", false);
        }
        else { anim.SetBool("isWalking", true); }



        lastPos = currentPos;
    }

    void Wander()
    {
        Debug.Log("Wandering...");
        //_agent.SetDestination(new Vector3(transform.position.x + 10f, 0, transform.position.y + 8f));
    }
}

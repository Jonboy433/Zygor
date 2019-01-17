using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLvl1 : MonoBehaviour
{

    void Awake()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            Debug.Log("Collision with player detected...");
    }
}


using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void StartGame()
    {
        Debug.Log("StartGame called...");
        SceneManager.LoadScene("Awakening");
    }
}

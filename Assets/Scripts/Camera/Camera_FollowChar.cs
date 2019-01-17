using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_FollowChar : MonoBehaviour
{


    public GameObject player;
    private Vector3 offset;
    public float rotateSpeed = 3.0f;
    float x = 0.0f;
    float y = 0.0f;
    float targetHeight = 3.0f;
    float distance = 4.7f;


    // Use this for initialization
    void Start()
    {
        //offset = transform.position - player.transform.position;
        Vector3 angles = transform.eulerAngles;
        float x = angles.x;
        float y = angles.y;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = player.transform.position + offset;
        if (!player)
        {
            return;
        }

        y = player.transform.eulerAngles.y;

        Quaternion rot = Quaternion.Euler(x, y, 0);
        transform.rotation = rot;

        Vector3 pos = player.transform.position - (rot * Vector3.forward *
        distance + new Vector3(0, -targetHeight, 0));
        transform.position = pos;
    }


}
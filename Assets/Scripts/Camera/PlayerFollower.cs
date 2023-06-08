using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(-7, 4, 0);


    // Update is called once per frame
    void LateUpdate() //For Camera
    {
        CameraFollow();
    }

    private void CameraFollow()
    {
        //Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}

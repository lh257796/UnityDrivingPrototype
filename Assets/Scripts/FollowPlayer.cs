using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    //this allows the GameObject player to be recognized
    private Vector3 offset = new Vector3(0, 8, -14);
    //allow a private offset variable to be used inside only this class, to offset the camera

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
            // this vector allows the camera to be placed vertically above and behind the player
    }
}

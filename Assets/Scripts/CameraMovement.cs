using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform followPlayer;
    public Transform followPlayer2;

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(followPlayer.position.x, followPlayer.position.y, -8);
        this.transform.position = new Vector3(followPlayer2.position.x, followPlayer2.position.y, -8);

    }
}

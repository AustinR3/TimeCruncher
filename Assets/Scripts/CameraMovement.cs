using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform followPlayer;

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(followPlayer.position.x, followPlayer.position.y, -8);

    }
}

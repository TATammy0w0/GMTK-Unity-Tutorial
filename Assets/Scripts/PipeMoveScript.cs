using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
        
        // destroy gameObj when it moves into the deadzone
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}

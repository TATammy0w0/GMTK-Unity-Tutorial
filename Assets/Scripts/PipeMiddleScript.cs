using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    void Start()
    {
        // When a gameObject does not exist in a scene, use this method to find it and access its component
        // This method will look for the first GO in the hierarchy with the tag
        // Remember to change the tag in the scene accordingly
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.AddScore(1);
        }
        
    }
}

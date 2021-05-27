using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Rigidbody2D tempbody;
    public Vector2 speed = new Vector2(15, 15);
    public Vector2 direction = new Vector2(0, 0);
    private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        tempbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
    }
    void FixedUpdate()
    {
        tempbody.velocity = movement;    
    }
}

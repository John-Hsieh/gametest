using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public int damage = 1;
    public bool isEnemy = false;
    public bool isEnemyShot = false;


    private Rigidbody2D tempbody;
    public Vector2 speed = new Vector2(25, 25);
    public Vector2 direction = new Vector2(0, 0);
    public Vector2 movement;
    // Start is called before the first frame update
    public void Start()
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

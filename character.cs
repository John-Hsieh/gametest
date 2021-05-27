using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
#region 1 - variables

    private Vector2 speed = new Vector2(50, 50);
    private Vector2 movement;
    private Rigidbody2D tempbody;
    public int initialHealth = 10;
    public int playerhealth = 10;
    public Rect HealthBar = new Rect(70,70,100,10);

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        tempbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool go = Input.GetKeyDown(KeyCode.Z);
        go |= Input.GetKeyDown(KeyCode.X);

        int key1 = 0;
        if (go)
        {
            //记录按下的帧数，判断特定按键按下不抬起
            key1++;
            Debug.Log("X连按:" + key1 + "帧");
        }

        if (go)//in here 
        {
            shoot temp = GetComponent<shoot>();
            if (temp != null) temp.attack(false);
        }

        #region 2-movementControl
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        movement = new Vector2(speed.x * inputX, speed.y * inputY);
        #endregion


        //ensure not to move out of screen
        var dist = (transform.position - Camera.main.transform.position).z;
        var leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).x;
        var rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x;
        var topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).y;
        var bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftBorder, rightBorder),
            Mathf.Clamp(transform.position.y, topBorder, bottomBorder), transform.position.z);
    }

    void FixedUpdate()
    {
        tempbody.velocity = movement;    
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.ToString().IndexOf("enemy")>=0)
        {
            bool damagePlayer = false;

            enemy coming = collision.gameObject.GetComponent<enemy>();
            if(coming != null)
            {
                healthScript enemyhealth = coming.GetComponent<healthScript>();
                if (enemyhealth != null) enemyhealth.Damage(enemyhealth.hp);
                damagePlayer = true;
            }
            if(damagePlayer)
            {
                healthScript player = this.GetComponent<healthScript>();
                if (player != null) player.Damage(1);
            }
        }
    }

    public void OnDestroy()
    {
        //gameobject will not be destroyed, need modification
        GameObject mygameobject = new GameObject();
        mygameobject.AddComponent<gameOver>();
        Destroy(mygameobject, 20);
    }

    void OnGUI()
    {
        //HP = Mathf.Lerp(HP, tmpHP, 0.05f);
        healthScript player = this.GetComponent<healthScript>();
        HealthBar = new Rect(20, 70, player.hp*50, 10);
        GUI.HorizontalScrollbar(HealthBar, 0.0f, player.hp*100, 0.0f, 1.0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMaker : MonoBehaviour
{
    public Transform platform1;
    public Transform platform2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void makeEnemy()
    {
        var enemyTransform = Instantiate(platform1) as Transform;
        enemyTransform.position = new Vector3(Camera.main.transform.position.x + Random.Range(14, 23), Random.Range(-8, 8), 1);
        enemyTransform.transform.parent = transform;
        enemy temp = enemyTransform.gameObject.GetComponent<enemy>();
        if(temp != null)
        {
            temp.direction.x = -1;
            int speedTemp = Random.Range(12, 17);
            temp.speed = new Vector2(Random.Range(12,17),Random.Range(12,17));
            Destroy(temp.gameObject, 3);
        }
    }

    void makePlatform()
    {
        var platformTransform = Instantiate(platform2) as Transform;
        platformTransform.position = new Vector3(Camera.main.transform.position.x + Random.Range(14, 23), Random.Range(-3, 3), 1);
        platformTransform.transform.parent = transform;
    }

    private void FixedUpdate()
    {
        if(transform.childCount <4)
        {
            if(Random.Range(0,10)>7)
            {
                makeEnemy();
            }
            //else
            //{
            //    makePlatform();
            //}
        }

    }
}

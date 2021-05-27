using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform shotPrefab;
    public float shootingRate = 0.1f;
    public float shootingCool;
    public Vector2 newdirect = new Vector2(1,0);


    // Start is called before the first frame update
    void Start()
    {
        shootingCool = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (shootingCool > 0f) shootingCool -= Time.deltaTime;
    }

    public void attack(bool isEnemy)
    {
        if(shootingCool <= 0f)
        {
            shootingCool = shootingRate;
            var shotTransform = Instantiate(shotPrefab) as Transform;
            shotTransform.position = transform.position;//new Vector3(0, 0, 0);//transform.position;
            bullet shot = shotTransform.gameObject.GetComponent<bullet>();
            if (shot != null) shot.isEnemyShot = isEnemy;
            shot.direction = newdirect;
            Destroy(shot.gameObject,3);
        }
    }
}

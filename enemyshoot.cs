using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    public Transform shotPrefab;
    public float shootingRate = 0.3f;
    public float shootingCool = 0f;
    public Vector2 newdirect = new Vector2(-1, 0);

    public void attack(bool isEnemy)
    {
        if (shootingCool <= 0f)
        {
            shootingCool = shootingRate;
            var shotTransform = Instantiate(shotPrefab) as Transform;
            shotTransform.position = transform.position;//new Vector3(0, 0, 0);//transform.position;
            bullet shot = shotTransform.gameObject.GetComponent<bullet>();
            if (shot != null) shot.isEnemyShot = isEnemy;
            shot.direction = newdirect;
            Destroy(shot.gameObject, 3);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        shootingCool = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (shootingCool > 0f) shootingCool -= Time.deltaTime;
        if (shootingCool <= 0f) attack(true);
    }


}

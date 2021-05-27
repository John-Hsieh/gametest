using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScript : MonoBehaviour
{
    public int hp = 5;
    public bool isEnemy = true;

    // Start is called before the first frame update
    public void Damage(int damageCount)
    {
        hp -= damageCount;
        if (hp <= 0)
        {
            //fireEffect.Instance.Explosion(transform.position);
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        bullet shot = collision.gameObject.GetComponent<bullet>();
        if(shot != null)
        {
            if(shot.isEnemy != isEnemy)
            {
                Damage(shot.damage);
                Destroy(shot.gameObject);
            }
        }
    }

}

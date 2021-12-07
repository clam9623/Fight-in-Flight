using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 20;
    public Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid.velocity = transform.right * speed; 
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
   
}

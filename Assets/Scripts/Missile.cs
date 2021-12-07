using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid.velocity = transform.right * speed; 
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
   
}

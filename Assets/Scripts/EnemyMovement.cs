using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float speed = 100.0f;
    private Rigidbody2D rigid;
    private Vector2 movement;

    void Start()
    {
        if (rigid == null)
            rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rigid.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rigid.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }


}

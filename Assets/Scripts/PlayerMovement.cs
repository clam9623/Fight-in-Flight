using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movement;
    [SerializeField] float elevation;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] float speed = 10.0f;
    [SerializeField] float scandere = 0.1f;
    [SerializeField] bool isFacingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null)
            rigid = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame; best for user input
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        elevation = Input.GetAxis("Vertical");
    }

    //FixedUpdate is called potentially multiple times per frame; best for physics and movement
    private void FixedUpdate()
    {
        rigid.velocity = new Vector2(movement * speed, rigid.velocity.y);
        if (movement < 0 && isFacingRight || movement > 0 && !isFacingRight)
            Flip();

        if (elevation < 0 || elevation > 0)
            Fly();
    }

    private void Flip()
    {
        //Vector3 playerScale = transform.localScale;
        //playerScale.x = playerScale.x * -1;
        //transform.localScale = playerScale;

        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;

    }

    private void Fly()
    {
        rigid.velocity = new Vector2(rigid.velocity.x, elevation * scandere);

        float soar = elevation * scandere;
        transform.Translate(0, soar, 0);
    }

}

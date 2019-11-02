using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacteScript : MonoBehaviour
{
    public float movespeed = 10f;
    private bool isFacingRight = true;
    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void run()
    {
        float move = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(move * movespeed, rigidbody.velocity.y);
        if (move > 0 && !isFacingRight)
            flip();
        else if (move < 0 && isFacingRight)
            flip();
    }

    void flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
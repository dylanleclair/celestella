using UnityEngine;

public enum Direction
{
    Up,
    Down,
    Left,
    Right
}

public class PlayerMover : MonoBehaviour
{

    CharacterController2D controller;
    float horizontal, vertical;
    Direction facing;
    SpriteRenderer r;
    float runSpeed = 40;
    Vector2 velocity = new Vector2();

    bool Grounded = false;
    bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController2D>();
        r = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetAxisRaw("Jump") == 1)
        {
            jump = true;
        }

    }


    private void FixedUpdate()
    {
        controller.Move(horizontal * 40 * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    /*private void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        if (horizontal == 0)
            rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y);
        position.x = position.x + 2.0f * horizontal * Time.deltaTime;

        if (Input.GetAxis("Jump") == 1)
        {
            rigidbody2d.AddForce(new Vector2(0, 1000));
            Debug.Log("Jumping!");
        }

        rigidbody2d.MovePosition(position); // move using physics!

    } */

}

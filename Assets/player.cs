using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f; // the speed at which the player moves
    public float jumpForce = 10f; // the force of the player's jump

    private Rigidbody rb; // the rigidbody component of the player character
    private bool isGrounded; // a flag indicating whether the player is on the ground

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // get input from the horizontal and vertical axes (WASD keys or arrow keys)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // move the player based on the input
        rb.velocity = new Vector3(horizontalInput * speed, rb.velocity.y, verticalInput * speed);

        // check if the player is pressing the space bar and is grounded
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // add a force upwards to the player's rigidbody
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // check if the player has collided with the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            // set the isGrounded flag to true
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // check if the player has left the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            // set the isGrounded flag to false
            isGrounded = false;
        }
    }
}

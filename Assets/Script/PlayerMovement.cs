using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; //variable for ball speed
    private float moveInput; // detects left or right key when pressed
    private  Rigidbody2D ball; // variable for rigid body (private to only acces it from the script)

   
    
    void Start()
    {
        ball = GetComponent<Rigidbody2D>(); // acces rigid body from script
    }

   
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal"); // if i press right key moveInput = 1,left key = -1 
        ball.velocity = new Vector2(moveInput * speed, ball.velocity.y); // adds force to the ball movement in order for the player to move,doesn't affect y axis
    }
}

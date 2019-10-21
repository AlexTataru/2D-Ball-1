using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; //variabila viteza mingii
    private float moveInput; // detecteaza daca apas stanga sau dreapta
    private Rigidbody2D rb; // variabila rigid body ( privat pt a accesaa doar din script)

   
    // variabila pentru viteza player
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // accesez rigid body din script
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal"); // daca apas sageata dreapta moveinput devine egal cu 1 si stanga cu -1
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y); // adauga forta mingii,sa se poata misca,nu afecteaza axa y
    }
}

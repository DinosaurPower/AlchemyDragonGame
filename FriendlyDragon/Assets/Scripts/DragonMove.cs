using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{


    public class DragonMove : MonoBehaviour
    {
  public float speed = 10.0f;
    public Rigidbody2D rb;
    public Vector3 movement;
    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
 
    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
    }
 
 
    void FixedUpdate()
    {
        moveCharacter(movement);
    }
 
 
    void moveCharacter(Vector3 direction)
    {
        rb.velocity = direction * speed;
    }
 
    }
}
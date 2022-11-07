using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{


    public class DragonMove : MonoBehaviour
    {

        public float speed = 10f;
        private static readonly int MovementSpeed = Animator.StringToHash("MovementSpeed");
        public float sc = 1;
        float moveSpeed = 0f;

        public Rigidbody2D rb;

        // Start is called before the first frame update
        void Start()
        {
            

        }


        // Update is called once per frame
        void Update()
        {
            moveSpeed = Input.GetAxisRaw("Horizontal")*speed+Input.GetAxisRaw("Vertical")*speed;
            transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*speed, Input.GetAxis("Vertical") * Time.deltaTime * speed,  0f);

       
            
            
            

        }
    }
}
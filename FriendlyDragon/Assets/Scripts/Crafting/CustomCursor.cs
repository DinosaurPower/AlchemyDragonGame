using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Bananagodzilla
{


    public class CustomCursor : MonoBehaviour
    {
        public Vector3 newPosition;

        // Start is called before the first frame update
        void Start()
        {
            newPosition = new Vector3();
            newPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
                Input.mousePosition.z));
            newPosition.z = -5f;
            transform.position = newPosition;
        }

        // Update is called once per frame
        void Update()
        {
            newPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
                Input.mousePosition.z));
            newPosition.z = -5f;
            transform.position = newPosition;
            //please don't forget to copypaste EVERYTHING not just 1/3 of code 
            //if you don't want images to yeet everywhere at mouse click, use screentoworld
        }
    }
}

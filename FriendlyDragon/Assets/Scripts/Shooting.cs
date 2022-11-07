using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{

    public class Shooting : MonoBehaviour
    {


        public GameObject projectile;
        private float timer;
        public Transform firePosition;
        public float timerAmount;
        public KeyCode[] keycodes;
        public SpriteRenderer spriteRenderer;
        public Sprite[] sprites;



        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            
            if (Input.GetKeyDown(keycodes[0]) && timer <= 0)
            {

                spriteRenderer.sprite = sprites[1];
                Instantiate(projectile, firePosition.position, firePosition.rotation);
                timer = timerAmount;
            }

            if (timer < -20)
            {
                spriteRenderer.sprite = sprites[0];
            }
            
            timer--;
            Debug.Log(timer);
        }
    }
}
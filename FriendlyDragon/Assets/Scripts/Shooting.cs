using System;
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
        public Shootables ObjSelect;
        public Item selectedElement;


        private void Start()
        {
            if (ObjSelect == null)
            {
                ObjSelect = FindObjectOfType(typeof(Shootables)) as Shootables;
            }
        }

        // Update is called once per frame
        void Update()
        {
         
            selectedElement = ObjSelect.currentItem;
            
            if ((Input.GetKeyDown(keycodes[0])||(Input.GetKeyDown(keycodes[1]))) && timer <= 0f && selectedElement.ItemAmount >0)
            {

                ObjSelect.Shot();
                spriteRenderer.sprite = sprites[1];
                Instantiate(projectile, firePosition.position, firePosition.rotation);
                timer = timerAmount;
           
            }

            if (timer < -60)
            {
                spriteRenderer.sprite = sprites[0];
            }
            
            timer--;
            
           // Debug.Log(timer);
        }
    }
}
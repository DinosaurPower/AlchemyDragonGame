using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    
    public class GameMango : MonoBehaviour
    {
        
        public static GameMango instance;
        public int score;
        public Vector2 spawnPosition;
        public Egg egg;
        private void Awake()
        {
        
            DontDestroyOnLoad(this);
            spawnPosition = egg.GetComponent<Transform>().position;
            if (instance == null)
            {
                instance = this;
            } else
            {
            
                GameObject.Destroy(gameObject);
            }

            

        }
        
        


        
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
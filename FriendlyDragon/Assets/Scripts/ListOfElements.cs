using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{


    public class ListOfElements : MonoBehaviour
    {
        public GameObject[] listOfElemets;
        public int[] countOfElements;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Increase(int num)
        {
            countOfElements[num]++;
        }
        public void Decrease(int num)
        {
            countOfElements[num]--;
        }
    }
}
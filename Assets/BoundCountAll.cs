using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BoundsControll
{
    public class BoundCountAll : MonoBehaviour
    {
        static private int count = 0; 
        [SerializeField]
        DisplayNumber displayNumber = null;
        private void Awake()
        {
            if (displayNumber == null)
            {
                displayNumber = GameObject.Find("NumberDisplay")
                    .GetComponent<DisplayNumber>();
            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            count++;
            displayNumber.num = count;
        }
    }
}

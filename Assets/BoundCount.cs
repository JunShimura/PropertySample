using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BoundsControll
{
    public class BoundCount : MonoBehaviour
    {
        private int count = 0;
        [SerializeField]
        DisplayNumber displayNumber;
        private void OnCollisionEnter(Collision collision)
        {
            count++;
            displayNumber.num = count;
            //displayNumber.num = displayNumber.num + 1;
        }
    }
}

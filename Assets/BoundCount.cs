using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BoundsControll
{
    public class BoundCount : MonoBehaviour
    {
        [SerializeField]
        Text outputCounter;
        DisplayNumber displayNumber;
        private void Start()
        {
            displayNumber = outputCounter.GetComponent<DisplayNumber>();
        }
        private void OnCollisionEnter(Collision collision)
        {
            displayNumber.num = displayNumber.num + 1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayNumber : MonoBehaviour
{
    Text outputText;
    public string formatString;
    private int _num=0;
    public int num
    {
        get
        {
            return _num;
        }
        set
        {
            _num=value;
            outputText.text = num.ToString(formatString);
        }
    }
    // Start is called before the first frame update
    void Awake()
    {
        outputText = GetComponent<Text>();
    }
}

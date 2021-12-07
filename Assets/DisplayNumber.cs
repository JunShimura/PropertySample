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
            if (_num != value)
            {
                _num = value;
                TextOutput();
            }
        }
    }
    // Start is called before the first frame update
    void Awake()
    {
        outputText = GetComponent<Text>();
    }
    private void OnEnable()
    {
        TextOutput();
    }
    private void TextOutput()
    {
        outputText.text = num.ToString(formatString);
    }
}

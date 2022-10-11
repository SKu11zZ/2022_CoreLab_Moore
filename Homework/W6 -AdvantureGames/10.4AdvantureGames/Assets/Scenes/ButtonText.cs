using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonText : MonoBehaviour
{
   // public string firstName;
    public TMP_Text tmp;
    public TMP_InputField inputField;
    private void start()
    {
       // tmp.SetText(firstName);
    }

    public void GetInPut(string text, InputField inputField)
    {
        string ourString = inputField.text;
        tmp.SetText(ourString);
    }
    public void SaySomething()
    {
        Debug.Log("Hello");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class storyscript : MonoBehaviour
{

    public string[] story = new string[15];
    private int _storyindex;

    public TMP_Text mainText;
    // Start is called before the first frame update
    void Start()
    {
        _storyindex = 0;
    }

    // Update is called once per frame
    public void NextLineofStory()
    {
        if(_storyindex >= story.Length)
        {
            mainText.SetText(story[_storyindex]);

            _storyindex++;
        }
        else
        {
            mainText.SetText("The End");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
public class inkStoryScript : MonoBehaviour
{
    public TextAsset inkJSON;
    private Story story1;
    // Start is called before the first frame update
    void Start()
    {
        story1 = new Story(inkJSON.text);
        Debug.Log(story1.Continue());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBotton : MonoBehaviour
{
    public GameObject Tips;
    public GameObject RealBotton;
    // Start is called before the first frame update
    void Start()
    {
        Tips.SetActive(false);
        RealBotton.SetActive(false);
    }
    

}

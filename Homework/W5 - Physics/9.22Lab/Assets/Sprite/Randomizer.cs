using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Randomizer : MonoBehaviour

{
    public int[] dice = new int[6];
    Random random = new Random();
    //public GameObject[] shape;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i < 7; i++) ;

            int i = random.Next(6);

        //for (int i = 0; i < dice.Length; i++)
        if (Input.GetKey(KeyCode.W)) 
        {
            Debug.Log(dice[i]);
            //Debug.Log(shape);
    
        }
        
    }
}

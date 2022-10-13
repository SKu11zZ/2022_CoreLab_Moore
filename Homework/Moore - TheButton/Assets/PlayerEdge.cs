using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEdge : MonoBehaviour
{
    public GameObject falloutPlayer;

    // Start is called before the first frame update
    void Start()
    {
        falloutPlayer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            falloutPlayer.SetActive(true);
        }

    }
}

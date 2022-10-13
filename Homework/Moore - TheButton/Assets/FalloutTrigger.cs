using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalloutTrigger : MonoBehaviour
{
    public GameObject fallout;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        fallout.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            fallout.SetActive(true);
            source.Play();
        }

    }
}

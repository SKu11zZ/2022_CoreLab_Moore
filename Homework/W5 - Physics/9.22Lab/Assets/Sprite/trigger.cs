using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public Transform newTarget;
    private SpriteRenderer _spriteRenderer;
    private Camera1 _c;
    public float targetSize;
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        _spriteRenderer.enabled = false;

        _c = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera1>();


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))

            _c.ChangeTarget(newTarget, targetSize);
        
            Debug.Log("Hello");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Player"));

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratController : MonoBehaviour
{
    Rigidbody2D rb;
    public AudioClip death;
    AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        aud = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void die()
    {
        aud.PlayOneShot(death);
        Debug.Log("rat ded");
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratController : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody2D rb;
<<<<<<< Updated upstream
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

=======
    public AudioClip death;
    AudioSource aud;
    Animator anim;
    bool dead = false;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        aud = gameObject.GetComponent<AudioSource>();
        anim = gameObject.GetComponent<Animator>();
        //get player pos for look dir in anim, if < rat pos then 0, else 1
>>>>>>> Stashed changes
    }
    void Update()
    {

<<<<<<< Updated upstream
    }
    public void die()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Destroy(gameObject);
        player.GetComponent<Score>().score += 1;
=======

        //animation
        anim.SetBool("dead", dead);
        //killing
        if (dead && !aud.isPlaying)//destroy when audio is done playing and dead
        {
            Destroy(gameObject);
        }
    }
    public void die()
    {
        aud.PlayOneShot(death);
        Debug.Log("rat ded");
        dead = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        player play = collision.GetComponent<player>();
        if (play != null)
        {
            if (play.transform.position.x < gameObject.transform.position.x)
            {
                anim.SetFloat("lookDir", 0);
                rb.velocity.Set(speed, 0.0f);
            }
            else
            {
                anim.SetFloat("lookDir", 1);
                rb.velocity.Set(-speed, 0.0f);
            }
        }
>>>>>>> Stashed changes
    }
}

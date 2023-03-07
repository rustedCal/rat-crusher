using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //movwement stuff
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    public float speed = 3.0f;
    //animation stuff
    Animator anim;
    float lookH;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        anim.SetFloat("hMove", horizontal);
        if(horizontal > 0)
        {
            lookH = 1;
        }
        else if(horizontal < 0)
        {
            lookH = -1;
        }
        anim.SetFloat("hLook", lookH);
        anim.SetFloat("Speed", Mathf.Abs(horizontal));
        //put rat hitting here (keybind to spacebar)
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("hit", true);
            RaycastHit2D hit = Physics2D.Raycast(rigidbody2d.position + Vector2.up * 0.2f, new Vector2(lookH,0), 3.0f, LayerMask.GetMask("rat"));
            if(hit.collider != null)
            {
                Debug.Log(hit);
                ratController rat = hit.collider.GetComponent<ratController>();
                if(rat != null)
                {
                    rat.die();
                }
            }
        }
        else
        {
            anim.SetBool("hit", false);
        }
    }
    void FixedUpdate()
    {
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }
}

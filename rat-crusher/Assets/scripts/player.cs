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
        if (!Mathf.Approximately(horizontal, 0.0f) || !Mathf.Approximately(horizontal, 0.0f))
            lookH = horizontal;
        anim.SetFloat("hLook", lookH);
        anim.SetFloat("Speed", Mathf.Abs(horizontal));
        //put rat hitting here (keybind to spacebar)
    }
    void FixedUpdate()
    {
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratController : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void die()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Destroy(gameObject);
        player.GetComponent<Score>().score += 1;
    }
}

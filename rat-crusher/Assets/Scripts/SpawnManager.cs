using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public float Rats;
    public GameObject ratPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rats = GameObject.FindGameObjectsWithTag("rat").Length;
        if(Rats <= 1)
        {
            Instantiate(ratPrefab, new Vector3(Random.Range(-15, 15), -6, 0), Quaternion.identity);
        }
    }
}

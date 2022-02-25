using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    private bool forwardmove;

    // Start is called before the first frame update
    void Start()
    {
        forwardmove = true;
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //if(forwardmove == true)
        //{
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        //}
        
       
    }
}

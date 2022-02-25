using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody playerRb;
    public float speed = 5.0f;
    private float horizontalInput;
    private float verticalInput;
  

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
      
       horizontalInput = Input.GetAxis("Horizontal");
       verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);
        
    }
}

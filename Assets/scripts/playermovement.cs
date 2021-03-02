using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    float xaxis, yaxis, zaxis;
    bool jump = false;
    public float jumpheight = 2f;
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideforce = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()

    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<manager>().Endgame();
        }
        if (Input.GetKey("w") && jump == false)
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpheight;
            jump = true;
        }
        
    }
}

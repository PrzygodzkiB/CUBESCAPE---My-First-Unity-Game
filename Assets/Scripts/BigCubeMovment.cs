
using UnityEngine;

public class BigCubeMovment : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

     public Vector3 m_EulerAngleVelocity_x = new Vector3(100, 0, 0);
    public Vector3 m_EulerAngleVelocity_y = new Vector3(0, 100, 0);

    void Start()
    {
     

        //Set the angular velocity of the Rigidbody (rotating around the Y axis, 100 deg/sec)
        
    }

    // Update is called once per frame
    void FixedUpdate()//u¿ywamy fixedupdate do fizyki 
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);// time.deltatime to czas od poprzedniej klatki

        if (Input.GetKey("d"))
        {
            //rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity_x * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
        if (Input.GetKey("a"))
        {
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity_y * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
    }
    }

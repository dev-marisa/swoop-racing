using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers {
    public class PlayerMovement : MonoBehaviour
    {

        public Rigidbody rb;
        public float forwardForce = 1000f;
        public float sidewaysForce = 50f;

        // We marked this as FixedUpdate because 
        // we are using it with to mess with physics
        void FixedUpdate()
        {
            // add a forward force
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            if( Input.GetKey("d") ) 
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if( Input.GetKey("a") )
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if( rb.position.y < -2f) 
            {
                FindObjectOfType<GameManager>().EndGame();
            }

        }
    }

}

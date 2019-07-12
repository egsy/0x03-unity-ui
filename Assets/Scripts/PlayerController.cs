using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Introduces public class to control player movement
/// </summary>
/// <remarks>
/// Within this script, update the Start() and FixedUpdate() functions to allow the Player to move when either the WASD or arrow keys are pressed
/// </remarks>
public class PlayerController : MonoBehaviour
{

    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    public float speed = 888f;
    private int score = 0;
    public int health = 5;

    /// <summary>
    /// Detect collisions between the Player and GameObjects with Colliders attached
    /// </summary>
    /// <param name="other">GameObject</param>
    void OnTriggerEnter(Collider other)
    {
        /// Decrement value of health when Player triggers objects tagged Trap
        if (other.gameObject.tag == "Trap")
        {
            health -= 1;
            Debug.Log(string.Format("Health: {0}", health));
        }

        /// Increments value of score when Player triggers objects tagged Pickup
        if (other.gameObject.tag == "Pickup")
        {
            score += 1;
            Debug.Log(string.Format("Score: {0}", score));
            Destroy(other.gameObject);
        }
    }

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Allows player to move when either the WASD or arrow keys are pressed
    /// </summary>
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
    }

    /// <summary>
    /// Udpate is called once per frame
    /// </summary>
    void Update()
    {
    }

}


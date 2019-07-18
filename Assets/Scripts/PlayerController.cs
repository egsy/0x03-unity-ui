using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    public Text scoreText;
    public Text healthText;
    public Image winLoseImage;

    /// <summary>
    /// Detect collisions between the Player and GameObjects with Colliders attached
    /// </summary>
    /// <param name="other">GameObject</param>
    void OnTriggerEnter(Collider other)
    {
        /// Alert player that objective was reached
        if (other.gameObject.tag == "Goal")
        {
            winLoseImage.SetActive(true);
            Debug.Log(string.Format("You win!"));
            // transform.winLose.SetActive(true);
            // transform

        }

        /// Decrement value of health when Player triggers objects tagged Trap
        if (other.gameObject.tag == "Trap")
        {
            health -= 1;
        }

        /// Increments value of score when Player triggers objects tagged Pickup
        if (other.gameObject.tag == "Pickup")
        {
            score += 1;
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
    /// Update is called once per frame
    /// Game is reset once health reaches 0
    /// </summary>
    void Update()
    {
        SetScoreText();
        SetHealthText();
        if (health == 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene("maze");
            health = 5;
            score = 0;
        }
    }

    /// <summary>
    /// Updates ScoreText object with current score
    /// </summary>
    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    /// <summary>
    /// Updates HealthText object with current health
    /// </summary>
    void SetHealthText()
    {
        healthText.text = "Health: " + health.ToString();
    }

    void WinLoseText()
    {
        // transform.
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sets main camera movement to follow Player as it moves
/// Camera does not need to rotate
/// position should remain constant offset from Player's position
/// </summary>
public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 relativePos;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        relativePos = new Vector3(0, -35.5f, 20);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position - relativePos;
        transform.eulerAngles = new Vector3(45.0f, 0, 0);
    }
}

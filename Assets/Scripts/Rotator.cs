using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Animates coins in maze
/// </summary>
public class Rotator : MonoBehaviour
{
    public Vector3 rotate;

    // Start is called before the first frame update
    void Start()
    {
        rotate = new Vector3(45, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate()
        transform.Rotate(rotate * Time.deltaTime);
    }
}

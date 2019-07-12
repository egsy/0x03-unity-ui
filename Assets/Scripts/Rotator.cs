using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Animates coins in maze
/// </summary>
public class Rotator : MonoBehaviour
{
    public float rotate = 100.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate()
        transform.Rotate(rotate * Time.deltaTime, 0, 0);
    }
}

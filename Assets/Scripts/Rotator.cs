using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Animates coins in maze
/// </summary>
public class Rotator : MonoBehaviour
{
    public float rotate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotate = 45.0f;
        transform.Rotate(rotate * Time.deltaTime, 0, 0);
    }
}

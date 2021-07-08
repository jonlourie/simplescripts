using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    [SerializeField]
    private float cubespeed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * cubespeed * Time.deltaTime);
    }
}

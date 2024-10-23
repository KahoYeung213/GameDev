using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotY=0.05f;
    // Update is called once per frame
    void Update()
    {
    transform.Rotate(0, rotY, 0);
    }
}

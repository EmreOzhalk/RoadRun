using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMove : MonoBehaviour
{
    public float moveSpeed = 3;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime *moveSpeed, Space.World);
    }
}

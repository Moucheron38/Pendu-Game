using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMove : MonoBehaviour
{
    public float speedRotation = 5f;
    void Update()
    {
        RotateHead();
    }

    private void RotateHead()
    {
        transform.Rotate(Vector3.forward * speedRotation * Time.deltaTime);
    }
}

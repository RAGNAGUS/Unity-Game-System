using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour
{
    private float _sensitivity = 1.0f;

    void Update()
    {
        float _mouseX = Input.GetAxis("Mouse X");

        Vector3 newAngles = transform.localEulerAngles;

        newAngles.y += _mouseX * _sensitivity;

        transform.localEulerAngles = newAngles;
    }
}

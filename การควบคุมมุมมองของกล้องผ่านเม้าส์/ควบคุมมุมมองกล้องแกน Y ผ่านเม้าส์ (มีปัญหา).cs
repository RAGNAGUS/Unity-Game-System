using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ปัญหาที่เกิดขึ้นคือเมื่อนำไฟล์สคริปที่ควบคุมมุมกล้องแกน Y แล้วหมุนมุมกล้อง ทำให้ตัวละครไหลเนื่องจาก gravity
//แก้ไขโดยนำไฟล์สคริปแกน X ใส่เข้าไปในตัวละคร และไฟล์สคริปแกน Y ใส่เข้าไปใน Empty Object ที่เป็น Childe ของตัวละครและ Empty Object เป็น Parent ของ Camera

public class LookY : MonoBehaviour
{
    private float _sensitivity = 1.0f;

    void Update()
    {
        float _mouseY = Input.GetAxis("Mouse Y");

        Vector3 newAngles = transform.localEulerAngles;

        newAngles.x -= _mouseY * _sensitivity;

        transform.localEulerAngles = newAngles;
    }
}


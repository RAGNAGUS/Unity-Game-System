using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {
	//ซ่อนเม้าส์
        Cursor.visible = false;
	//ล็อคเม้าส์ให้อยู่ภายในเกมเท่านั้น
        Cursor.lockState = CursorLockMode.Locked;
	
	//แสดงเม้าส์
        Cursor.visible = true;
	//ทำให้สามารถลากเม้าส์ออกจากเกมได้
        Cursor.lockState = CursorLockMode.None;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Raycasting คือการตรวจสอบว่าสิ่งที่ผู้เล่นกำลังชี้อยู่ตามระยะที่กำหนดคืออะไร เช่นกำหนดว่า ScreenPointToRay กำหนดให้แกน X เท่ากับ หน้าจอ/2 (กลางจอ) และแกน Y เท่ากับ ขนาดหน้าจอ/2(กลางจอ)
//ทำให้เป็นเหมือนจุดกลางจอ เมื่อผู้เล่นชี้จุดนั้นไปยัง Game Object ไหน เราสามารถถึงข้อมูล Game Object นั้นมาได้ เช่น ชื่อ ตำแหน่ง แท็ก

public class Player : MonoBehaviour
{
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
	          //ให้ RayOrigin เท่ากับหน้าต่างของเกม ViewportPointToRay โดยตำแหน่งคือ X = 0.5(กลางจอ) Y = 0.5(กลางจอ) ทำให้เป็นเหมือนจุดกลางจอ
	          //โดยวิธีนี้จะดีกว่า ScreenPointToRay เพราะอ้างอิงตามขนาดของหน้าต่างเกม ทำให้มีความแม่นยำมากกว่า
            Ray rayOrigin = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
		
	          //ให้ rayOrigin2 เท่ากับหน้าต่างของเกม ScreenPointToRay โดยกำหนดให้แกน X เท่ากับ หน้าจอ/2 (กลางจอ) และแกน Y เท่ากับ ขนาดหน้าจอ/2(กลางจอ) ทำให้เป็นเหมือนจุดกลางจอ
	          //แต่ด้วยที่การหารครึ่งของหน้าจอที่แตกต่างกันไปทำให้อาจมีข้อผิดพลาดเล็กน้อย
            Ray rayOrigin2 = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));

            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                Debug.Log("Hit: " + hitInfo.transform.name);
            }

            if (Physics.Raycast(rayOrigin, Mathf.Infinity))
            {
                Debug.Log("Hit Something");
            }
        }
     }
}

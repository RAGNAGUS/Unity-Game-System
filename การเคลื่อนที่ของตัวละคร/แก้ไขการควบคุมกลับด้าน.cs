using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private CharacterController _controller;
    private float _speed = 3.5f;
    private float _gravity = 9.81f;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        Vector3 velocity = direction * _speed;

        velocity.y -= _gravity;

	//ปัญหาคือการควบคุมกลับด้าน โดยตัวละครไม่หันไปในทิศทางเดียวกันกับกล้อง เนื่องจากเมื่อตัวละครเคลื่อนที่ ทิศทางจะเคลื่อนไปตาม Local Space แต่มุมกล้องหมุนไปตาม World Space
	//แก้ไขโดยให้ velocity แปลงจาก Local Space ไปยัง World Space เมื่อตัวละครเคลื่อนที่
	velocity = transform.transform.TransformDirection(velocity);

        _controller.Move(velocity * Time.deltaTime);
    }
}

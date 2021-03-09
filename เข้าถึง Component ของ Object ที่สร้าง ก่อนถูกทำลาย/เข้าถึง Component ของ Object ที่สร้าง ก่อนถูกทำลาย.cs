using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChildComponent : MonoBehaviour
{
	//ปกติแล้วการ Instantiate ขึ้นมาแล้วทำลายทันจะ เราจะไม่สามารถเข้าถึง Component ที่เราสร้างขึ้นมาได้
	//แก้ไขโดยให้เราสร้าง GameObject เพื่อจะมาเก็บสิ่งที่เราสร้างไว้ หลังจากนั้นเราสามารถเข้าถึง Component ของสิ่งที่สร้างมาได้
	GameObject diamond = Instantiate(diamondPrefab, transform.position, Quaternion.identity);
	diamond.GetComponent<Diamond>().gems = gems;
	Destroy(this.gameObject,1);
}

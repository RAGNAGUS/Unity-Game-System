using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject _hitMarkerPrefab;

    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Ray rayOrigin = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

            Ray rayOrigin2 = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));

            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                Debug.Log("Hit: " + hitInfo.transform.name);
		//ทำการสร้างโมเดลหรือเอฟเฟคตามตำแหน่งของ Hitinfo เช่นทำระบบยิงปืนแล้วต้องการให้มีรอยกระสุนบนพื้นเป็นต้น
		//Quaternion.LookRotation(hitInfo.normal) เป็นการทำให้เมื่อสร้างโมเดลหรือเอฟเฟคขึ้นมาแล้ว จะหมุนไปตามพื้นผิวของโมเดลที่เราชี้
		//เพิ่มเติม โค้ตด้านล่างจะเป็นการสร้าง Game Object แล้วเก็บไว้ในตัวแปร hitMarker
                GameObject hitMarker = Instantiate(_hitMarkerPrefab, hitInfo.point, Quaternion.LookRotation(hitInfo.normal)) as GameObject;
		//ทำให้สามารถทำลายหรือใช้ฟังก์ชั่นอื่น ๆ กับ Game Object ที่สร้างได้ขึ้นมาทันที
                Destroy(hitMarker.gameObject, 0.1f);
            }

            /*if (Physics.Raycast(rayOrigin, Mathf.Infinity))
            {
                Debug.Log("Hit Something");
            }*/

            _muzzleFlash.SetActive(true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            _muzzleFlash.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChildComponent : MonoBehaviour
{
	//transform.GetChild(1) เป็นการเข้าถึงข้อมูลของลูกโดยตัวเลขหมายถึงลำดับของลูก
   SpriteRenderer ArcSprite = transform.GetChild(1).GetComponent<SpriteRenderer>();
}

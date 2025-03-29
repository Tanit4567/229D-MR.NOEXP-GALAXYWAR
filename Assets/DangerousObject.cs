using UnityEngine;

public class DangerousObject : MonoBehaviour
{
    void Start()
    {
        // ตั้งค่า Tag เป็น "DangerousObject"
        gameObject.tag = "DangerousObject";

        // ตรวจสอบว่ามี Collider หรือไม่
        Collider col = gameObject.GetComponent<Collider>();
        if (col == null)
        {
            // ถ้าไม่มี Collider ให้เพิ่ม BoxCollider เป็นค่าเริ่มต้น
            col = gameObject.AddComponent<BoxCollider>();
        }

        // ตั้งค่า Collider ให้เป็น Trigger
        col.isTrigger = true;
    }
}

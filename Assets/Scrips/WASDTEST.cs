using UnityEngine;

public class WASDTEST : MonoBehaviour
{
    public float speed = 5.0f; // ความเร็วในการเคลื่อนที่

    void Update()
    {
        Vector3 move = Vector3.zero;

        // ตรวจสอบปุ่มกดแล้วกำหนดทิศทางการเคลื่อนที่
        if (Input.GetKey(KeyCode.W))
        {
            move += Vector3.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move += Vector3.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            move += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move += Vector3.right;
        }

        // ทำให้การเคลื่อนที่ราบรื่นตามเวลา
        transform.Translate(move * speed * Time.deltaTime);
    }
}

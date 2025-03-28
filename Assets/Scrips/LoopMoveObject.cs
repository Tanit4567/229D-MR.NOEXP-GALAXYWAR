using UnityEngine;

public class MoveLoop : MonoBehaviour
{
    public float speed = 2.0f;  // ความเร็วในการเคลื่อนที่
    public float moveDistance = 3.0f; // ระยะทางที่เคลื่อนที่แต่ละทิศทาง
    private Vector3[] directions = { Vector3.up, Vector3.right, Vector3.down, Vector3.left }; // ลำดับการเคลื่อนที่
    private int currentDirectionIndex = 0; // ทิศทางปัจจุบัน
    private Vector3 startPosition; // ตำแหน่งเริ่มต้นของการเคลื่อนที่
    private Vector3 targetPosition; // จุดหมายปลายทางของการเคลื่อนที่

    void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition + directions[currentDirectionIndex] * moveDistance;
    }

    void Update()
    {
        // เคลื่อนที่ไปยังตำแหน่งเป้าหมาย
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // ตรวจสอบว่าถึงจุดหมายปลายทางหรือยัง
        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            // เปลี่ยนไปทิศทางถัดไปในลูป
            currentDirectionIndex = (currentDirectionIndex + 1) % directions.Length;
            targetPosition = transform.position + directions[currentDirectionIndex] * moveDistance;
        }
    }
}

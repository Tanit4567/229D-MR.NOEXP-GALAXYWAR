using UnityEngine;

public class MyAirFoceAndMovement : MonoBehaviour
{
    public float speed = 5.0f; // ความเร็วในการเคลื่อนที่

    private Rigidbody rb;
    public float enginePower = 50f;
    public float liftBooster = 0.5f;
    public float dragDamp = 0.03f;
    public float angularDragDamp = 0.03f;

    public float yawPower = 50;
    public float pitchPower = 50;
    public float rollPower = 30;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Thrust
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(transform.forward * enginePower);
        }

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

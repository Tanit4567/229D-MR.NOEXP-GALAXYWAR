using UnityEngine;

public class WASD : MonoBehaviour
{
    public float speed = 0f;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        
        float moveX = 0f;
        float moveY = 8f;

        if (Input.GetKey(KeyCode.W))
        {
            
            rb.AddForce(Vector3.up * moveY, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.up * -moveY, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -10f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 10f;
        }

        Vector3 moveDirection = new Vector3(moveX, 0f, moveY).normalized;
        transform.position += moveDirection * speed * Time.deltaTime;
    }
}

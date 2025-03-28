using UnityEngine;

public class MyAirFoce : MonoBehaviour
{
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
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * enginePower);
        }

    }
}

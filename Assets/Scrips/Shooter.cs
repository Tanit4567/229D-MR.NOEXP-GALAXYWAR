using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform firePoint;

    void Update()
    {
        Shooting();
    }// Update

    void Shooting()
    {
        Debug.DrawRay(firePoint.position, transform.forward * 30f, Color.green);

        RaycastHit hit;

        if (Physics.Raycast(firePoint.position, transform.forward, out hit, 30f))
        {
            Debug.DrawRay(firePoint.position, transform.forward * 30f, Color.red);
        }
    }//Shooting
}

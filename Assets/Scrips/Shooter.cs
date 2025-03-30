using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform firePoint;

    public GameObject vfxFirePoint, vfxHitPoint;

    void Update()
    {
        Shooting();
    }// Update

    void Shooting()
    {
        Debug.DrawRay(firePoint.position, transform.forward * 60f, Color.green);

        RaycastHit hit;

        if (Physics.Raycast(firePoint.position, transform.forward, out hit, 60f))
        {
            Debug.DrawRay(firePoint.position, transform.forward * 60f, Color.red);

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(vfxFirePoint, firePoint.position, Quaternion.identity);
                Instantiate(vfxHitPoint, hit.point, Quaternion.identity);

                if (hit.collider.name == "meteorite")
                {
                    Enemy enemy = hit.collider.GetComponent<Enemy>();

                    if (enemy != null)
                    {
                        enemy.TakeDamage(5);
                    }

                }

                if (hit.collider.name == "meteorite")
                {
                    BigEnemy enemy = hit.collider.GetComponent<BigEnemy>();

                    if (enemy != null)
                    {
                        enemy.TakeDamage(5);
                    }

                }
            }//KeyCode.Space
        }//Shooting
    }
}

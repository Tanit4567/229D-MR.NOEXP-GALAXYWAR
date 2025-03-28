using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 10;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }//TakeDamage

    public GameObject healthBar;
    void Update()
    {
        healthBar.transform.localScale = new Vector3(health * 0.003f, 0.005f, 0.001f);

    }// Update

}

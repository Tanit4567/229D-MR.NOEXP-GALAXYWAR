using UnityEngine;
using UnityEngine.SceneManagement;

public class BigEnemy : MonoBehaviour
{
    public int health = 10;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
        

    }//TakeDamage

    void ReturnToCredit()
    {
        
    }

    public GameObject healthBar;
    void Update()
    {
        healthBar.transform.localScale = new Vector3(health * 0.00050f, 0.004f, 0.001f);

    }// Update
}

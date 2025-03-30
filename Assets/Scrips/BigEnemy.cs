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

            Invoke("ReturnToCredit", 1f); // หน่วงเวลา 2 วินาทีก่อนกลับไป Main Menu
            gameObject.SetActive(false);
        }

    }//TakeDamage

    void ReturnToCredit()
    {
        SceneManager.LoadScene("Credit");
    }

    public GameObject healthBar;
    void Update()
    {
        healthBar.transform.localScale = new Vector3(health * 0.00050f, 0.004f, 0.001f);

    }// Update
}

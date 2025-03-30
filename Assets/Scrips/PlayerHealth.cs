using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 1; // ชีวิตของผู้เล่น (โดนครั้งเดียวตาย)

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DangerousObject")) // ถ้าชนวัตถุที่มี Tag นี้
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player Died!");
        Destroy(gameObject); // ซ่อนผู้เล่น (หรือใช้ Destroy(gameObject) ถ้าต้องการให้หายไป)

        // โหลดฉากใหม่หลังจากตาย
        Invoke("RestartLevel", 2f); // รอ 2 วินาทีก่อนโหลดใหม่
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

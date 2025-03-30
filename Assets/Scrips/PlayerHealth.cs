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
        Invoke("ReturnToMainMenu", 1f); // หน่วงเวลา 2 วินาทีก่อนกลับไป Main Menu
        gameObject.SetActive(false); // ซ่อนผู้เล่นแทนการทำลาย
    }

    void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // โหลดฉาก Main Menu
    }
}

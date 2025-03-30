using UnityEngine;

public class Coin : MonoBehaviour
{
    public CoinCollectTask coinCollectTask;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            coinCollectTask.CoinCollected();
            gameObject.SetActive(false);
        }
    }
}
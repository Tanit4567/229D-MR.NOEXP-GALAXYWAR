using UnityEngine;



    public class CoinCollectTask : MonoBehaviour
    {
        public int numCoinsToCollect = 1;
        public bool allCoinsCollected = false;

        private int numCoinsCollected = 0;

        public void CoinCollected()
        {
            numCoinsCollected++;

            if (numCoinsCollected >= numCoinsToCollect)
            {
                allCoinsCollected = true;
            }
        }
    }

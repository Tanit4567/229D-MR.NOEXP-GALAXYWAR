using TMPro;
using UnityEngine;

public class MasterInfo : MonoBehaviour
{
    public static int Enegy = 0;
    [SerializeField] GameObject coinDisplay;
    
    
    void Update()
    {
        coinDisplay.GetComponent<TMP_Text>().text = "COINS " + Enegy;
    }
}

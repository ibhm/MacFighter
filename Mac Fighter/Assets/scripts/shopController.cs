using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shopController : MonoBehaviour
{
    int balance;
    public Text balanceText;
    public Button TextbookA;
    public Button TextbookB;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        balance = player.getbalance();
        balanceText.text = "Balance: $" + balance.ToString();       
        TextbookA.interactable = balance>=50;
        TextbookB.interactable = balance>=50;
    }
}

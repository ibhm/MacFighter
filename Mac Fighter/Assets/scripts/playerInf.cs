using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerInf : MonoBehaviour
{
    static int HP = player.getHP();
    static int ATK = player.getATK();
    static int balance = player.getbalance();

    public Text HPText;
    public Text ATKText;
    public Text balanceText;

    public Button battle;

    void Start()
    {
        HP = player.getHP();
        ATK = player.getATK();
        balance = player.getbalance();

        HPText.text = "HP: " + HP.ToString();
        ATKText.text = "ATK: " + ATK.ToString();
        balanceText.text = "balance: " + balance.ToString();

        Button btn = battle.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("battlescene");
        Debug.Log("enter battle");
    }


    internal static int getHP()
    {
        return HP;
    }

    internal static void setHP(int h)
    {
        HP = h;
    }

    internal static int getATK()
    {
        return ATK;
    }
    internal static void setATK(int a)
    {
        ATK = a;
    }

    internal static int getbalance()
    {
        return balance;
    }
    internal static void setbalance(int b)
    {
        balance = b;
    }

    internal static void updatebalance(int b)
    {
        player.setbalance(b);
    }
}

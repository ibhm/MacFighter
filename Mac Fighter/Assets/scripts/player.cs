using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player: MonoBehaviour
{
    static int HP = 100;
    static int ATK = 10;
    static int balance = 0;


    void Start()
    {

    }


    internal static int getHP()
    {
        return HP;
    }

    internal static void setHP(int h)
    {
        HP = h;
    }

    public void addHP(int h)
    {
        HP += h;
    }

    internal static int getATK()
    {
        return ATK;
    }
    internal static void setATK(int a)
    {
        ATK = a;
    }

    public void addATK(int a)
    {
        ATK += a;
    }

    internal static int getbalance()
    {
        return balance;
    }
    internal static void setbalance(int b)
    {
        balance = b;
    }

    public void addBal(int b)
    {
        balance += b;
    }
}

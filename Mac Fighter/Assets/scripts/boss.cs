using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class boss : MonoBehaviour
{
    private string name;
    private int HP;
    private int ATK;
    private int reward;


    public boss (string n, int h, int a, int r)
    {
        name = n;
        HP = h;
        ATK = a;
        reward = r;
    }

    public string getName()
    {
        return name;
    }
    public void setName(string n)
    {
        name = n;
    }

    public int getHP()
    {
        return HP;
    }

    public void setHP(int h)
    {
        HP = h;
    }

    public int getATK()
    {
        return ATK;
    }
    public void setATK(int a)
    {
        ATK = a;
    }

    public int getReward()
    {
        return reward;
    }
    public void setReward(int r)
    {
        reward = r;
    }
}

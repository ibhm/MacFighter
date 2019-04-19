using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bossInf : MonoBehaviour
{
    private boss Boss = boss_list.getBoss(1);

    static string name;
    static int HP;
    static int ATK;
    static int reward;

    public Text nameText;
    public Text HPText;
    public Text ATKText;
    public Text rewardText;


    void Start()
    {
        name = Boss.getName();
        HP = Boss.getHP();
        ATK = Boss.getATK();
        reward = Boss.getReward();

        nameText.text = name.ToString();
        HPText.text = "HP: " + HP.ToString();
        ATKText.text = "ATK: " + ATK.ToString();
        rewardText.text = "reward: " + reward.ToString();


    }

    internal static string getName()
    {
        return name;
    }

    internal static void setName(string n)
    {
        name = n;
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

    internal static int getReward()
    {
        return reward;
    }
    internal static void setReward(int r)
    {
        reward = r;
    }

}


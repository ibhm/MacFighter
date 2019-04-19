using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_list : MonoBehaviour
{
    static List<boss> bossList = new List<boss>()
    {
        new boss("unknown", 100, 20, 20),
        new boss("Dr. Jacques Carette", 90, 15, 10)
    };

    internal static boss getBoss(int i)
    {
        return bossList[i];
    }
}

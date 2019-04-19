using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wood_atk : MonoBehaviour
{
    private WoodDoll_Mgr m_parent;
    private int damage = bossInf.getATK();
    void Start()
    {
        m_parent = this.transform.root.transform.GetComponent<WoodDoll_Mgr>();
    }
    private void OnTriggerEnter2D(Collider2D cld)
    {
        if(cld.name == "R_Weapon")
        {
            m_parent.Attack();
        }
        if(cld.name == "BURLY-MAN_1_swordsman")
        {
            cld.GetComponent<CharacterController_2D>().hitted(damage);
            Debug.Log("hit::" + cld.name);
        }

    }
}

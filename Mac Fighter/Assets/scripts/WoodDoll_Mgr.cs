using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class WoodDoll_Mgr : MonoBehaviour {

    private int HP = bossInf.getHP();
    private int BOSSHP = bossInf.getHP();
    private int move = 0;
    private int stay = 200;

    public Text countText;
    public SpriteRenderer[] m_SpriteGroup;
    private int p = 1;
    public float Speed = 40;
    public SimpleHealthBar Health;

    Animator m_Animator;
    Rigidbody2D m_rigidbody;
    Transform m_tran;

    // Use this for initialization
    void Start () {
        m_Animator = this.transform.GetComponent<Animator>();
        m_rigidbody = this.GetComponent<Rigidbody2D>();
        m_tran = this.transform;
        m_SpriteGroup = this.transform.GetComponentsInChildren<SpriteRenderer>(true);
        countText.text = HP.ToString();
        spriteOrder_Controller();

    }


    void Update()
    {
    
        if (move == 0)
        {
            if (stay > 0) { stay--; }
            else
            {
                stay = UnityEngine.Random.Range(30, 150);
                move = UnityEngine.Random.Range(-150, 50); }
        }

        //if (m_Animator.GetCurrentAnimatorStateInfo(0).IsName("atk") || m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Hit"))
        //    return;
        

        if (m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Hit"))
        {
            m_rigidbody.AddForce(Vector2.right * 15000);
            m_Animator.SetFloat("Speed", 0);
            move = 0;
        }
        else if (m_Animator.GetCurrentAnimatorStateInfo(0).IsName("atk"))
        {
            m_Animator.SetFloat("Speed", 0);
            move = 0;
        }


        Move_Fuc();
        if (move == 0)
        {
            m_rigidbody.velocity = new Vector3(0, 0, 0);
            m_Animator.SetFloat("Speed", 0);
        }
        else
        {
            m_Animator.SetFloat("Speed", 1);
        }
        
    }

    private float Update_Tic = 0;
    private float Update_Time = 0.1f;
    public int sortingOrder = 0;
    public int sortingOrderOrigine = 0;
    void spriteOrder_Controller()
    {

        Update_Tic += Time.deltaTime;

        if (Update_Tic > 0.1f)
        {
            sortingOrder = Mathf.RoundToInt(this.transform.position.y * 100);
            //Debug.Log("y::" + this.transform.position.y);
            //  Debug.Log("sortingOrder::" + sortingOrder);
            for (int i = 0; i < m_SpriteGroup.Length; i++)
            {

                m_SpriteGroup[i].sortingOrder = sortingOrderOrigine - sortingOrder;

            }

            Update_Tic = 0;
        }



    }

    public void  Sword_Hitted(int damage)
    {
        //int rnd = UnityEngine.Random.Range(0, 2);
        //if (rnd == 1)
        //{
        //    m_Animator.SetTrigger("atk");
        //}
        //else
        //{
        //    m_Animator.Play("Hit");
        //}

        m_Animator.Play("Hit");
        HP = HP - damage;
        countText.text = HP.ToString();
        Health.UpdateBar(HP, BOSSHP);

        if (HP <= 0)
        {
            int h = playerInf.getbalance();
            int r = bossInf.getReward();
            playerInf.updatebalance(h + r);
            SceneManager.LoadScene("winprompt");
        }
    }

    void Move_Fuc()
    {
        if (move < 0)
        {
            m_rigidbody.AddForce(Vector2.left * Speed);
            if (B_FacingRight)
                Filp();
            move++;

        }
        else if (move > 0)
        {
            m_rigidbody.AddForce(Vector2.right * Speed);
            if (!B_FacingRight)
                Filp();
            move--;
        }
    }

    public void Attack()
    {
        m_Animator.SetTrigger("atk");
    }

    bool B_FacingRight = false;

    void Filp()
    {
        B_FacingRight = !B_FacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;

        m_tran.localScale = theScale;
    }


}

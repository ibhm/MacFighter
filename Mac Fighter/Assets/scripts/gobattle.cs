using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gobattle : MonoBehaviour
{
    public void startbattle()
    {
        SceneManager.LoadScene("battlescene");
    }
}

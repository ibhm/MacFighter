﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gohome : MonoBehaviour
{
    public void home()
    {
        SceneManager.LoadScene("overworld");
    }
}

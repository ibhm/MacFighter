using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class confirm_page : MonoBehaviour
{

    public Button confrim;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = confrim.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("overworld");
        Debug.Log("back to map");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

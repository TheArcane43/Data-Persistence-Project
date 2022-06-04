using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    private InputField nameTextBox;

    // Start is called before the first frame update
    void Start()
    {
        nameTextBox = GameObject.Find("InputPlayerName").GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneFlowManager.instance.currentName = nameTextBox.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        
    }
}

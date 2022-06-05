using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    private TMP_InputField nameTextBox;

    // Start is called before the first frame update
    void Start()
    {
        nameTextBox = GameObject.Find("InputPlayerName").GetComponent<TMP_InputField>();
        nameTextBox.text = SceneFlowManager.instance.currentName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Move to next scene
    public void StartNew()
    {
        SceneFlowManager.instance.currentName = nameTextBox.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        
    }
}

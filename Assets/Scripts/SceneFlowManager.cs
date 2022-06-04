using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneFlowManager : MonoBehaviour
{
    public static SceneFlowManager instance;
    public string currentName;
    public int currentHighScore;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);

    }

}

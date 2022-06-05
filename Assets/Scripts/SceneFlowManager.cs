using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SceneFlowManager : MonoBehaviour
{
    public static SceneFlowManager instance;
    public string currentName;

    public string bestName;
    public int bestScore;

    public Text bestScoreField;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighScore();
        bestScoreField.text = $"Best Score: {instance.bestName} : {instance.bestScore}";
    }

    [System.Serializable]
    class SaveData
    {
        public string name;
        public int score;
    }

    public void SaveHighScore()
    {
        instance.bestName = bestName;
        instance.bestScore = bestScore;

        SaveData data = new()
        {
            name = bestName,
            score = bestScore
        };
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestName = data.name;
            bestScore = data.score;
        }
    }

}

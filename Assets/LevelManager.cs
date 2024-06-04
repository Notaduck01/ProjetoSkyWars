using UnityEngine;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    private Dictionary<int, bool> levelCompletion = new Dictionary<int, bool>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetLevelCompleted(int levelNumber)
    {
        levelCompletion[levelNumber] = true;
    }

    public bool IsLevelCompleted(int levelNumber)
    {
        return levelCompletion.ContainsKey(levelNumber) && levelCompletion[levelNumber];
    }
}
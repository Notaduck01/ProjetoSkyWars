using UnityEngine;
using UnityEngine.UI;

public class LevelButtonManager : MonoBehaviour
{
    public GameObject[] levelObjects;

    void Start()
    {
        for (int i = 0; i < levelObjects.Length; i++)
        {
            int levelNumber = i + 1;
            Button button = levelObjects[i].GetComponent<Button>();
            button.interactable = LevelManager.instance.IsLevelCompleted(levelNumber - 1);
        }
    }
}
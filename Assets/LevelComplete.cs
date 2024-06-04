using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public int levelNumber;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LevelManager.instance.SetLevelCompleted(levelNumber);
        }
    }
}
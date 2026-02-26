using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}

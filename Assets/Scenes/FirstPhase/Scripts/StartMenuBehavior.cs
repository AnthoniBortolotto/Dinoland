using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuBehavior : MonoBehaviour
{
    public GameObject player;
    public GameObject menuUI;
    private bool gameStarted = false;

    private void Update()
    {
        if (!gameStarted && Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }
    }

    private void StartGame()
    {
        gameStarted = true;
        player.SetActive(true);
        menuUI.SetActive(false);
    }
}

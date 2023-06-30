using UnityEngine.SceneManagement;
using UnityEngine;

public class WinMenuBehavior : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}

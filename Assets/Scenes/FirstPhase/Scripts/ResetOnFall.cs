using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetOnFall : MonoBehaviour
{
    public float fallThreshold = -10f; // Limite de queda

    private void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            ResetScene();
        }
    }

    private void ResetScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}

using UnityEngine;

public class PrincessBehavior : MonoBehaviour
{
    public GameObject player;
    public GameObject menuUI;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.SetActive(false);
            menuUI.SetActive(true);
        }
    }
}

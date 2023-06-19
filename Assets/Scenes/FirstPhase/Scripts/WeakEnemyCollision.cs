using UnityEngine;
using UnityEngine.SceneManagement;

public class WeakEnemyCollision : MonoBehaviour
{
    public float collisionOffset = 0.5f; // Ajuste esse valor para definir a área de colisão no topo do inimigo

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Verifica se a colisão ocorreu por cima do inimigo
            Vector2 contactPoint = collision.GetContact(0).point;
            float enemyTop = transform.position.y + collisionOffset;


            if (contactPoint.y > enemyTop)
            {
                // O jogador pulou em cima do inimigo, faz ele desaparecer
                gameObject.SetActive(false);
            }
            else
            {
                // O jogador colidiu com o inimigo de outra forma, reinicia a cena
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // O jogador colidiu com o inimigo de outra forma, reinicia a cena
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

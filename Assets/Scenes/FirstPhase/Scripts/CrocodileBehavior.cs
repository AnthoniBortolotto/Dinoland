using UnityEngine;

public class CrocodileBehavior : MonoBehaviour
{
    public float speed = 5f;
    public float distance = 5f;

    private bool movingRight = true;
    private float startPosition;
    private Vector3 originalScale;

    private void Start()
    {
        startPosition = transform.position.x;
        originalScale = transform.localScale;
    }

    private void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (transform.position.x >= startPosition + distance)
            {
                movingRight = false;
                FlipSprite();
            }
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= startPosition - distance)
            {
                movingRight = true;
                FlipSprite();
            }
        }
    }

    private void FlipSprite()
    {
        Vector3 newScale = transform.localScale;
        newScale.x *= -1; // Inverte a escala no eixo X
        transform.localScale = newScale;
    }
}

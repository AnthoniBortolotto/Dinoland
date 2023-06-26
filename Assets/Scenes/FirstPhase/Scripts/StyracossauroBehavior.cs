using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StyracossauroBehavior : MonoBehaviour
{
    public float speed = 5f;
    public Transform player;
    public float activationDistance = 10f;
    public float fallThreshold = -10f; // Limite de queda
    private bool isActivated = false;

    private void Update()
    {
        if (isActivated)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (player.position.x >= transform.position.x - activationDistance)
        {
            isActivated = true;
        }

        if (transform.position.y < fallThreshold)
        {
            DeleteObject();
        }
    }
    public void DeleteObject()
    {
        Destroy(gameObject, 0);
    }
}

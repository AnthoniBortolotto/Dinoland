using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PterodactilBehavior : MonoBehaviour
{
   public float speed = 5f;
    public Transform player;
    public float activationDistance = 10f;

    private bool isActivated = false;

    private void Update()
    {
        Debug.Log(player.position.x);
        if (isActivated)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (player.position.x >= transform.position.x - activationDistance)
        {
            isActivated = true;
        }
    }

}

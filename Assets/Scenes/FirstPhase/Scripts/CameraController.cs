using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraController : MonoBehaviour
{
   [SerializeField]
    private Transform target;
    private void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y + 2, transform.position.z);
    }
}

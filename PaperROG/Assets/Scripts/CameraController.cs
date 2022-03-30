using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]private Transform player;
    [SerializeField]private int speed;
    private Vector3 temp;

    private void LateUpdate() 
    {
        temp = player.position;
        transform.position = Vector3.Lerp(transform.position, temp, speed * Time.deltaTime );
    }
}
    
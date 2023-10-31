using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    [SerializeField] private float smoothSpeed = 10f;
    public Vector3 offset;
    // Update is called once per frame
    public void FixedUpdate()
    {
        Vector3 cameraPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, cameraPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
        transform.LookAt(player);
    }
}
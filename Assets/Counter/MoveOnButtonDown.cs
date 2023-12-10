using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnButtonDown : MonoBehaviour
{
    [SerializeField] private float horizontalInput;
    [SerializeField] private float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * horizontalInput);
    }
}

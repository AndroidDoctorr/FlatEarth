using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHead : MonoBehaviour
{
    private Transform _head;
    private void Start()
    {
        _head = FindObjectOfType<Camera>().transform;
    }
    private void Update()
    {

        transform.LookAt(_head);
    }
}

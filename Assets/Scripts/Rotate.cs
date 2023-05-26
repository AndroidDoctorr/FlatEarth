using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float Speed = 0.025f;
    private void Update()
    {
        transform.Rotate(0, Speed, 0);
    }
}

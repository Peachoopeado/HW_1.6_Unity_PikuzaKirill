using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public Vector3 force;
    public Rigidbody rb;

    private void Start()
    {
        rb.AddForce(force, ForceMode.Impulse);
    }
}

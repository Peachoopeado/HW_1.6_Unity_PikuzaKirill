using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private void Update()
    {
        Vector3 velocity = new Vector3(0, 0, -1);
        Vector3 motion = velocity * Time.deltaTime;
        transform.position += motion;
    }
}

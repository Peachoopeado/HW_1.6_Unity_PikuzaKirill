using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstTrigger : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Object has left burst area");
    }
}

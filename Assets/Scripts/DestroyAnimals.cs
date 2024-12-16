using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DestroyAnimals : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("animal"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}

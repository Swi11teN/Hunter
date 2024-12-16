using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{

    private float speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        DestroyObjects();
    }

    private void DestroyObjects()
    {
        if (transform.position.z <= 107 || transform.position.z >= 147)
        {
            Destroy(gameObject);
        }

        if (transform.position.x <= -40 || transform.position.x >= 40)
        {
            Destroy(gameObject);
        }
    }
}

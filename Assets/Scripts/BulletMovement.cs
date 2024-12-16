using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    private float speed = 30f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        Debug.Log(transform.position.z);
        DestroyObject();
    }
    private void DestroyObject()
    {
        if (transform.position.z <= 107)
        {
            Debug.Log(transform.position.z);
            Destroy(gameObject);
        }

    }

}
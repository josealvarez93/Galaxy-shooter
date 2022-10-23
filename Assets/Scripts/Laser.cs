using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 10.0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        if (transform.position.y > 6)
        {
            Destroy(this.gameObject);
        }
    }
}

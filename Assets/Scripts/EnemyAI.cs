using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
    public float speed = 5.0f;
    private int limiteIzquierdo = -10;
    private int limiteDerecho = 10;    
    private int limiteSuperior = 5;    
    private int limiteInferior = -5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void movement()
    {
        if(transform.position.x < limiteIzquierdo)
        {
            transform.position = new Vector3(Random.Range(limiteSuperior, limiteInferior), limiteIzquierdo, 0);
        }
        if (transform.position.x >= limiteDerecho)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField]
    private Vector2 velocidad; 

    private Vector2 offset;
    private Material material; 

    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;    
    }


    void Update()
    {
        offset = velocidad * Time.deltaTime; 
        material.mainTextureOffset += offset;
    }
}

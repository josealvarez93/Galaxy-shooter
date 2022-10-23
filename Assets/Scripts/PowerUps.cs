using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    [SerializeField] public float speed = 3.0f;
    public int powerupID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("colision con: " + other.name);
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if(powerupID == 1)
            {
                player.TripleShotPowerupOn();
            }
            else
            {
                player.SpeedBoostPowerupOn();
            }

        }
        Destroy(this.gameObject);
    }

}

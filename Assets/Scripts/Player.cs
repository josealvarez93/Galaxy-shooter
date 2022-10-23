using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float speed=5.0f;
    public GameObject laserPrefab;
    public float canFire = 0.0f;
    [SerializeField] public float fireRate = 0.3f;
    public bool canTripleshoot = false;
    public bool canSpeedBoost = false;
    void Start()
    {
        transform.position=new Vector3(0, -2, 0);
    }

    void Update()
    {
        Move();
        if(canSpeedBoost == true)
        {
            speed = 10.0f;
        }
        else
        {
            speed = 5.0f;
        }

    }
    void Move()
    {
        float mHorizontal = Input.GetAxis("Horizontal")* speed * Time.deltaTime;
        float mVertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float movX = Mathf.Clamp(transform.position.x + mHorizontal, -13, 13);
        float movY = Mathf.Clamp(transform.position.y + mVertical, -5, 5);
        float movZ = 0;
        transform.position = new Vector3(movX, movY, movZ);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time>canFire)
            {
                if (canTripleshoot == true)
                {
                    Instantiate(laserPrefab, transform.position + new Vector3(0, 1.081242f, 0), Quaternion.identity);
                    Instantiate(laserPrefab, transform.position + new Vector3(-0.460716f, 0.2384388f, 0), Quaternion.identity);
                    Instantiate(laserPrefab, transform.position + new Vector3(0.4832234f, 0.2384388f, 0), Quaternion.identity);

                }
                else
                {
                    Instantiate(laserPrefab, transform.position + new Vector3(0, 1.045662f, 0), Quaternion.identity);
                }
                    canFire = Time.time + fireRate;
            }

        }
    }
    public void TripleShotPowerupOn()
    {
        canTripleshoot = true;
        StartCoroutine(TripleShotPowerDownRoutine());
    }
    public void SpeedBoostPowerupOn()
    {
        canSpeedBoost = true;
        StartCoroutine(SpeedBoostPowerDownRoutine());
    }


    public IEnumerator TripleShotPowerDownRoutine()
    {
        yield return new WaitForSeconds (5.0f);
        canTripleshoot = false;
    }
    public IEnumerator SpeedBoostPowerDownRoutine()
    {
        yield return new WaitForSeconds(10.0f);
        canSpeedBoost = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    
    public GameObject bullet;
    public Transform bulletStartPosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            Debug.Log("Basıldı");
            transform.position += Vector3.left * 5;
        }
    }
    
    //Called from animation
    public void Fire()
    {
        GameObject spawnedObje = Instantiate(bullet);
        spawnedObje.transform.position = bulletStartPosition.position;
    }
}

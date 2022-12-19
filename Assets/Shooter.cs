using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    
    public GameObject bullet;

    public Transform bulletStartPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            Debug.Log("Basıldı");
            transform.position += Vector3.left * 5;
        }
    }

    public void Fire()
    {
        GameObject spawnedObje = Instantiate(bullet);
        spawnedObje.transform.position = bulletStartPosition.position;
    }

   
}

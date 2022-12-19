using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float bulletSpeed;
    
    void Update()
    {
        Vector3 yerDegistirmeMiktari = new Vector3(0, 0, bulletSpeed * Time.deltaTime);
        transform.position += yerDegistirmeMiktari;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        var bullet = new Enemy();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 yerDegistirmeMiktari = new Vector3(0, 0, bulletSpeed * Time.deltaTime);
        transform.position += yerDegistirmeMiktari;
    }
}

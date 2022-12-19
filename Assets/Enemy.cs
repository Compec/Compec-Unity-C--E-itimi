using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health;
    public Animator Animator;

    public Enemy[] childs;
    
    // Start is called before the first frame update
    void Start()
    {
        Animator.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if(!collision.gameObject.CompareTag("yuzey"))
            Die();
    }

    public void Die()
    {
        Debug.Log("Die fonksiyonuna girildi");
        
        
        foreach (Enemy child in childs)
        {
            child.Die();
        }
        
        Debug.Log("Foreach çıkıldı");
        
        
        Animator.speed = 1;
    }

}

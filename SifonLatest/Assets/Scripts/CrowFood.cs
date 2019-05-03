using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowFood : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0.2f);
        }
    }
}

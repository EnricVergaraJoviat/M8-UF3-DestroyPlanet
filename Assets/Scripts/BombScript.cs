using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    private GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
        
        if (gm != null)
        {
            Debug.LogError("No hi ha cap gameObject amb tag GameManahger");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Si han passat 4 segons --> Destroy this gameObject & damage using GameManeger:
        
            
    }
    
    //Si l'usuari fa click sobre la bomba=>
    // Destroy
    
    
}

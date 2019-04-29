using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyLevelManager : MonoBehaviour
{

    public GameObject row1;
    private float time;
    private float timer = 4f; 
    
    
    void Start()
    {
        row1.SetActive(false);
    }

    void Update()
    {
        row1.SetActive(true);

        time += Time.deltaTime;
        if (time >= timer)
        {
            row1.SetActive(true);
            time = 0; 
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawShapes : MonoBehaviour
{

    public bool drawRect;
    public bool dance; 
    public float yTopLeftPos; 
    public float xTopRightPos; 
    public float yBottomRightPos; 
    public float xBottomRightPos;

    public Transform[] targets = new Transform[4];
    public float speed;
    
    private float timer;
    private SpriteRenderer SR; 

    
    public float secondX;
    public float secondy;
    public float secondz;

    void Start()
    {

        SR = GetComponent<SpriteRenderer>();

    }
    void Update()
    {

        //VERSION ONE 

        if (dance)
        {
            for (int i = 0; i < targets.Length; i++)
            {
                transform.position = Vector3.MoveTowards(transform.position, targets[i].position, speed);
                targets[i].position *= -1.0f;


            }
        }
            timer += Time.deltaTime;
            if (timer >= 2f)

            {
                float alpha = 1;
                SR.color = new Color(1, 1, 1, alpha - 0.1f * Time.time);
            }
            /* 
            //at the start, telling it to move up 
            transform.Translate(0, 1 * Time.time, 0);
            
            //This kind of creates a cool movement that I'd like to use in some way, a zig zag forward movement. 
            //transform.position = new Vector3(0, 1, 0) * Time.time; 
            if (transform.position.y >= yTopLeftPos)
            {
                //crazy movement 1 
                //transform.position = new Vector3(1 * Time.time * Time.time * Time.time , 0, 0);
                //transform.Translate(0, 0, 0);
                //transform.Translate(1 * Time.time, 0, 0); 

                transform.localPosition += transform.right; 
            }
            */

            /* 
            
            transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);

            if (transform.localPosition.y > 5f)
            {
                transform.position = new Vector3(0, 0, 0);
                transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);
            }
            */

        if (drawRect)
        {
            
            Vector3 firstPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Vector3 secondPosition = new Vector3(1, 0, 0);
            
            while(transform.position.x < secondX)
            {
                transform.position = new Vector3(transform.position.x + 0.001f, transform.position.y, transform.position.z);
            }

        }
        

    }
    
    
}

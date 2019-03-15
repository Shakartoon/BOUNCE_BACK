 using System.Collections;
 using UnityEngine;
 
 public class pulse : MonoBehaviour
 {
     private TemporarySMObjects SMScript; 
     // Grow parameters
     public float approachSpeed = 0.02f;
     public float growthBound = 2f;
     public float shrinkBound = 0.5f;
     private float currentRatio = 1;
 
     // The text object we're trying to manipulate
     private float originalFontSize;
 
     // And something to do the manipulating
     private Coroutine routine;
     private bool keepGoing = true;
     private bool closeEnough = false;

     private SpriteRenderer SR;
     private float timer; 
 
     // Attach the coroutine
     void Awake ()
     {
         SR = GetComponent<SpriteRenderer>(); 
         // Find the text  element we want to use
 
         // Then start the routine
        
         routine = StartCoroutine(Pulse());
         
     }

     void Update()
     {
         timer += Time.deltaTime; 

     }
     
     IEnumerator Pulse()
     {
         
        // Run this indefinitely
             while (keepGoing)
             {
                 // Get bigger for a few seconds
                 while (currentRatio != growthBound)
                 {
                     // Determine the new ratio to use
                     currentRatio = Mathf.MoveTowards(currentRatio, growthBound, approachSpeed);

                     // Update our text element

                     yield return new WaitForEndOfFrame();
                 }

                 // Shrink for a few seconds
                 while (this.currentRatio != this.shrinkBound)
                 {
                     // Determine the new ratio to use
                     currentRatio = Mathf.MoveTowards(currentRatio, shrinkBound, approachSpeed);

                     // Update our text element
                     SR.transform.localScale = Vector3.one * currentRatio;
                     //SR = "Shrinking!";

                     //yield return new WaitForEndOfFrame();
                     yield return null;
                 }
             }
     }
 }
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapesandPatterns : MonoBehaviour 
{ 
public GameObject block1; 
public int worldWidth  = 5;
public int worldHeight  = 5;
public float spawnSpeed = 2;
 
void  Start () {
StartCoroutine(CreateWorld());
}
 
IEnumerator CreateWorld () {
    for(int x = 0; x < worldWidth; x++) {
        yield return new WaitForSeconds(spawnSpeed);
             
    for(int z = 0; z < worldHeight; z++) {                
        yield return new WaitForSeconds(spawnSpeed);
 
        GameObject block = Instantiate(block1, Vector3.zero, block1.transform.rotation);
        block.transform.parent = transform;
        block.transform.localPosition = new Vector3(x, z, 0);
            }
        }
    }
}

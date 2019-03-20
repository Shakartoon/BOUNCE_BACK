using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class DollyZoom : MonoBehaviour
{

    [SerializeField] private Transform target; 
    [SerializeField] private float dollySpeed = 5.0f; 
    private Camera camera;

    private void Awake()
    {
        Initialize(); 
        
    }

    private void Update()
    {
        
        transform.Translate(Input.GetAxis("Vertical") * Vector3.forward * Time.deltaTime * dollySpeed);
        
    }
    private void Initialize()
    {
        camera = GetComponent<Camera>(); 
        Debug.Assert(camera != null);
    }
}

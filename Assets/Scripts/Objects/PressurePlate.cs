using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{

    public float minimumMass;
    public GameObject[] allowedObjects;
    private GameObject ColliderObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (allowedObjects.ToString().Contains(other.gameObject.ToString())){
            //start animation
            transform.parent.GetChild(transform.GetSiblingIndex()).gameObject.SetActive(true);
            
        }
    }

    private void OnCollisionExit(Collision other)
    {
        //start animation
        transform.parent.GetChild(transform.GetSiblingIndex()).gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FStopCamera : MonoBehaviour
{
    private GameObject clipboard;
    private Vector3 clipboardLocation = new Vector3(-10, -10, -10);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, Vector3.forward, out RaycastHit hitInfo, 10)) {
            if(hitInfo.transform.gameObject.CompareTag("FSTOP_Copiable")){
                Debug.Log("This object can be copied:" + hitInfo.transform.gameObject.name);
                if(Input.GetButtonDown("Fire1")) {
                    clipboard = hitInfo.transform.gameObject;
                    clipboard.transform.Translate(clipboardLocation, Space.World);
                }
            }else {
                if (Input.GetButtonDown("Fire2")){
                    clipboard.transform.Translate(hitInfo.transform.position, Space.World);
                }
            }
        }    
    }
}

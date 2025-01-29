using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
//using UnityEngine.XR.Interaction.Toolkit.Interactables;
//using UnityEngine.XR.Interaction.Toolkit.Transformers;

public class SnapInPlace : MonoBehaviour
{
    public Vector3 snapToVector;
    public Quaternion snapToRotation;

    //private XRGrabInteractable XRInteractableScript;
    //private XRGeneralGrabTransformer XRGenGrabTransformerScript;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GrabObject"))
        {
            //XRInteractableScript = other.gameObject.GetComponent<XRGrabInteractable>();
            //XRGenGrabTransformerScript = other.gameObject.GetComponent<XRGeneralGrabTransformer>();

            Rigidbody rb;

            rb = other.gameObject.GetComponent<Rigidbody>();
            

            //XRGenGrabTransformerScript.enabled = false;
            //XRInteractableScript.enabled = false;
            rb.useGravity = false;
            //Destroy(rb);
            other.gameObject.transform.SetPositionAndRotation(snapToVector, snapToRotation);
        }

    }
}

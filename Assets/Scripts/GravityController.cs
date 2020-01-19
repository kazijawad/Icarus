using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class GravityController : MonoBehaviour
{
    public float thrust = 100.0f;
    public Rigidbody rb;
    public Transform RightHand;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void EnableGravity()
    {
        Debug.Log("gravity enabled");
        rb.useGravity = true;
        rb.isKinematic = false;
        rb.transform.SetParent(RightHand);
    }

    public void StopGrab()
    {
        Debug.Log("thrown");
        rb.transform.SetParent(null);
        rb.isKinematic = false;
        rb.AddForce(0, 0, thrust, ForceMode.Impulse);
    }
}

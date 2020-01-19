using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalDetection : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Portal") {
            Debug.LogError("Works");
        }
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            print("space key was pressed");
        }
    }
}

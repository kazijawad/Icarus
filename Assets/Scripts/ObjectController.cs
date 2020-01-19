using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public Transform target;
    public List<GameObject> objects;

    public void FeedObjects() {
        while (objects.Count > 0) {
            GameObject activeObject = objects[0];
            activeObject.SetActive(true);
            objects[0].transform.SetParent(target);
            objects.RemoveAt(0);
            return;
        }
    }
}

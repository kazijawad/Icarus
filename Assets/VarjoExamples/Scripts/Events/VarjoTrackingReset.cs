// Copyright 2019 Varjo Technologies Oy. All rights reserved.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Varjo;

namespace VarjoExample
{
    /// <summary>
    /// Example to reset tracking origin to where user's head is.
    /// </summary>
    public class VarjoTrackingReset : MonoBehaviour
    {
        [Header("Keyboard key to call tracking reset")]
        public KeyCode trackingResetKey = KeyCode.R;

        public GameObject rig;
        public Transform nextWorld;

        [Header("Should we reset the position")]
        public bool resetPosition = true;

        [Header("How should we reset the rotation")]
        [Header("YAW keeps horizon stable and is recommended in most cases")]
        [Header("ALL is for special cases where content needs to be aling with the headset completely")]
        public VarjoPlugin.ResetRotation resetRotation = VarjoPlugin.ResetRotation.YAW;

        void Update()
        {
            if (Input.GetKeyDown(trackingResetKey))
            {
                rig.transform.SetParent(nextWorld);
                rig.transform.position = new Vector3((float)-0.56, (float)-0.37, (float)-0.11);

                //VarjoPlugin.ResetPose(resetPosition, resetRotation);
            }
        }
    }
}

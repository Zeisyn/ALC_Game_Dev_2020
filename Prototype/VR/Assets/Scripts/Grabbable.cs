using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Zenva.VR
{

        [RequireComponent(typeof(Collider))]
        [RequireComponent(typeof(Rigidbody))]   
    public class Grabbable : MonoBehaviour
    {
        public enum ReleaseAction { nothing, backToOrigin, throws }

        public bool facesForward;

        public ReleaseAction releaseAction;

        public UnityEvent onGrab;
        public UnityEvent onRelease;

        GrabController grabCtrl;
        Vector3 originalPosition;
        quaternion originalRotation;
        Transform originalParent;

        Rigidbody rb;

        bool isKinematic;

        Vector3 ctrlVelocity;
        Vector3 prevPosition;

        void Awake()
        {
            rb = GetComponent<Rigidbody>();
            isKinematic = rb.isKinematic;

            originalParent = transform.parent;
        }
       
    }
}
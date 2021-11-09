using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Zenva.VR
{
        [RequireComponent(typeof(Collider))]
        [RequireComponent(typeof(Rigidbody))] 
    public class GrabController : MonoBehaviour
    {
         Grabbable item;
        bool isGripping;
        public void Grip ()
        {
            isGripping = true;
        }

        public void Release ()
        {
            isGripping = false;
            //item.release();
            item = null;
        }

        void OnTriggerStay(Collider other)
        {
            if(!item && isGripping && other.GetComponent<Grabbable>())
            {
                item = other.GetComponent<Grabbable>();
                //item.grab(this);
            }
        } 
    }  
}

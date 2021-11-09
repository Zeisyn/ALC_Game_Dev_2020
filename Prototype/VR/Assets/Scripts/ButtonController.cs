using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using Zenva.VR;
using UnityEngine.Events;
using System;

namespace Zenva.VR
{
    public class ButtonController : MonoBehaviour
    {
        static readonly Dictionary<string, InputFeatureUsage<bool>> availableFeatures = new Dictionary<string, InputFeatureUsage<bool>> 
        {
            { "triggerButton", CommonUsages.triggerButton },
            {"gripButton", CommonUsages.gripButton },
            {"thumbrest", CommonUsages.thumbrest },
            {"primary2DAxisClick", CommonUsages.primary2DAxisClick},
            {"primary2DAxisTouch", CommonUsages.primary2DAxisTouch},
            {"menuButton", CommonUsages.menuButton},
            {"secondaryButton", CommonUsages.secondaryButton},
            {"secondaryTouch", CommonUsages.secondaryTouch},
            {"primaryButton", CommonUsages.primaryButton},
            {"primaryTouch", CommonUsages.primaryTouch}
        };
        public enum FeatureOptions
        {
            triggerButton,
            gripButton,
            thumbrest,
            primary2DAxisClick,
            primary2DAxisTouch,
            menuButton,
            secondaryButton,
            secondaryTouch,
            primaryButton,
            primaryTouch
        };
        public InputDeviceRole deviceRole;
        public FeatureOptions feature;
        public UnityEvent onPress;
        public UnityEvent onRelease;

        bool isPressed;
        List<InputDevice> devices;
        bool InputValue;
        InputFeatureUsage<bool> selectedFeature;
    
    void Awake ()
    {
        devices = new List<InputDevice>();
        string featureLabel = Enum.GetName(typeof(FeatureOptions), feature);

        availableFeatures.TryGetValue(featureLabel, out selectedFeature);

    }
    void Update ()
    {
        InputDevices.GetDevicesWithRole(deviceRole, devices);

        for (int i = 0; i < devices.Count; i++)
        {
            if(devices[i].TryGetFeatureValue(selectedFeature, out inputValue) && InputValue)
            {
                if(!isPressed)
                {
                    isPressed = true;
                    onPress.Invoke();
                }
            }
            else if(isPressed)
            {
                isPressed = false;
                onRelease.Invoke();
            }
        }
    }
    }
}
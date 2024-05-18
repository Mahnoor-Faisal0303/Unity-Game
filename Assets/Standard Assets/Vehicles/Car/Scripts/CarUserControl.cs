using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        private float gasInput = 0f; // Gas input value
        private bool isBrakePressed = false; // Track the state of the brake button
        private bool isBackwardPressed = false; // Track the state of the backward button

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }

        public void GasPressed()
        {
            isBrakePressed = false; // Ensure brake is released when gas is pressed
            gasInput = 1f; // Set gas input to move forward
        }

        public void GasReleased()
        {
            gasInput = 0f; // Release gas input
        }

        public void BrakePressed()
        {
            gasInput = 0f; // Stop the car immediately when brake is pressed
            isBrakePressed = true;
            isBackwardPressed = false; // Ensure backward is released when brake is pressed
        }

        public void BrakeReleased()
        {
            isBrakePressed = false;
        }

        public void BackwardPressed()
        {
            gasInput = -1f; // Set gas input to move backward
            isBrakePressed = true;
            isBackwardPressed = true;
        }

        public void BackwardReleased()
        {
            gasInput = 0f; // Release gas input
            isBackwardPressed = false;
        }

        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = SimpleInput.GetAxis("Horizontal");
          //  float v = SimpleInput.GetAxis("Vertical");
            float v = gasInput;
            float handbrake = isBrakePressed ? 1f : 0f; // Apply handbrake when brake is pressed

#if !MOBILE_INPUT         
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
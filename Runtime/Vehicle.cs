using System;
using UnityEngine;

namespace YanickSenn.Vehicles {
    [DisallowMultipleComponent]
    public class Vehicle : MonoBehaviour {
        
        private VehicleInterior[] _interiors;
        public VehicleInterior[] Interiors => _interiors;

        private void Awake() {
            _interiors = GetComponentsInChildren<VehicleInterior>();
        }
    }
}
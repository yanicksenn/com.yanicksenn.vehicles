using System;
using UnityEngine;

namespace YanickSenn.Vehicles {
    [DisallowMultipleComponent]
    public class VehicleInterior : MonoBehaviour {

        private void OnTriggerEnter(Collider other) {
            if (!other.gameObject.TryGetComponent<ObjectInVehicle>(out var oiv)) return;
            if (!oiv.enabled) return;
            other.transform.SetParent(transform);
        }

        private void OnTriggerExit(Collider other) {
            if (!other.gameObject.TryGetComponent<ObjectInVehicle>(out var oiv)) return;
            if (!oiv.enabled) return;
            other.transform.SetParent(null);
        }
    }
}
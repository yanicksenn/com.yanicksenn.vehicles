# Vehicles
This package contains basic logic around operating vehicles in Unity, specifically focusing on handling objects inside moving vehicles.

## Installation
1. Open "Package Manager"
2. Choose "Add package from git URL..."
3. Use the HTTPS URL of this repository:
```
https://github.com/yanicksenn/com.yanicksenn.vehicles.git#1.0.1
```
4. Click "Add"

## Features
This package provides a simple system for managing objects within vehicles:
* **Interior Parenting:** Automatically parents objects to the vehicle when they enter designated interior zones, ensuring they move correctly with the vehicle.
* **Marker System:** Use the `ObjectInVehicle` component to precisely control which objects are affected by vehicle physics and parenting.
* **Support for Multiple Interiors:** A single vehicle can have multiple interior zones (e.g., cabin, cargo hold).

## How to Use

### Setting up a Vehicle
1. Add the `Vehicle` component to your main vehicle GameObject.
2. Create child GameObjects for the interior zones and add the `VehicleInterior` component to them.
3. Ensure each interior zone has a `Collider` with `Is Trigger` enabled.

### Making Objects Interactable
To allow an object to be "captured" by a vehicle's interior:
1. Add the `ObjectInVehicle` component to the object.
2. Ensure the object has a `Rigidbody` and a `Collider` to interact with the interior triggers.

When the object enters a `VehicleInterior` trigger, it will automatically be parented to that interior. When it leaves, it will be unparented.

# Task: Vehicle Management System

## Requirements

1. **Abstract Class – Vehicle:**
   - Create an abstract class named `Vehicle` that represents the common features of all vehicles.
   - **Abstract Method:**  
     Declare an abstract method `Drive()` that will be implemented differently by derived classes.
   - **Readonly Field:**  
     Add a readonly field (or property) named `ManufactureDate` that is set in the constructor and cannot be modified later.
   - **Const Field:**  
     Define a constant, for example `DEFAULT_TAX_RATE`, which represents the default tax rate for all vehicles.
   - **Static Member:**  
     Add a static field (or property) that counts how many vehicles have been created. Increment this counter in the constructor of the `Vehicle` class.
   - **Static Utility Method:**  
     Include a static method `PrintVehicleCount()` that displays the total number of vehicles created.

2. **Interface – IVehicleActions:**
   - Define an interface named `IVehicleActions` that declares a method `Honk()`.
     - The `Honk()` method should print out a message indicating the vehicle’s honking behavior.

3. **Concrete Classes – Car and Truck:**
   - Create two classes, `Car` and `Truck`, that inherit from `Vehicle` and implement the `IVehicleActions` interface.
   - **Override Abstract Method:**  
     Provide concrete implementations for the `Drive()` method.  
     For example, the **Car** might print a message like "Car is driving swiftly," while the **Truck** might print "Truck is driving steadily."
   - **Implement Interface:**  
     In each class, implement the `Honk()` method to print out a message that is specific to that type of vehicle (for example, a Car might honk with "Beep beep!" while a Truck might honk with "HONK HONK!").

4. **Program Execution:**
   - In your `Main` method, create several instances of `Car` and `Truck`.
   - Call their respective methods (`Drive()` and `Honk()`), and use the static member/method to display the total vehicle count.
   - Use the `DEFAULT_TAX_RATE` constant in a calculation (for instance, calculating a tax amount based on a vehicle price).

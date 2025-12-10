# Exercise Tracking System 🏃🚴🏊

This project is a C# console application developed for the Week 07 Assignment (Foundation #3). It demonstrates the principles of **Inheritance** and **Polymorphism** by creating a system to track different types of fitness activities.

## 📖 Overview

The program tracks three specific types of exercises: **Running**, **Cycling**, and **Swimming**.
While each activity stores different internal data (e.g., Running stores distance, Swimming stores laps), they all share a common base class (`Activity`) and provide a unified way to retrieve Summary information, including:

* Distance (km)
* Speed (kph)
* Pace (min per km)

## 🛠️ Technical Concepts

This project was built to strictly follow Object-Oriented Programming (OOP) principles:

### 1. Inheritance
A base class named `Activity` contains shared attributes like the date and duration (`_minutes`). Derived classes (`Running`, `Cycling`, `Swimming`) inherit these attributes to avoid code duplication.

### 2. Polymorphism (Method Overriding)
The base class defines abstract methods for `GetDistance()`, `GetSpeed()`, and `GetPace()`.
* **Running:** Calculates speed and pace based on input distance.
* **Cycling:** Calculates distance and pace based on input speed.
* **Swimming:** Calculates distance based on laps (50m per lap) and derives speed/pace.

### 3. Encapsulation
All member variables (attributes) are `private` to ensure data integrity. They are accessed only through protected methods or public behaviors.

## 📂 Project Structure

* `Program.cs`: The entry point. Creates a list of activities and displays the summary.
* `Activity.cs`: The abstract base class defining the contract for all exercises.
* `Running.cs`: Derived class for running logic.
* `Cycling.cs`: Derived class for cycling logic.
* `Swimming.cs`: Derived class for swimming logic.

## 🚀 How to Run

1.  Ensure you have the **.NET 8.0 SDK** installed.
2.  Open your terminal in the project folder.
3.  Run the command:
    ```bash
    dotnet run
    ```

## 📄 Example Output

When running the program, the console displays a summary for each activity in the list:

```text
03 Nov 2022 Running (30 min)- Distance 4.8 km, Speed 9.6 kph, Pace: 6.3 min per km
03 Nov 2022 Cycling (30 min)- Distance 10.0 km, Speed 20.0 kph, Pace: 3.0 min per km
03 Nov 2022 Swimming (30 min)- Distance 1.0 km, Speed 2.0 kph, Pace: 30.0 min per km
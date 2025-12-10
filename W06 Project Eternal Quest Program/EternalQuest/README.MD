# Eternal Quest Program 🏆

This program is a goal-tracking application developed in C# as part of the Week 06 Project. It applies the principles of **Inheritance** and **Polymorphism** to "gamify" the process of setting and achieving personal goals.

## 📖 Overview

The Eternal Quest program allows users to create different types of goals, track their progress, and earn points for their achievements. The user's score and goal data can be saved to a file and loaded later, ensuring persistent progress.

## ✨ Features

* **Goal Management:** Create three distinct types of goals:
    * **Simple Goals:** Can be marked complete once for a specific point value (e.g., "Run a Marathon").
    * **Eternal Goals:** Can be recorded multiple times, awarding points each time without ever being "completed" (e.g., "Read Scriptures").
    * **Checklist Goals:** Must be performed a specific number of times. Awards points per attempt and a large bonus upon completion (e.g., "Attend the Temple 10 times").
* **Score Tracking:** Automatically calculates total points based on recorded events.
* **Persistence:** Save and Load goals and scores using text files.
* **Status Display:** View a formatted list of goals, showing completion status `[X]` or current progress `2/10`.

## 🚀 Exceeding Requirements (Creativity)

To exceed the core requirements of the project, I implemented a **Leveling System**:
* In addition to the raw score, the program calculates the user's current **Level**.
* The level increases automatically as the user earns more points (Level 1 starts at 0, Level 2 at 1000 points, etc.).
* This adds an extra layer of gamification to motivate the user to reach the next milestone.

## 🛠️ Technical Design

This project demonstrates strong Object-Oriented Programming (OOP) skills:

### 1. Inheritance
A base abstract class named `Goal` contains shared attributes (`_shortName`, `_description`, `_points`) and method signatures. Specific goal classes (`SimpleGoal`, `EternalGoal`, `ChecklistGoal`) inherit from this base class to reuse code.

### 2. Polymorphism
The program uses method overriding to handle behavior specific to each goal type.
* `RecordEvent()`: Behaves differently for each goal (e.g., marks Simple Goals as complete, increments counters for Checklist Goals).
* `GetStringRepresentation()`: Formats the data differently for saving to the file depending on the goal type.

### 3. Encapsulation
All member variables are `private` or `protected`, ensuring that data is modified only through appropriate methods.

## 💻 How to Run

1.  Ensure you have the **.NET 8.0 SDK** installed.
2.  Navigate to the project directory in your terminal.
3.  Run the application:
    ```bash
    dotnet run
    ```
4.  Follow the on-screen menu to create and track your goals.

---
Developed by **Amando Evangelista Santos Filho**
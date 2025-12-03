# 🚀 C# Interfaces – Complete Concepts with Inheritance & Polymorphism

### 📌 Description  
A clean and simple C# project demonstrating **Interfaces, Interface Inheritance, Multiple Interface Implementation, and Runtime Polymorphism**.  
This project helps beginners and students understand how interfaces work internally and how they differ from classes and abstract classes.

---

## ✨ Topics Covered

### 🔷 **1. What is an Interface?**  
- A contract containing *only method declarations*.  
- Defines **what to do**, not **how to do it**.  
- Implementation must be provided by the class.

---

### 🔷 **2. Interface Inheritance**  
- One interface can inherit another interface  
  `interface IMath2 : IMath1`  
- Supports multiple inheritance of interfaces.

---

### 🔷 **3. Multiple Interface Implementation**  
- A class can implement multiple interfaces  
  `class Program : IMath1, IMMath2`  
- Achieves *multiple inheritance* (not possible with classes).

---

### 🔷 **4. Polymorphism with Interfaces**  
Example:  
- `IMath1 m1 = new Program();`  
- Interface reference can access only **interface members**, not class members.  
- Achieves **runtime polymorphism**.

---

### 🔷 **5. Key Rules (Very Important)**  
- Interfaces cannot have fields.  
- Interfaces cannot have constructors.  
- All interface methods are **public + abstract** by default.  
- A class MUST implement all interface members.  
- If not implemented → class becomes **abstract**.  
- Interface cannot be instantiated.

---

## 🧠 Real-Life Analogy  
Think of an interface like a **TV Remote**:  
- Buttons (Power, VolumeUp, VolumeDown) are *declared*.  
- Actual working depends on the *brand class* (SamsungTV, LGTV).  
- Interface = blueprint only.

---

## 🎯 Interview-Ready Questions

1. What is an interface in C#?  
2. Difference between interface and abstract class?  
3. Can we create object of an interface? Why not?  
4. Can interface inherit another interface?  
5. Why do we use multiple interfaces?  
6. What is runtime polymorphism in the context of interfaces?  
7. What happens if a class does not implement all interface methods?

---

## 🏁 Conclusion  
This project gives a solid understanding of how interfaces help in:  
- Achieving abstraction  
- Supporting multiple inheritance  
- Enforcing rules on implementing classes  
- Creating flexible and decoupled applications  

---

### 👨‍💻 Author  
**Parth Dubey**

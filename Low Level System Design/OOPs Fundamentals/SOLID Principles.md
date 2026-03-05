# SOLID Principles (with C# Examples)

This document explains the SOLID principles of object-oriented design, each with a clear definition and C# code example.

---

## 1. Single Responsibility Principle (SRP)
- **Definition:** A class should have only one reason to change.
- **Example:**
```csharp
public class Report {
    public string Content { get; set; }
}
public class ReportPrinter {
    public void Print(Report report) {
        Console.WriteLine(report.Content);
    }
}
```

---

## 2. Open/Closed Principle (OCP)
- **Definition:** Software entities should be open for extension, but closed for modification.
- **Example:**
```csharp
public abstract class Shape {
    public abstract double Area();
}
public class Circle : Shape {
    public double Radius { get; set; }
    public override double Area() => Math.PI * Radius * Radius;
}
public class Square : Shape {
    public double Side { get; set; }
    public override double Area() => Side * Side;
}
```

---

## 3. Liskov Substitution Principle (LSP)
- **Definition:** Subtypes must be substitutable for their base types.
- **Example:**
```csharp
public class Bird {
    public virtual void Fly() {
        Console.WriteLine("Bird flies");
    }
}
public class Sparrow : Bird {}
public class Ostrich : Bird {
    public override void Fly() {
        throw new NotSupportedException("Ostrich can't fly");
    }
}
// Ostrich violates LSP because it can't fly.
```

---

## 4. Interface Segregation Principle (ISP)
- **Definition:** No client should be forced to depend on methods it does not use.
- **Example:**
```csharp
public interface IPrinter {
    void Print();
}
public interface IScanner {
    void Scan();
}
public class MultiFunctionPrinter : IPrinter, IScanner {
    public void Print() { /* ... */ }
    public void Scan() { /* ... */ }
}
```

---

## 5. Dependency Inversion Principle (DIP)
- **Definition:** High-level modules should not depend on low-level modules. Both should depend on abstractions.
- **Example:**
```csharp
public interface IMessageSender {
    void Send(string message);
}
public class EmailSender : IMessageSender {
    public void Send(string message) {
        // send email
    }
}
public class Notification {
    private readonly IMessageSender _sender;
    public Notification(IMessageSender sender) {
        _sender = sender;
    }
    public void Notify(string message) {
        _sender.Send(message);
    }
}
```

---

> **References:**
> - Head First Object-Oriented Analysis and Design
> - C# Documentation

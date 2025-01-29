# Unexpected Property Value Behavior in C#

This repository demonstrates a subtle bug in C# where accessing a property within the same class doesn't always reflect the most up-to-date value. This issue is more likely to occur in larger applications with complex class structures and might manifest differently depending on the order of operations or if multithreading is involved.

The `bug.cs` file shows the incorrect implementation, while `bugSolution.cs` demonstrates the fix and explanation.
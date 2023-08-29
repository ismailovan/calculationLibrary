# Geometry Calculation Library

This library provides a set of classes and methods for calculating the area of geometric shapes such as circles and triangles.

## Features

- Calculate the area of a circle based on its radius.
- Calculate the area of a triangle based on the lengths of its sides.
- Check if a triangle is right-angled.

## Getting Started

### Prerequisites

- .NET Core SDK (version 7.0)
- NUnit (for running tests)

### Installation

1. Clone this repository:
   ``` git clone https://github.com/ismailovan/calculationLibrary.git ```
2. Navigate to the project directory:
   ``` cd calculationLibrary ```
### Usage

1. Reference the `CalculationLibrary` namespace in your code:
  ```csharp
  using CalculationLibrary;
  ```
2. Create instances of geometric shapes and calculate their areas:
 ```csharp
  Circle circle = new Circle(5);
  double circleArea = circle.CalculateArea();
    
  Triangle triangle = new Triangle(3, 4, 5);
  double triangleArea = triangle.CalculateArea();
  bool isRightAngled = triangle.IsRightAngled(); 
 ```
### Running Tests
1. Install NUnit:

  ```csharp
  dotnet add package NUnit
  ```
2. Navigate to the test project directory:
  ```bash
  cd CalculationLibrary.Tests
  ```
3. Run tests using the NUnit CLI:
  ```bash
  dotnet test
  ```
### Contributing
Contributions are welcome! If you find a bug or want to suggest an enhancement, please create an issue or submit a pull request.

### License
This project is licensed under the MIT License.


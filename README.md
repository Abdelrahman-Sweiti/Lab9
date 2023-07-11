# Lab09

Lab09 is a console application that reads data from an external JSON file, performs data filtering and manipulation using LINQ queries, and provides answers to a set of questions based on the data.

## Summary

The Lab09 application processes a JSON file containing location information for properties in Manhattan. It allows users to query and analyze the data, providing insights into the neighborhoods in Manhattan.

## Visuals

example of the console output when running the Lab09 application:

![image](https://github.com/Abdelrahman-Sweiti/Lab9/assets/102755704/497ac1f4-ec89-4d36-b00b-f7176d41c46b)



## Usage

To use the Lab09 application, follow these steps:

1. Clone the repository or download the project files.
2. Open the project in an IDE or text editor.
3. In the `Program.cs` file, locate the line `string json = File.ReadAllText("C:\\Users\\user\\source\\repos\\Lab9\\Lab9\\data.json");`.
4. Replace the file path with the correct path to your JSON file.
5. Build and run the application.
6. The application will output the answers to the questions specified in the prompt, along with the final totals for each question.

## Additional Details

- The Lab09 application uses the Newtonsoft.Json library for deserializing the JSON file.
- The application demonstrates the use of LINQ queries and lambda expressions to filter and manipulate data.
- It includes separate methods for each question to provide a clear and modular structure.
- The code can be easily modified or expanded to handle different data sources or perform additional operations on the data.


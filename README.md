Examination System
        This project is an Examination System developed using Object-Oriented Programming (OOP) principles in C#. The application caters to the following functionalities:

Features
  Question Object:

Includes a header, body, and associated mark.
Supports multiple question types:
Final Exam: True/False, MCQ (Choose one answer)
Practical Exam: MCQ only
Exam Structure:

Two exam types: Final and Practical
Exam base class encapsulates shared attributes:
Time of exam
Number of questions
Dynamic exam display functionality (varies by exam type).
Subject Association:

Each exam is linked to a subject object with details:
Subject ID and name
Exam creation functionality
Answer Management:

Supports multiple answers with details (Answer ID, text, correct answer).
Result Presentation:

Practical Exam: Displays correct answers after submission.
Final Exam: Shows questions, answers, and grades.
Implementation Details
Utilizes OOP concepts like:
Base and inherited classes for modular design
Interfaces (ICloneable, IComparable)
Overriding ToString() for custom object representation
Constructor chaining for efficient initialization
Usage
In the Main method, a subject object is created, allowing users to generate a specific type of exam based on their selection.


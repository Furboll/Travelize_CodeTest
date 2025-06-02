# Travelize_CodeTest
Instructions for the code test I did for the company Travelize.
The solution contains 2 files; one that had the produced code during the 1h time limit. And the main file where I stopped being a dummy and found my brain.

## Club Member Registration Program – Requirements

We need a program written in **C#** that can register members into our club.

- When the program starts, it should prompt the user to enter:
  1. The **name**
  2. The **birthdate** of new members

- A person can become a member **from the year they turn 15**.
  - If the person is **too young**, an **exception should be thrown and caught**, and an **error message should be displayed** to the user.

- If the **name is shorter than 5 characters**, an exception should also be thrown and handled.
  - A **full name** must be provided.

- If an **empty string** is entered as the member's name, the **program should terminate**.

- When the program terminates:
  - All **newly registered members** should be **saved to the same file**.
  - Each member should be stored on a **separate line**, with the **name and birthdate separated by a tab character** (`\t`).
  - The program should **not overwrite existing members** in the file.

- The program should be a **console application**.

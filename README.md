Solution to FSL Code Exercise

//Exercise 1
/*
* Lack of input validation (Typing letter will cause unhandled error)
* Negative number can be passed to width
* Shape object needs initialization every time
* Bad naming, for example Area sounds like filed or property. It is hard to recognize what it does without analizing code inside
*/

//Exersise 2
/*
* Inside code. Shortly added input validation, units tests and Singleton based solution
*/

//Exercise 3
/*
* Imporove thread safety
* Separate input validation for further use
* Add validation tests
* Add InvalidProgramException handling
*/

FSL Code Exercise
=================

Below are the following exercises are to be completed by candidates prior to a 
face-to-face interview at FSL.  The exercises are designed to be sort and 
should take no more than 2 hours to complete.

The starting code base can be found at:
https://github.com/FinancialSoftwareLimited/CodeExercise


Exercise 1 (max 30mins)
----------
- Critique the code:
  - Identify the most offensive code "smell"
  - Identify potential problems that could be encountered in developing and/or 
    maintaining a system that uses the code as it is written

Exercise 2 (max 1hour)
----------
- Refactor to "fix" the code

Exercise 3 (max 30mins)
----------
- Describe why the refactored code is better than the previous code
- Describe what you would do if you had longer than 2 hours to complete these 
exercises.


Notes
-----
- No external libraries, databases, resources should be required to complete 
  these exercises.  If you decide to use an external library, please reference 
  the package using nuget.
- All notes should be provided as C# comments in your submitted solution.
- Brownie points will be awarded for TDD and/or BDD solutions.

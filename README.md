# Nagwa-Task
Using Page Object Model i have developed my solution.
Solution contains main three folders Pages, Tests, Factory Wrapper.
Page folder holds all web pages classes.
Each page class holds the web elements and the methods which handle the test cases and operations can be made on the web elements.
Tests folder holds the test classes which contain the test cases of each page and its web elements.
Wrapper Factory folder holds the wrapper class which holds the methods (Actions) can be made on any of the web elements. 
All test data are imported from Excel sheet.
The final test which is located in the last step class (Worksheet_tests) contains all steps from opening the website till reaching the wroksheet page and calculating the number of questions displayed in the page.
The workflow As Following -> User open the web site then choose the english language from the main page (LanguagePage_tests) -> then, Searching for Addition by clicking on the search icon from the home page (HomePage_tests) -> then, click on the second search result From the search results page (SearchResults_tests) -> then, click on the worksheet item to preview the worksheet home page from the Lesson page(Lessons_tests) -> then, in the worksheet home page we can calcualte the number of questions displayed in the page (Worksheet_tests).

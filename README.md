
# Queen Attack

#### By Andy Grossberg & Hamza Naeem

## Description
A program to test if a given set of words are partial or whole anagrams for a key word.

## Rules
An anagram is a word that you can rearrange the letters and it becomes a new word. For example, "bread" is an anagram of "beard".

Create a web page, with MVC, where a user can input a single word and a list of other words that may be anagrams.

After submitting the form, the user should be told which of the list of words were anagrams.

Start by writing the specs and method first, before you begin creating a MVC webpage.

The Array.Sort() method may come in handy, so try it out in the REPL to see exactly what it does.

If you finish this, modify your function to handle partial matches - in other words, 'hat' should match 'path'.

## Specifications

* Display a view that is a title screen as Index()

* Display a Index() with empty list as @Model.

* Use form to ask user for a key word to test against on Index()
  - EXPECTED INPUT: [Word]
  - EXPECTED OUTPUT: NONE

* Add a form for a word list to the Index()
  - EXPECTED INPUT: <LIST> of Words
  - EXPECTED OUTPUT: NONE

* Add SUBMIT button

* Link SUBMIT button to "/"

* Create WORD object

* Break Key word into an Array of Chars
  1. String Key = "test";
  2. var ourChars = Key.ToCharArray();

* Sort ourChars
  - EXPECTED INPUT: ["B", "E", "A", "R", "D"];
  - EXPECTED OUTPUT: (each Char on a separate line, "A", "B", "D", "E", "R")

* Break their word list into an array of strings split at space and punctuation
  1. string[] wordList = Regex.Split(value, "/[^!-~] /");

* Break their first word into an Array of Chars and send the chars to the Console
  1. var theirChars = wordList[0].ToCharArray();
    - EXPECTED INPUT: ["B", "R", "E", "A", "D"];
    - EXPECTED OUTPUT: (each Char on a separate line)

* Sort theirChars (the array of their first word)
  - EXPECTED INPUT: ["B", "E", "A", "R", "D"];
  - EXPECTED OUTPUT: (each Char on a separate line, "A", "B", "D", "E", "R")    

* Compare our key word Char array against their first word Char array
  1. var theirChars = wordList[0].ToCharArray();
  2. if(ourChars.SequenceEqual(theirChars)) { . . . }
  - EXPECTED INPUT: ["B", "E", "A", "R", "D"];
  - EXPECTED INPUT: ["B", "R", "E", "A", "D"];
  - EXPECTED OUTPUT:
    - TRUE: Write to Console "That word is a match!"
    - FALSE: Write to Console "That word is NOT a match!"

* ForEach Loop through the String array of their words.
  - EXPECTED OUTPUT: Write their String to Console, one word and a carriage return at time

* ForEach Loop through String array of their words, and break each string in the array into an array of Chars
- EXPECTED OUTPUT: Write the individual Chars of their String to Console, one char and a carriage return at time

* ForEach Loop through String array of their words as above but compare each Char array with our key Word Char array
  - TRUE: Join their word Char array back to a string and add it to a List of successful compares
  - FALSE: iterate loop

* Display successful compares list of above step to screen via View() on Index page.

* Refactor Code

## Setup/Installation Requirements

* Clone the git repository from 'https://github.com/agro23/Anagram.git'.
* run the command 'dotnet restore' to download the necessary packages.
* run the command 'dotnet run' to build and run the server on localhost.
* use your preferred web browser to navigate to localhost:5000

## Support and contact details

* Contact the authors via andy.grossberg@gmail.com

## Technologies Used

* C#
* Asp .NET Core MVC
* HTML
* CSS
* Javascript
* Bootstrap
* JQuery

### License

Copyright (c) 2018 Andy Grossberg & Hamza Naeem

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

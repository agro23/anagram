
# Queen Attack

#### By Cameron Anderson & Andy Grossberg

## Description
A program to test if a given set of coordinates is a valid target for the queen to attack in a game of chess.

## Specifications
* choose an x and y for the queen

* Display a view that is a title screen.

* Use form to ask user for an x and y coord for the queen to start on.
- Expected Input: 3, 5
- Expected Output: None

* output coords to main view
- Expected Input: None
- Expected Output: STRING

* validate queen ranges 1 - 8
- If false return to View with form

* Use form to ask user for an x and y coord for the queen to target.
- Expected Input: 4, 8
- Expected Output: None

* output coords to main view
- Expected Input: None
- Expected Output: STRING

* validate target ranges 1 - 8
- If false return to View with form

* validate queen and target coordinates are different
- If false return to View with form

* Create QueenAttackTest object

* Create Queen object

* a. queen x and target x are equal
- Expected input: (3, 7) , (3, 4)
- Expected output: True
- Expected input: (2, 7) , (6, 4)
- Expected output: False

* b. queen y and target y are equal
- Expected input: (8, 4) , (3, 4)
- Expected output: True
- Expected input: (8, 1) , (3, 4)
- Expected output: False

* c. abs(qx - vx) is equal to abs(qy - vy)
- Expected input: (8, 4) , (6, 6)
- Expected output: True
- Expected input: (1, 1) , (3, 3)
- Expected output: True
- Expected input: (8, 1) , (3, 4)
- Expected output: False

* use a - c to determine if victim can be reached by queen
- Expected input: (8, 4) , (6, 6)
- Expected output: "Queen takes piece"
- Expected input: (8, 4) , (6, 3)
- Expected output: "Queen cannot reach piece"

* refactor code as needed.

## Setup/Installation Requirements

* Clone the git repository from 'https://github.com/camander321/LeapYearTest.git'.
* run the command 'dotnet restore' to download the necessary packages.
* run the command 'dotnet run' to build and run the server on localhost.
* use your preferred web browser to navigate to localhost:5000


## Support and contact details

* contact the author at chamburg321@gmail.com

## Technologies Used

* C#
* Asp .NET Core MVC
* HTML
* CSS
* Javascript
* Bootstrap
* JQuery

### License

Copyright (c) 2018 Cameron Anderson & Andy Grossberg

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

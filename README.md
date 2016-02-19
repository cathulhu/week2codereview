# _Sub-string Detector_

#### _Code Review for C#, #2, 2/19/2016_

#### By _**Labyrinth (Lydia)**_

## Description

Sub-string Detector finds a full match of a target substring within a larger string and returns the number of full matches.
* _Inputted string to search is broken down into sub strings of size equal to the target substring_
* _Each sub string is compared via a string compare, to the target sub string_
* _each a time a match is found between the sub strings a counter is incrimented and that result is outputted tou our web interface_
## Setup/Installation Requirements

1. Clone this repo to a local directory 
2. Open a terminal in that directory
3. type "dnx kestrel" OR appropriate syntax for your C# instance, to start server
4. point browser to http://localhost:5004

## Technologies Used

* Nancy - Razor view engine 1.3.0
* AspNet (Kestrel) 1.0.0-*
* Xunit


### License

Released under Apache 2.0 License

# _WordCounter_

#### _A program that returns user-provided-word instances in a user-provided-string._

#### By _**Rachel Schieferstein**_

## Description


## Setup/Installation Requirements


* _Clone or download from Github Repository._
* _Install .NET Core SDK_
* _In the terminal, run "dotnet add package Figgle"_
* _In the terminal in the root directory, type "dotnet run"._

## Specifications
| Behavior      | Input         | Output|
| ------------- |:-------------:| -----:|
| returns an integer for occurences | reference word: "a" string: "a A a"            | 3 |
| in occurrences without spaces between letters, does not recognize | reference word: "a", string: "aaa"     |0 |
|returns the correct occurences in strings with more complicated grammar notation   | reference word: "sight", “It was love at first sight, at last sight, at ever and ever sight.”            | 3 |
| returns a message for no occurences   |  reference word: "yahtzee", string: “if a violin string could ache, i would be that string.”          | "This word doesn't occur in the entered text." |


## Known Bugs

N/A

## Support and contact details

_If there are any questions, please contact me at violenza@gmail.com._

## Technologies Used

_This project was created with C#._

### License

*This software is licensed under the MIT license.*

Copyright (c) 2020 **_Rachel Schieferstein_**
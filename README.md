# GitDemo
A first demo of git functionalities

## Idea
### General Description
Use **Github** to create a new file, then *commit* and show a basic process.

### Why
This project should help students to get a first insight into git.

## Next Step
Clone the repo on your computer

## Advanced Work
* Change a file
* Commit the changes
* Push the changes
* Check the changes on Github

## Show Enumerations
It is possible to enumerate some lines:

1. First item
1. Griasdi
1. Pfiati

## Tables
|   A   |   B   |   C   |   D   |
|-------|-------|-------|-------|
|   A1    |   A2    |   A3    |   A4    |
|   B1    |   B2    |   Ein langes B3    |       |
|       |       |       |       |
|       |       |       |       |
|       |       |       |       |
|       |       |       |       |

## Code
In the file `tool.cs` the logic of our program is written:
```cs
Console.WriteLine("Pfui");
```

Details about this code can be found on the [following website](https://www.google.at). But it is also possible to [link to an internal page](docs/details.md).

## Install PlantUML
### Windows
1. Download Graphviz from the official website: https://graphviz.org/download/
1. Run the Graphviz installer and follow the installation instructions.
1. Download PlantUML from the official website: https://plantuml.com/download
1. Extract the downloaded PlantUML zip file to a desired location on your computer.
1. Add the location of the Graphviz bin folder to the system's PATH environment variable. This is usually C:\Program Files\Graphviz\bin.
Open a command prompt and navigate to the location where you extracted PlantUML.
1. Run the command java -jar plantuml.jar -version to verify that PlantUML is installed correctly.
   
That's it! You have successfully installed PlantUML and its dependencies on Windows. You can now use PlantUML to generate UML diagrams in your Markdown files.

### macOS
Using homebrew is recommended: In the terminal type `brew install plantuml`. This installs the package including all its dependencies.

### VS Code
In order to see PlantUML diagrams in the VS Code markdown preview the extension *Markdown Plantuml Review* must be installed.


## PlantUML Reference Guide
- https://plantuml.com/guide: One large document covering all (lots of scrolling necessary)
- https://plantuml.com/use-case-diagram
- https://plantuml.com/activity-diagram-beta
- https://plantuml.com/state-diagram
- https://plantuml.com/class-diagram

## A Sample Use Case Diagram
```plantuml
@startuml
left to right direction
rectangle ATM {
    usecase "Withdraw Money" as wm
    usecase "Refill Money" as rm
}
:Administrator: -up-> rm
:Customer: -down-> wm
@enduml
```

## A Sample Activity Diagram
```plantuml
|Customer|
start
repeat
:Enter PIN;
repeat while (pin ok **and** number of attempts <= 3?) is (no)
if (number of attempts?) then (>3)
    |ATM|
    :Report error;
    :Confiscate card;
else (<=3)
|Customer|
:Enter amount;
|ATM|
:Check Balance; <<output>>
:Return card;
:Handout money;
endif
stop

|Bank|
start
:Check Balance;
if (balance ok?) then (yes)
    :approved; <<output>>
else (no)
    :not approved; <<output>>
endif
stop
```
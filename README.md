# BabySitterKata
Included in this repository is a working version of the BabySitter kata

This Kata was written in .NET C#. I used Visual Studio 2017 as my IDE.

The Kata contains 3 projects:
* A Test project with 17 valdated tests
* The BabySitter project that contains the BabySitter class where the logic resides
* A console application that can be used to run the BabySitter class

### Assumptions
* Three times **must** be included to get a valid calculated nightly charge
  * A start time
  * A bed time
  * An end time
* If the bed time does not fall between the start time and the end time, it will be ignored
* The format for the time is "12:00am" - "11:59pm"
  * if the time is "am", it is assumed to be after midnight on the day of the baby sitting event
* If you enter anything other than a valid time, the calculated nightly charge will be $0.


### Buliding and Running Tests

I've included a console application in this Kata that you can use to test the BabySitter class code.
The executable can be found in the BabySitterConsole folder: 
* BabySitterConsole\ConsoleApp\BabySitterConsole.exe

Click on the BabySitterConsole.exe in the saved folder on your PC to start the program. The program will instruct you which times to enter. Once you have entered a start time, a bed time, and an end time, the application will print out calculated nightly charge, then it will ask you if you would like to continue.
* To continue, enter "y" or "Y"
* to stop the application enter any other key






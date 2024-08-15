# Simple mouse click tester

This is an application that it is solving a problem that I had with mice. Sometimes mice would start malfunctioning, this tool provides methods to test if mouse has failing buttons.


## Usage

1. Three modes for testing: Realtime, Highlight and Double Click mode.
2. Continuity test: Select RT mode, hold down the desired click and check if the mouse click counter increases.
3. Scroll test: Select HL mode, scroll in one direction and check if it highlights the scroll in the other direction.
4. Simultaneous click test: Select RT mode, press combinations of clicks (especially LMB+MB3 and MMB+MB4 if your mouse has MB3 and 4) and check if they both highlight at the same time.
5. Double click test: Select DC mode and perform single clicks to check if the mouse would perform a faulty doubleclick or check if you can perform double clicks with that mouse. Works for all buttons and the click counter only records the number of double clicks.


## Demo

Insert gif or link to demo


## Techonolgies used

C#, .NET 6.0 and Windows Forms.


## Run Locally

Download the compiled application from the releases page.
https://github.com/fistarter/simple-mouse-click-tester/releases

Or
1. Clone the repository
2. Open the project in Visual Studio
3. Build and run the application

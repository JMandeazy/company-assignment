# Moving Object Simulator

A command-line based simulation of a moving object on a rectangular grid.

## Description

The program reads input from stdin and simulates the movement of an object on a table.

The object:
- Occupies one cell
- Starts facing North
- Can rotate and move forward/backward
- Fails if it moves outside the table

## Input Format

Comma-separated integers:

width,height,startX,startY,commands...

Example:

4,4,2,2,1,4,1,3,2,3,2,4,1,0

## Commands

0 = quit simulation  
1 = move forward  
2 = move backward  
3 = rotate clockwise  
4 = rotate counterclockwise  

## Output

If simulation succeeds:
[x, y]

If simulation fails:
[-1, -1]

## Running the Application
Start this application by pressing F5.

To start the test project, click on test up top and run all tests.
If all passes you should get "Outcomes 5 Passed"

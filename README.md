# Tic Tac Toe Game

## Description
This is a simple Tic Tac Toe game developed using C# and Windows Forms. The game supports two players (Player 1 and Player 2) taking turns to mark their moves on a 3x3 grid. The objective is to align three of the same symbols (X or O) horizontally, vertically, or diagonally. The game ends when one player wins or when all grid cells are filled without a winner (draw).

## Features
- **Two-player mode**: Players take alternate turns.
- **Winner detection**: Highlights the winning combination in green.
- **Draw detection**: Ends the game when all cells are filled with no winner.
- **Restart option**: Allows players to restart the game.

## Project Structure
- **Enums**:
  - `enPlayer`: Tracks the current player (Player1 or Player2).
  - `enWinner`: Represents the game state (Player1, Player2, Draw, or InProgress).
- **Struct**:
  - `stGameStatus`: Stores the game state, winner, play count, and whether the game is over.
- **Core Methods**:
  - `PerformTicTacToe(Button btn)`: Handles player moves and updates the game state.
  - `CheckWinner()`: Checks for a winner or a draw.
  - `EndGame()`: Displays the game result and provides options to restart or exit.
  - `RestartGame()`: Resets the game to its initial state.

## How to Play
1. Run the application.
2. Player 1 starts the game and marks their move with "X" by clicking on a grid cell.
3. Player 2 takes the next turn and marks their move with "O".
4. The game automatically detects a win, draw, or continues until all cells are filled.
5. After the game ends, players can choose to restart or exit.

## Controls
- **Grid Buttons**: Click to mark your move.
- **Restart Button**: Click to restart the game.

## Visuals
The game uses a visually distinct design:
- A 3x3 grid divided by bold white lines.
- Symbols (X and O) represented by custom images.
- Winning combination highlighted in green.

## Requirements
- Windows OS
- .NET Framework

## Setup
1. Clone or download the project files.
2. Open the solution in Visual Studio.
3. Build and run the project.

## Dependencies
The project uses resources such as:
- `Properties.Resources.X`: Image for Player 1's mark.
- `Properties.Resources.O`: Image for Player 2's mark.
- `Properties.Resources.question_mark_96`: Image for empty cells.

## Credits
- Developed by Awni.

## License
This project is open-source and available for personal or educational use.


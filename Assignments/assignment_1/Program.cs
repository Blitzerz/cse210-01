/*
Assignment 1: Tic-Tac-Toe
Author: Andre Milad
*/

using System.Collections.Generic;

void main() {
    List<string> board = makeBoard();
    string nextPlayer = determineNextPlayer("");

    while (! (hasWinner(board) || hasDraw(board))) {
        showBoard(board);
        doMove(board, nextPlayer);
        nextPlayer = determineNextPlayer(nextPlayer);
    }
    showBoard(board);

    if (hasWinner(board)) {
        nextPlayer = determineNextPlayer(nextPlayer);
        Console.WriteLine($"{nextPlayer.ToUpper()} is the winner!");
        Console.WriteLine("Thanks for playing.");
    }

    else if (hasDraw(board)) {
        Console.WriteLine("Cat Game. Unlucky.");
        Console.WriteLine("Thanks for playing.");
    }
}

List<string> makeBoard() {
    List<string> board = new List<string>(9);
    for (int i = 0; i < 9; i++) {
        board.Add((i + 1).ToString());
    }

    return board;
}

string determineNextPlayer(string letter) {
    if (letter == "x") {
        return "o";
    }
    else {
        return "x";
    }
}

void showBoard(List<string> board) {
    Console.WriteLine();
    Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
    Console.WriteLine("-+-+-");
    Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
    Console.WriteLine("-+-+-");
    Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
    Console.WriteLine();
}

bool hasWinner(List<string> board) {
    if (board[0] == board[1] && board[1] == board[2] ||
        board[3] == board[4] && board[4] == board[5] ||
        board[6] == board[7] && board[7] == board[8] ||
        board[0] == board[3] && board[3] == board[6] ||
        board[1] == board[4] && board[4] == board[7] ||
        board[2] == board[5] && board[5] == board[8] ||
        board[0] == board[4] && board[4] == board[8] ||
        board[2] == board[4] && board[4] == board[6]) {
        return true;
    }

    else {
        return false;
    }
}

bool hasDraw(List<string> board) {
    for (int i = 0; i < 9; i++) {
        if (board[i] != "x" && board[i] != "o") {
            return false;
        }
    }

    return true;
}

void doMove(List<string> board, string nextPlayer) {
    Console.Write($"It's {nextPlayer}'s turn. Choose a square (1-9): ");
    int boardSpot = int.Parse(Console.ReadLine());
    while (boardSpot > 9 || boardSpot < 1 || board[boardSpot-1] == "o" || board[boardSpot-1] == "x") {
        Console.WriteLine();
        Console.WriteLine("Invalid move. Enter a number between 1-9");
        Console.WriteLine();
        Console.Write($"It's {nextPlayer}'s turn. Choose a square (1-9): ");
        boardSpot = int.Parse(Console.ReadLine());
    }

    board[boardSpot - 1] = nextPlayer;
}

main();
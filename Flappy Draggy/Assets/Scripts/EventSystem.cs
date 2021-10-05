using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventSystem
{
    public delegate void StartGameEvent();
    public static event StartGameEvent startGame;

    public delegate void EndGameEvent();
    public static event EndGameEvent endGame;

    static bool isRunning = false;
    public static bool GameRunning()
    {
        return isRunning;
    }
    public static void SetGameRunning(bool run)
    {
        isRunning = run;
    }

    public static void StartGame()
    {
        if (startGame != null)
        {
            startGame();
        }
    }

    public static void EndGame()
    {
        if (endGame != null)
        {
            endGame();
        }
    }
}

using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    [SerializeField] private Board board;

    public event Action OnGameOver;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void NewGame() 
    {
        board.ClearBoard();
        board.CreateTile();
        board.CreateTile();

        board.enabled = true;
    }


    public void GameOver() 
    {
        board.enabled = false;
        OnGameOver?.Invoke();

    }

}

using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Board : MonoBehaviour
{
    [SerializeField] private Tile tilePrefab;
    [SerializeField] private TileStateSO[] tileStates;

    private List<Tile> tiles = new List<Tile>();

    private TileGrid grid;
    private void Awake()
    {
        grid = GetComponentInChildren<TileGrid>();
    }
    private void Start()
    {
        CreateTile();
        CreateTile();
    }


    public void CreateTile() 
    {
        Tile tile = Instantiate(tilePrefab, grid.transform);
        tile.SetState(tileStates[0], Consts.Numbers.NUMBER_2);

        tile.Spawn(grid.RandomEmptyCell());
        tiles.Add(tile);
    }
}

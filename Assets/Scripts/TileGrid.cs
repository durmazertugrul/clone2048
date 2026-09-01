using UnityEngine;

public class TileGrid : MonoBehaviour
{
    public Row[] rows { get; private set; }
    public Cell[] cells { get; private set; }


    private int size => cells.Length;
    private int height => rows.Length;
    private int width => size / height;

    private void Awake()
    {
        rows = GetComponentsInChildren<Row>();
        cells = GetComponentsInChildren<Cell>();
    }

    private void Start()
    {
        for (int row = 0; row < rows.Length; row++) //y axis
        {
            for (int col = 0; col < rows[row].cells.Length; col++) //x axis
            {
                rows[row].cells[col].coordinates = new Vector2Int(col, row);
            }
        }
    }

    public int GetSize() {  return size; }
    public int GetHeight() {  return height; }
    public int GetWidth() {  return width; }


}

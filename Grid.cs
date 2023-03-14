public class Grid
{
    private readonly int _numberOfRows;
    private readonly int _numberOfColumns;
    private List<List<Cell>> _cells;
    enum Type
    {
        Empty, 
        Ship, 
        FiredShip
    }
    public Grid(int numberOfRows, int numberOfColumns)
    {
        _numberOfRows = numberOfRows;
        _numberOfColumns = numberOfColumns;
        _cells = new List<List<Cell>>(_numberOfRows);
        for (var i = 0; i < _numberOfRows; i++)
        {
            _cells[i] = new List<Cell>(_numberOfColumns);
            for (var j = 0; j < _numberOfColumns; j++)
            {
                _cells[i][j] = new Cell();
            }
        }
    }

    public bool IsEmpty(int row, int column)
    {
        if (_isValidRow(row) && _isValidColumn(column))
        {
            return _cells[row][column].Type == Type.Empty;
        }
        Console.WriteLine("This Position is out of bound\n");
        return false;
    }

    private bool _isValidColumn(int column)
    {
        return column >= 0 && column < _numberOfColumns;
    }
    private bool _isValidRow(int row)
    {
        return row >= 0 && row < _numberOfRows;
    }

    private class Cell
    {
        public Type Type { get; set; }
        public Cell()
        {
            Type = Type.Empty;
        }
        public Cell(Type type)
        {
            Type = type;
        }
    }
}
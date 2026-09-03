# Clone2048

A Unity implementation of the classic **2048** puzzle game, built as part of a series of clone projects for learning core Unity game development mechanics.

## About the Project

Clone2048 recreates the sliding-tile puzzle mechanics of the original 2048 game. The project is structured around a modular grid system, where cells and rows are dynamically resolved at runtime and tile data (value, background color, text color) is managed through Unity ScriptableObjects, making it easy to extend or reskin the tile set.

This project is part of a broader personal learning path focused on building small, self-contained clone games (Flappy Bird, Space Invaders, 2048, Match-3) to practice Unity fundamentals before moving on to original game projects.

![Clone2048 gameplay demo](Media/2048gif.gif)

## Current Status

This project is a **work in progress**. The following pieces are currently implemented:

- Grid architecture (`TileGrid`, `Row`, `Cell`) that resolves rows and cells from the scene hierarchy and assigns 2D coordinates to each cell.
- A `TileStateSO` ScriptableObject defining the visual state (background color, text color) for each tile value, with assets already created for values `2` through `2048`.
- A `Tile` prefab wired up for use within the grid.
- Initial tile spawning logic: `Board.CreateTile()` instantiates a tile, applies its visual state via `Tile.SetState()`, and places it via `Tile.Spawn()` on a random empty cell found by `TileGrid.RandomEmptyCell()`. Two tiles are spawned at game start.
- Player input handling: `Board.Update()` reads both WASD and arrow keys to trigger movement in the corresponding direction.
- Tile movement: `Board.MoveTiles()` / `Board.MoveTile()` slide tiles toward the edge of the grid in the chosen direction, stopping at occupied cells or merging when possible.
- Merge logic: `Board.CanMerge()` / `Board.Merge()` combine equal-value tiles, advancing their `TileStateSO` and doubling their value, with a DOTween scale-pulse animation (`Board.AnimateTiles()`).
- Tile spawning after each valid move: `Board.WaitForChanges()` unlocks merged tiles and spawns a new tile once a move finishes.
- Tile value constants defined in `Consts.Numbers` (`2` through `2048`).

Not yet implemented:

- Score tracking and UI.
- Win/lose conditions and UI.

## Tech Stack

- **Engine:** Unity 6000.4.5f1 (Unity 6)
- **Language:** C#
- **Render Pipeline:** Universal Render Pipeline (URP)
- **Input:** Legacy Input Manager (`Input.GetKeyDown`), Active Input Handling set to Both
- **Animation:** DOTween

## Project Structure

```
Assets/
├── Prefabs/              # Tile prefab
├── Scenes/               # SampleScene (main game scene)
├── Scriptable Objects/   # TileStateSO assets for each tile value (2–2048)
├── Scripts/
│   ├── Board.cs          # Game board controller (spawning, movement, merge, input implemented)
│   ├── Cell.cs           # Single grid cell (coordinates, occupancy)
│   ├── Consts.cs         # Shared constants (tile value numbers)
│   ├── Row.cs             # Row of cells
│   ├── Tile.cs             # Tile behaviour (state + spawn implemented)
│   ├── TileGrid.cs         # Grid setup, row/cell resolution, random empty cell lookup
│   └── SO/
│       └── TileStateSO.cs
├── Sprites/
├── Font/
└── Settings/             # URP and project rendering settings
```

## Getting Started

### Prerequisites

- [Unity Hub](https://unity.com/download)
- Unity Editor version **6000.4.5f1** (or a compatible Unity 6 version)
- [DOTween](http://dotween.demigiant.com/) imported into the project

### Installation

1. Clone the repository:

```
git clone https://github.com/durmazertugrul/clone2048.git
```

2. Open Unity Hub and select **Add project from disk**, then choose the cloned folder.
3. Open the project with the matching Unity Editor version.
4. Open `Assets/Scenes/SampleScene.unity` and press **Play** in the Unity Editor.
5. Use **WASD** or the **arrow keys** to move tiles.

## Roadmap

- [x] Implement tile spawning at game start
- [x] Implement tile spawning after each valid move
- [x] Implement swipe/arrow-key input handling
- [x] Implement tile movement and merging logic
- [ ] Add score tracking and UI
- [ ] Add win (2048 tile) and game-over (no valid moves) states
- [ ] Add restart functionality

## License

No license has been specified for this project yet.

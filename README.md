# Clone2048

A Unity implementation of the classic **2048** puzzle game, built as part of a series of clone projects for learning core Unity game development mechanics.

## About the Project

Clone2048 recreates the sliding-tile puzzle mechanics of the original 2048 game. The project is structured around a modular grid system, where cells and rows are dynamically resolved at runtime and tile data (value, background color, text color) is managed through Unity ScriptableObjects, making it easy to extend or reskin the tile set.

This project is part of a broader personal learning path focused on building small, self-contained clone games (Flappy Bird, Space Invaders, 2048, Match-3) to practice Unity fundamentals before moving on to original game projects.

## Current Status

This project is a **work in progress**. The following pieces are currently implemented:

- Grid architecture (`TileGrid`, `Row`, `Cell`) that resolves rows and cells from the scene hierarchy and assigns 2D coordinates to each cell.
- A `TileStateSO` ScriptableObject defining the visual state (background color, text color) for each tile value, with assets already created for values `2` through `2048`.
- A `Tile` prefab wired up for use within the grid.
- Initial tile spawning logic: `Board.CreateTile()` instantiates a tile, applies its visual state via `Tile.SetState()`, and places it via `Tile.Spawn()` on a random empty cell found by `TileGrid.RandomEmptyCell()`. Two tiles are spawned at game start.
- Tile value constants defined in `Consts.Numbers` (`2` through `2048`).

Not yet implemented:

- Tile spawning after each valid move.
- Player input handling and tile movement.
- Merge logic and score tracking.
- Win/lose conditions and UI.

## Tech Stack

- **Engine:** Unity 6000.4.5f1 (Unity 6)
- **Language:** C#
- **Render Pipeline:** Universal Render Pipeline (URP)
- **Input:** Unity Input System

## Project Structure

```
Assets/
├── Prefabs/              # Tile prefab
├── Scenes/               # SampleScene (main game scene)
├── Scriptable Objects/   # TileStateSO assets for each tile value (2–2048)
├── Scripts/
│   ├── Board.cs          # Game board controller (tile spawning implemented)
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

### Installation

1. Clone the repository:

```
git clone https://github.com/durmazertugrul/clone2048.git
```

2. Open Unity Hub and select **Add project from disk**, then choose the cloned folder.
3. Open the project with the matching Unity Editor version.
4. Open `Assets/Scenes/SampleScene.unity` and press **Play** in the Unity Editor.

## Roadmap

- [x] Implement tile spawning at game start
- [ ] Implement tile spawning after each valid move
- [ ] Implement swipe/arrow-key input handling
- [ ] Implement tile movement and merging logic
- [ ] Add score tracking and UI
- [ ] Add win (2048 tile) and game-over (no valid moves) states
- [ ] Add restart functionality

## License

No license has been specified for this project yet.

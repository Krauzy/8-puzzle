# 8-PUZZLE
Using heuristic search methods to solve 8-puzzle

## Definition

8-puzzle game is a sliding puzzle that consists of a frame of numbered square tiles in random order with one tile missing.

<img src='https://camo.githubusercontent.com/59b1fbe9a5574e01cb73240f565a1a7cacd63385c81ba0fb74552fb5229c5fae/68747470733a2f2f6d69726f2e6d656469756d2e636f6d2f6d61782f3932342f312a5978655a4a7a666857346b6e354f35774147626b49672e676966' width='30%'></img>

There are several methods to solve the 8-puzzle, from solving by trial and error or using AI techniques with heuristic search.

## Search Methods

### DFS : Depth-First Search

Go through all the ``child nodes`` on the left until you reach the end, if it is not the ``goal state``, return through the ``parent nodes`` and go through the ``child nodes`` on the right. ``Repeat`` until you find the ``goal state``.

<img src='https://upload.wikimedia.org/wikipedia/commons/7/7f/Depth-First-Search.gif' width='30%'></img>

### BFS : Breadth-First Search

Go through the ``child nodes`` by ``depth level``, until you find the first occurrence of the ``goal state``.

<img src='https://upload.wikimedia.org/wikipedia/commons/5/5d/Breadth-First-Search-Algorithm.gif' width='30%'></img>

# Configuration

## Install
Install streamlit package to host the server

```sh
 pip install streamlit
```
*Warning: Streamlit is a web framework that hosts the own server, so using jupyter is not viable due to conflicts with servers*

# Inicialization
Run main.py using the streamlit hook
```sh
 streamlit run main.py
```


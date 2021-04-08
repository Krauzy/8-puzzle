from collections import deque
from random import seed, randint

seed(1)

goals = [1, 2, 3, 4, 5, 6, 7, 8, 0]
visits = 0
target = None


class Puzzle:
    def __init__(self, state, parent = None, move = None, cost = 0):
        self.state = state
        self.parent = parent
        self.move = move
        self.cost = cost
        if self.state:
            self.map = ''.join(str(e) for e in self.state)
    
    def __eq__(self, o):
        return self.map == o.map
    
    def __lt__(self, other):
        return self.map < other.map

    def __str__(self):
        return str(self.map)


def get_children(node):
    global visits
    visits = visits + 1
    paths = []

    # 1 - UP
    # 2 - DOWN
    # 3 - LEFT
    # 4 - RIGHT
    
    paths.append(Puzzle(switch(node.state, 1), node, 1, node.cost + 1))
    paths.append(Puzzle(switch(node.state, 2), node, 2, node.cost + 1))
    paths.append(Puzzle(switch(node.state, 3), node, 3, node.cost + 1))
    paths.append(Puzzle(switch(node.state, 4), node, 4, node.cost + 1))

    sub = []
    for p in paths:
        if p.state != None:
            sub.append(p)
    return sub


def breadth_first(state):
    global target
    olds = set()
    queue = deque([Puzzle(state)])

    while queue:
        node = queue.popleft()
        olds.add(node.map)
        if node.state == goals:
            return node
        paths = get_children(node)
        for path in paths:
            if path.map not in olds:    # FIX
                queue.append(path)
                olds.add(path.map)


def depth_first(state):
    global target
    olds = set()
    stack = list([Puzzle(state, None, None, 0)])

    while stack:
        node = stack.pop()
        olds.add(node.map)
        if node.state == goals:
            return node
        paths = reversed(get_children(node))
        for path in paths:
            if path.map not in olds:    # FIX
                stack.append(path)
                olds.add(path.map)


def shuffle(state=[], n=50):
    temp = state[:]
    for i in range(n):
        x = switch(temp, randint(1, 4))
        if x != None:
            temp = x
    return temp



def solve(init=[], method='DFS'):
    if method == 'DFS':
        target = depth_first(init)
    else:
        target = breadth_first(init)
    
    moves = []
    while init != target.state:
        moves.append(target.state)
        target = target.parent
    return (len(moves), moves)


def switch(state, where):
    temp = state[:]
    index = temp.index(0)
    # [0][0]
    if index == 0:
        if where == 1:
            return None
        if where == 2:
            aux = temp[index]
            temp[index] = temp[3]
            temp[3] = aux
        if where == 3:
            return None
        if where == 4:
            aux = temp[index]
            temp[index] = temp[1]
            temp[1] = aux
        return temp
    # [0][1]
    if index == 1:
        if where == 1:
            return None
        if where == 2:
            aux = temp[index]
            temp[index] = temp[4]
            temp[4] = aux
        if where == 3:
            aux = temp[index]
            temp[index] = temp[4]
            temp[4] = aux
        if where == 4:
            aux = temp[index]
            temp[index] = temp[2]
            temp[2] = aux
        return temp
    # [0][2]
    if index == 2:
        if where == 1:
            return None
        if where == 2:
            aux = temp[index]
            temp[index] = temp[5]
            temp[5] = aux
        if where == 3:
            aux = temp[index]
            temp[index] = temp[1]
            temp[1] = aux
        if where == 4:
            return None
        return temp
    # [1][0]
    if index == 3:
        if where == 1:
            aux = temp[index]
            temp[index] = temp[0]
            temp[0] = aux
        if where == 2:
            aux = temp[index]
            temp[index] = temp[6]
            temp[6] = aux
        if where == 3:
            return None
        if where == 4:
            aux = temp[index]
            temp[index] = temp[4]
            temp[4] = aux
        return temp
    # [1][1]
    if index == 4:
        if where == 1:
            aux = temp[index]
            temp[index] = temp[1]
            temp[1] = aux
        if where == 2:
            aux = temp[index]
            temp[index] = temp[7]
            temp[7] = aux
        if where == 3:
            aux = temp[index]
            temp[index] = temp[3]
            temp[3] = aux
        if where == 4:
            aux = temp[index]
            temp[index] = temp[5]
            temp[5] = aux
        return temp
    # [1][2]
    if index == 5:
        if where == 1:
            aux = temp[index]
            temp[index] = temp[2]
            temp[2] = aux
        if where == 2:
            aux = temp[index]
            temp[index] = temp[8]
            temp[8] = aux
        if where == 3:
            aux = temp[index]
            temp[index] = temp[4]
            temp[4] = aux
        if where == 4:
            return None
        return temp
    # [2][0]
    if index == 6:
        if where == 1:
            aux = temp[index]
            temp[index] = temp[3]
            temp[3] = aux
        if where == 2:
            return None
        if where == 3:
            return None
        if where == 4:
            aux = temp[index]
            temp[index] = temp[7]
            temp[7] = aux
        return temp
    # [2][1]
    if index == 7:
        if where == 1:
            aux = temp[index]
            temp[index] = temp[4]
            temp[4] = aux
        if where == 2:
            return None
        if where == 3:
            aux = temp[index]
            temp[index] = temp[6]
            temp[6] = aux
        if where == 4:
            aux = temp[index]
            temp[index] = temp[8]
            temp[8] = aux
        return temp
    # [2][2]
    if index == 8:
        if where == 1:
            aux = temp[index]
            temp[index] = temp[5]
            temp[5] = aux
        if where == 2:
            return None
        if where == 3:
            aux = temp[index]
            temp[index] = temp[7]
            temp[7] = aux
        if where == 4:
            return None
        return temp
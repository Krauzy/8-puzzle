import streamlit as st

from load_css import local_css
from puzzle import solve, shuffle

local_css("style.css")

def build():
    global shuf, result, puzzle
    st.sidebar.title('8-Puzzle')
    st.sidebar.write('8-puzzle solved using heuristic')
    st.sidebar.markdown('---')
    rd = st.sidebar.radio(label='Searchs', options=['Breadth-First Search (BFS)', 'Depth-First Search (DFS)'])
    st.sidebar.markdown('---')
    side1, side2 = st.sidebar.beta_columns([0.2, 1])
    flag = False
    puzzle = shuffle([1, 2, 3, 4, 5, 6, 7, 8, 0])
    if side2.button('SHUFFLE AND SOLVE'):
        if rd == 'Breadth-First Search (BFS)':
            size, steps = solve(puzzle, 'BFS')
        else:
            size, steps = solve(puzzle)
        st.markdown(get_main(puzzle), unsafe_allow_html=True)
        flag = True

    if flag == False:
        st.markdown(get_main([1, 2, 3, 4, 5, 6, 7, 8, 0]), unsafe_allow_html=True)
    else:
        build_step(steps, size)


def get_main(arr=[]):
    array = []
    for i in range(len(arr)):
        if arr[i] == 0:
            array.append('')
        else:
            array.append(str(arr[i]))
    return "<div id='center-container'><div class='row' style='margin-top: 0px !important;'><div class='grid-box' ><span>" + array[0] + "</span></div><div class='grid-box' ><span>" + array[1] + "</span></div><div class='grid-box' ><span>" + array[2] + "</span></div></div><div class='row'><div class='grid-box' ><span>" + array[3] + "</span></div><div class='grid-box' ><span>" + array[4] + "</span></div><div class='grid-box' ><span>" + array[5] + "</span></div></div><div class='row'><div class='grid-box' ><span>" + array[6] + "</span></div><div class='grid-box' ><span>" + array[7] + "</span></div><div class='grid-box' ><span>" + array[8] + "</span></div></div></div>"


def get_step(array=[]):
    for i in range(len(array)):
        if array[i] == 0:
            array[i] = ''
        else:
            array[i] = str(array[i])
    return "<div id='little-center-container'><div class='little-row' style='margin-top: 0px !important;'><div class='little-grid-box' ><span class='little-span'>" + array[0] + "</span></div><div class='little-grid-box' ><span class='little-span'>" + array[1] + "</span></div><div class='little-grid-box' ><span class='little-span'>" + array[2] + "</span></div></div><div class='little-row'><div class='little-grid-box' ><span class='little-span'>" + array[3] + "</span></div><div class='little-grid-box' ><span class='little-span'>" + array[4] + "</span></div><div class='little-grid-box' ><span class='little-span'>" + array[5] + "</span></div></div><div class='little-row'><div class='little-grid-box' ><span class='little-span'>" + array[6] + "</span></div><div class='little-grid-box' ><span class='little-span'>" + array[7] + "</span></div><div class='little-grid-box' ><span class='little-span'>" + array[8] + "</span></div></div></div>"

def build_step(moves=[], size=0):
    st.markdown('---')
    s0, s1, s2, s3 = st.beta_columns([0.4, 1, 1, 1])
    s2.write('STEPS: ' + str(size))
    for m in moves[::-1]:
        st.write('')
        st.markdown(get_step(m), unsafe_allow_html=True)

build()
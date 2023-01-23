from random import randint
from random import choice



field = [1, 2, 3, 4, 5, 6, 7, 8, 9]


def show_field():
    global field
    for i in range(0, len(field), 3):
        print(field[i], field[i + 1], field[i + 2])

def input_pos():
    global field
    while True:
        position = int(input('Введите номер позиции на поле: '))
        if type(field[position-1]) == int and 1 <= field[position-1] <=9:
            field[position-1] = 'X'
            break
        else:
            print('Позиция уже занята')


def bot_move():
    global field
    while True:
        position = randint(0, 8)
        if type(field[position-1]) == int:
            field[position-1] = 'O'
            break


def is_victory(field):
    vin = False
    combs = [[0, 1, 2],
             [3, 4, 5],
             [6, 7, 8],
             [0, 3, 6],
             [1, 4, 7],
             [2, 5, 8],
             [0, 4, 8],
             [2, 4, 6]]
    for pos in combs:
        if field[pos[0]] == field[pos[1]] == field[pos[2]]:
            vin = True
    return vin



players = ['Пользователь', 'Компьютер']
move = choice(players)
print(f'Первым ходит - {move}')
print()
show_field()
print()

while True:

    if move == 'Пользователь':
        print()
        input_pos()
        show_field()
        print()
        move = 'Компьютер'
        if is_victory(field):
            print('Пользователь победил')
            break
    else:
        print()
        bot_move()
        show_field()
        print()
        move = 'Пользователь'
        if is_victory(field):
            print('Компьютер победил')
            break
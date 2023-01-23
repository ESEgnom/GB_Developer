import random


candys = 117


def input_candy():
    global candys
    while True:
        move = int(input('Введите конфеты: '))
        if 0 < move <= candys and move < 29:
            candys -= move
            break
        else:
            print('Столько взять нельзя')


def bot_take():
    global candys
    move = random.randint(1, 29)
    print(f'Бот взял {move}')
    candys -= move


def game():
    print(f'На столе лежит {candys} Конфет')
    players = ['Пользователь', 'Компьютер']
    move = random.choice(players)
    print(f'Превым ходит - {move}')
    while True:
        if move == 'Пользователь':
            input_candy()
            print(f'Осталось {candys}')
            move = 'Компьютер'
            if candys < 29:
                print(f'Победил {move}')
                break
        else:
            bot_take()
            print(f'Осталось {candys}')
            move = 'Пользователь'
            if candys < 29:
                print(f'Победил {move}')
                break
game()
import random as rnd
from config import *

candys = dict()
game_on = dict()
player = dict()


def gameplay_meneg(message):
    global game_on
    try:
        if game_on[message.chat.id] and 1 <= int(message.text) <= 29:
            return True
        else:
            return False
    except KeyError:
        game_on[message.chat.id] = False
        if game_on[message.chat.id] and 1 <= int(message.text) <= 29:
            return True
        else:
            return False


def game_start(message):
    global candys, game_on, player
    candys[message.chat.id] = 117
    player[message.chat.id] = rnd.choice(['Бот', message.chat.username])
    bot.send_message(message.chat.id, f'игра началась')
    bot.send_message(message.chat.id, f'На столе лежит {candys[message.chat.id]} Конфет')
    bot.send_message(message.chat.id, f'Первым ходит {player[message.chat.id]}')
    game_on[message.chat.id] = True
    if player[message.chat.id] == 'bot':
        bot_move(message)
        player[message.chat.id] = message.chat.username


def bot_move(message):
    take = rnd.randint(1, candys[message.chat.id] % 29)
    candys[message.chat.id] -= take
    bot.send_message(message.chat.id,
                     f'Бот взял {take}')
    bot.send_message(message.chat.id,
                     f'Осталось {candys[message.chat.id]}')


@bot.message_handler(func=gameplay_meneg)
def gameplay(message):
    global candys, game_on, player
    if player[message.chat.id] == message.chat.username:
        if candys[message.chat.id] > 28:
            candys[message.chat.id] -= int(message.text)
            bot.send_message(message.chat.id,
                             f'Осталось {candys[message.chat.id]}')
            if candys[message.chat.id] > 28:
                bot_move(message)
                if candys[message.chat.id] <= 28:
                    bot.send_message(message.chat.id, 'Вы победили')
                    game_on[message.chat.id] = False
            else:
                bot.send_message(message.chat.id, 'Бот выиграл')
                game_on[message.chat.id] = False
        else:
            bot.send_message(message.chat.id, 'Бот выиграл')
            game_on[message.chat.id] = False
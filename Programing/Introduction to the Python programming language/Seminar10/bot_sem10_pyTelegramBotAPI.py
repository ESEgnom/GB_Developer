from candys_game import *
from on_class import *
from config import *
from commands import *


@bot.message_handler(commands=['help'])
def show_commands(message):
    bot.send_message(message.chat.id, commands)


@bot.message_handler(commands=['game'])
def game_handle(message):
    game_start(message)


@bot.message_handler(commands=['Exchange_Rates'])
def show_exchange_rates_handle(message):
    show_exchange_rates(message)


if __name__ == '__main__':
    bot.infinity_polling()
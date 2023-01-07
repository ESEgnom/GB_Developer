import requests
from config import *


def show_exchange_rates(message):
    data_json = requests.get(url).json()
    bot.send_message(message.chat.id, f'{data_json["Valute"]["USD"]["CharCode"]}: {data_json["Valute"]["USD"]["Value"]}\n'
                                      f'{data_json["Valute"]["EUR"]["CharCode"]}: {data_json["Valute"]["EUR"]["Value"]}')
    print(data_json["Valute"]["USD"]["CharCode"], data_json["Valute"]["USD"]["Value"])
    print(data_json["Valute"]["EUR"]["CharCode"], data_json["Valute"]["EUR"]["Value"])


import json
import controller
import logger as log

path_to_db = 'db.json'


def change_phone_number():
    name = input('Введите имя или фамилию контакта, чей номер будем менять:  ')

    with open(path_to_db, 'r', encoding='Windows-1251') as file:
        data = json.load(file)
        for i in range(0, len(data)):
            if name == data[i]['Name'] or name == data[i]['Surname'] or name == data[i]['id']:
                data[i]['Phone number'] = input('Новый телефон: ')
                log.change_data_logger(data[i])

    with open(path_to_db, 'w', encoding='Windows-1251') as file:
        json.dump(data, file, indent=4)
    print('\nНомер успешно изменён!\n')
    controller.user_choice()
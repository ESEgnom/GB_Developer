import json
import controller
import logger as log


def create_json():
    json_data = []
    with open('db.json', 'w') as file:
        file.write(json.dumps(json_data, indent=2, ensure_ascii=False))
    controller.user_choice()



def add_to_json():

    name = input("Ввдите имя: ")
    surname = input('Введите Фамилию: ')
    phone = input('Введите номер телефона: ')
    e_mail = input('Введите адрес электронной почты: ')
    comment = input('Введите коментарий: ')
    data = json.load(open("db.json"))

    json_data = {
        "id": len(data) + 1,
        "Name": name,
        "Surname": surname,
        "Phone number": phone,
        "E-mail": e_mail,
        "Comment": comment,
    }
    log.add_data_logger(json_data)

    data.append(json_data)
    with open("db.json", "w") as file:
        json.dump(data, file, indent=2, ensure_ascii=False)
    print('\nНовый контакт успешно добавлен!\n')

    controller.user_choice()


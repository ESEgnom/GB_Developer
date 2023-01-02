import json
import controller


path_to_db = 'db.json'


def view_all():

    with open(path_to_db, 'r', encoding='Windows-1251') as file:
        data = json.load(file)
        for i in range(0, len(data)):
            print(data[i])
    controller.user_choice()
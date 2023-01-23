import json
import controller
import logger as log

path_to_db = 'db.json'


def search():
    search_data = input('Enter name or surname of student: ')
    with open(path_to_db, 'r', encoding='Windows-1251') as file:
        data = json.load(file)
        found_results = [data[i] for i in range(len(data)) if search_data[:5:] in data[i]['Name'] or search_data[:5:] in data[i]['Surname']]

        for i in range(0, len(found_results)):
            print(found_results[i])
    log.search_data_logger(search_data)
    controller.user_choice()

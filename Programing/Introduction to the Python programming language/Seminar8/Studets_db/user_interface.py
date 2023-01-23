import chek
from export_in_file import export_cvs


def start():
    greetings = 'Начало работы с базой'

    print(f'{greetings}\n')


def menu():
    what_to_do = 'Выберите пункт в меню:'
    new_book = '0. Создать новую книгу или очистить существующую'
    new_contact = '1. Добавить новый ученика'
    change_number = '2. Изменить номер телефона'
    change_surname = '3. Изменить фамилию'
    search = '4. Поиск ученика'
    delete_contact = '5. Удалить ученика'
    view_all_contact = '6. Показать всех учеников'
    export_to_file = '7. Экспортировать контакты в файл'
    to_exit = '8. Выход'
    print(f'{what_to_do}\n\n{new_book}\n{new_contact}\n{change_number}\n{change_surname}\n{search}\n{delete_contact}\n{view_all_contact}\n{export_to_file}\n{to_exit}')
    return chek.digit_check()
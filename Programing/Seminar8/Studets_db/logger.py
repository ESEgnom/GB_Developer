from datetime import datetime as dt

def add_data_logger(data):
    time = dt.now().strftime('%d/%m/%Y %H:%M:%S')
    with open('log.cvs', 'a') as file:
        file.write('\n\n{}\nEntry added: {}'.format(time, data))


def delete_data_logger(data):
    time = dt.now().strftime('%d/%m/%Y %H:%M:%S')
    with open('log.cvs', 'a') as file:
        file.write('\n\n{}\nEntry deleted: {}'.format(time, data))


def change_data_logger(data):
    time = dt.now().strftime('%d/%m/%Y %H:%M:%S')
    with open('log.cvs', 'a') as file:
        file.write('\n\n{}\nEntry modified: {}'.format(time, data))
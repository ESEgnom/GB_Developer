# Задайте список из вещественных чисел. Напишите программу, которая найдёт разницу между максимальным и
# минимальным значением дробной части элементов.
# *Пример:*
# - [1.1, 1.2, 3.1, 5, 10.01] => 0.19


values = [1.1, 1.2, 3.1, 10.01]


def sep_value(val: float) -> float:
    str_val = str(val).split('.')
    res = float('0.' + str_val[1])
    return res


def find_diff(list_values: list) -> float:
    val_list = [sep_value(i) for i in list_values if int(i) != float(i)]
    return max(val_list) - min(val_list)


print(f'{values} => {find_diff(values)}')

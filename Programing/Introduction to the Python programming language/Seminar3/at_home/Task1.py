# Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка,
# стоящих на нечётной позиции.
# *Пример:*
# - [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12
import random

numbers = [2, 3, 5, 9, 3]


def sum_even(num: list) -> list:
    res = [num[i] for i in range(1, len(num), 2)]
    return res

print(sum(sum_even(numbers)))







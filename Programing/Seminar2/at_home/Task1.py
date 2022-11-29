# Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
# Пример:
# - 6782 -> 23
# - 0,56 -> 11


user_number = input('Введите число ')


def summa(number):
    if float(number) < 0:
        number = float(number) * (-1)
    sum = 0

    for i in str(number):
        if i != '.':
            sum += int(i)
    return sum


print(f'{user_number} -> {summa(user_number)}')

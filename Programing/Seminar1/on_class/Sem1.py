# 1 вывести квадрат числа

# print('Введите число: ')
# a = int(input())
# print(f'квадрат числа равен: {a ** 2}\n')

# Напишите программу, которая принимает на вход два числа и проверяет,
# является ли одно число квадратом другого.
# print('Введите число')
# a = int(input())
# print('Введите число')
# b = int(input())
#
# if a == b ** 2:
#     print(f'Число {a} квадрат {b}')
# elif b == a ** 2:
#     print(f'Число {b} квадрат {a}')
# else:
#     print('не являются квадратами')
#
# # найти максимальное число из пяти чисел введенных из консоли
#
# a = int(input())
# max = a
# for i in range(4):
#     b = int(input())
#     if b > max:
#         max = b
# print(max,'\n')

a = list(map(int, input().split()))
print(a)
print(max(a))

# 1.
# Напишите программу, которая будет на вход принимать
# число N и выводить числа от - N до N
# *Примеры: *
# - 5 -> -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5
#
# 2.
# Напишите программу, которая будет принимать на вход дробь
# и показывать первую цифру дробной части числа.
# *Примеры: *
# - 6,78 -> 7
# - 5 -> нет
# - 0,34 -> 3

# 3.
# Напишите программу, которая принимает на вход число и
# проверяет, кратно ли оно 5 и 10 или 15, но не 30.

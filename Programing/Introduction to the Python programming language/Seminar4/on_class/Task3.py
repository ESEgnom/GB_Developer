# Задайте два числа. Напишите программу, которая найдёт НОК (наименьшее общее кратное) этих двух чисел.
# Пример:
# 4, 5 -> 20
# 4,6 -> 12

a, b = map(int, input().split())


def max_common_divisor(val1, val2):
    while val2 != 0:
        temp = val2
        val2 = val1 % val2
        val1 = temp
    return val1


def min_common_divisor(val1, val2):
    return (val1 * val2) / max_common_divisor(val1, val2)


nok = min_common_divisor(a, b)
print(f"Наименьшее общее кратное {a} и {b} равно {nok}")

# Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.
# Пример:
# - пусть N = 4, тогда [ 1, 2, 6, 24 ] (1, 1*2, 1*2*3, 1*2*3*4)
import math

user_number = int(input('Введите число '))
res = 1
for i in range(user_number):
    i += 1
    res *= i
    print(res, end=' ')
print()
# решение разобранное на семинаре:


mult = [math.factorial(i) for i in range(1, user_number + 1)]
print(*mult)

def multip(n: int) -> str:
    """выводит в консоль как в примере """
    str_mult = '1'
    for i in range(2, n + 1):
        str_mult += f'*{i}'
    return str(str_mult)

multip_str = [multip(i) for i in range(1, user_number + 1)]
print(multip_str)

# Найдите корни квадратного уравнения Ax² + Bx + C = 0 двумя способами:
# 1) с помощью математических формул нахождения корней квадратного уравнения (D = b^2-4ac, x1 = (-b+/- sqtr(D))/2*a)
# 2) с помощью дополнительных библиотек Python(sympy, scipy)
from math import sqrt

from sympy import *

a, b, c = list(map(int, input('Кооффициенты  квадратного уравнения: ').split()))


def math_solution(num1, num2, num3):
    d = num2 ** 2 - 4 * num1 * num3
    if d > 0:
        x1 = (-num2 + sqrt(d)) / (2 * num1)
        x2 = (-num2 - sqrt(d)) / (2 * num1)
        print(f'Корней 2: {x1} и {x2}')
    elif d == 0:
        x1 = (-num2 / 2 * num1)
        print(f'Корень 1: {x1}')
    else:
        print(f'Действительных корней нет')


def lib_solution(num1, num2, num3):
    x = var('x')
    print(solve(num1 * (x ** 2) + num2 * x + num3))


math_solution(a, b, c)

lib_solution(a, b, c)

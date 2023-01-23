# Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
# Пример:
# - A (3,6); B (2,1) -> 5,09
# - A (7,-5); B (1,-1) -> 7,21

import math

print('Введите, через пробел, координаты первой точки: ')
x1, y1 = map(int, input().split(' '))

print('Введите, через пробел, координаты второй точки: ')
x2, y2 = map(int, input().split(' '))


def find_distance(coord_x1, coord_y1, coord_x2, coord_y2):
    x = coord_x2 - coord_x1
    y = coord_y2 - coord_y1
    return math.sqrt(x ** 2 + y ** 2)


distance = find_distance(x1, y1, x2, y2)
print(f'A({x1}, {y1}); B({x2}, {y2}) -> {int(distance * 100) / 100}')

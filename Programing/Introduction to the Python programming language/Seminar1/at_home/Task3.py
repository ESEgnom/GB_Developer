# Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
# плоскости, в которой находится эта точка (или на какой оси она находится).
# Пример:
# - x=34; y=-30 -> 4
# - x=2; y=4-> 1
# - x=-34; y=-30 -> 3

def set_x_coordinates():
    print('Введите координату точки x: ')
    x = int(input())
    return x

def set_y_coordinates():
    print('Введите координаты точки у: ')
    y = int(input())
    return y

def find_quarter(point_x, point_y):
    if point_x > 0 and point_y > 0:
        print(f'x = {point_x}; y = {point_y} -> 1')
    elif point_x < 0 and point_y > 0:
        print(f'x = {point_x}; y = {point_y} -> 2')
    elif point_x < 0 and point_y < 0:
        print(f'x = {point_x}; y = {point_y} -> 3')
    elif point_x > 0 and point_y < 0:
        print(f'x = {point_x}; y = {point_y} -> 2')
    else:
        print('Координаты не должны быть равны нулю')
        find_quarter(set_x_coordinates(), set_y_coordinates())


find_quarter(set_x_coordinates(), set_y_coordinates())

a = input()
d = {'1':'x>0 y>0', '2': 'x<0 y>0', '3': 'x<0 y<0', '4': 'x>0 y<0'}
print(d[a])

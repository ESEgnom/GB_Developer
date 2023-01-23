# Даны два файла, в каждом из которых находится запись многочлена. Задача - сформировать файл, содержащий сумму многочленов.
# В file1.txt :
# 2*x**2 + 4*x + 5
# В file2.txt:
# 4*x**2 + 1*x + 4
# Результирующий файл:
# 6*x**2 + 5*x + 9
import re

pol_1 = 'poly_1.txt'
pol_2 = 'poly_2.txt'
sum_pol = 'sum_poly.txt'


def read_file(file) -> str:
    '''Получив данные из файла, возвращает их в виде строки'''

    with open(str(file), 'r') as data:
        poly = data.read()
    return poly


def convert_pol(poly: str) -> tuple:
    poly = re.sub('[*]', ' ', poly).split('+')
    print(poly)
    poly = [char.split(' ') for char in poly]
    print(poly)
    poly = [[x for x in list if x] for list in poly]
    print(poly)
    for i in poly:
        if i[0] == 'x': i.insert(0, 1)
        if i[-1] == 'x': i.append(1)
        if len(i) == 1: i.append(0)
    print(poly)
    poly = [tuple(int(x) for x in j if x != 'x') for j in poly]
    print(poly)
    return poly


print(convert_pol(read_file(pol_1)))
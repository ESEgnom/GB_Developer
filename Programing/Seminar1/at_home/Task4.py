# Напишите программу, которая по заданному номеру четверти,
# показывает диапазон возможных координат точек в этой четверти (x и y).

print('Введите номер четверти прямоугольной системы координат:')
num_quarter = input()
if num_quarter == '1':
    print(f'{num_quarter} четверть -> (x > 0; y > 0)')
elif num_quarter == '2':
    print(f'{num_quarter} четверть -> (x > 0; y < 0)')
elif num_quarter == '3':
    print(f'{num_quarter} четверть -> (x < 0; y < 0)')
elif num_quarter == '4':
    print(f'{num_quarter} четверть -> (x < 0; y > 0)')
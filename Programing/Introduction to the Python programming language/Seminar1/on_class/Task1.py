# 1.
# Напишите программу, которая будет на вход принимать
# число N и выводить числа от - N до N
# *Примеры: *
# - 5 -> -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5

print('Введите число: ')
a = int(input())

for i in range(-a, a + 1):

    print(i, end=' ')

print()

print('Введите число: ')
n = int(input())
a = []
for i in range(-n, n+1):
    a.append(i)
print(*a)

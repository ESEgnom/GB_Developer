# 2'. Для натурального n создать словарь индекс-значение, состоящий из элементов последовательности 3n + 1.
# *Пример:*
# - Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}


x = int(input())
dict = {}
for i in range(1, x + 1):
    res = 3 * i + 1
    dict[i] = res
print(dict)

print({i: 3 * i + 1 for i in range(1, x + 1)})
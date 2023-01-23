# Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент,
# второй и предпоследний и т.д.
# *Пример:*
# - [2, 3, 4, 5, 6] =>[12,15,16]      ([2*6, 3*5, 4*4]);
# - [2, 3, 5, 6] => [12,15]   ( [2*6, 3*5])

numbers = [2, 3, 5, 6]


def sum_elements(list_values: list) -> list:
    res = []
    for i in range(len(numbers) // 2):
        res.append(list_values[i] * list_values[-i - 1])
        if len(list_values) % 2 != 0:
            res.append(list_values[len(list_values) // 2] ** 2)
    return res


print(sum_elements(numbers))

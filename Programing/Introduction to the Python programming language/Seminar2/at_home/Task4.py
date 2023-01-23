# Задайте список из N элементов, заполненных числами из промежутка [-N, N]. Найдите произведение элементов на указанных
# позициях. Позиции хранятся в файле file.txt в одной строке одно число.

user_number = int(input('Введите число '))
numbers = []
for i in range(-user_number, user_number + 1):
    numbers.append(i)

print(numbers)

result = 1
f = open('file.txt', 'r')
for line in f:
    print(line, end='')
    if line == "":
        break
    result *= numbers[int(line)]
f.close()
print(result)

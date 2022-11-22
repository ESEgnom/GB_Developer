print('hello world') #вывод в консоль
a = 123             # тип данных определяется автоматически при инициализации переменной
b = 1.23
s = 'String type'
print(type(a)) # покажет какой тип данных присвоен переменной
print(type(b)) #
print(type(s))

print(a, b, s, '\n')

print(a, '-', b, '-', s)
print("1 print(a, '-', b, '-', s)\n")

print('{} - {} - {}'.format(a, b, s))
print("2 print('{} - {} - {}'.format(a, b, s)\n")

print(f'{a} - {b} - {s}')
print("print(f'{a} - {b} - {s}')\n")

f = True
print(f)
print(type(f), '\n')

list = ['1', '2', '3']
col = ['hello', 1, 2, 4.5, True]
print(list, 'список аналог массивов в python. Списки динамически изменяемая структура данных,\nне имеет ограничений по типу хранимых данных')
print(col, '\n')

print('Введите число: ')
a = input()
print('Введите число')
b = input()
print('Функция input() по умолчанию принимает строковые значения')
print(a, b, 'Переменным a, b - присвоены строковые заначения')
print('{} {}'.format(a, b))
print(f'{a} {b}')
print('a + b = ', a + b, '\n')

print('Введите число: ')
a = int(input())
print('Введите число')
b = int(input())
print('Что бы проводить какие-либо вычисления с введенными числами в консоли, их нужно привести к нужному типу данных')
print(a, b, 'Переменным a, b - присвоены заначения приведенные к int\'у')
print('{} {}'.format(a, b))
print(f'{a} {b}')
print('a + b = ', a + b, '\n')



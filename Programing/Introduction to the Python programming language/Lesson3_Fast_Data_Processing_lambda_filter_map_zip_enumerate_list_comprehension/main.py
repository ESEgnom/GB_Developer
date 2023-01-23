# ЛЯМБДА

def sum(x, y):
    return x + y


# эквивалентная запись при помощи лямбда выражений:
sum = lambda x, y: x + y

# Генератор списков

list = []

list1 = []

#######################

for i in range(1, 21):
    list.append(i)

gen_list = [i for i in range(1, 21)]
print(list)
print(gen_list)

######################

for i in range(1, 21):
    if i % 2 == 0:
        list1.append(i)

gen_list1 = [i for i in range(1, 21) if i % 2 == 0]
print(list1)
print(gen_list1)


######################

def f(x):
    '''возводит в 2 степень число полученное на вход'''
    return x ** 2


# создает список кортежей пар (число, и его куб)
sec_list = [(i, f(i)) for i in range(1, 21) if i % 2 == 0]
print(sec_list)


#################################

def read(file) -> list:
    with open(str(file), 'r') as data:
        numbers = data.read()
    list_nembers = list(map(int, numbers.split(' ')))
    return list_nembers


print(read(f))


result_list = [(i, f(i)) for i in read(f)]

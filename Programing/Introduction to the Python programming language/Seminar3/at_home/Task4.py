# Напишите программу, которая будет преобразовывать десятичное число в двоичное.
# *Пример:*
# - 45 -> 101101
# - 3 -> 11
# - 2 -> 10



number = int(input())


def show_bin(num: int):
    a = str(bin(45))
    print(a[2:])


def show_bin_math(num: int):
    bin_num = ''
    while num > 0:
        bin_num = str(num % 2) + bin_num
        num = num // 2
    print(bin_num)


show_bin(number)

show_bin_math(number)

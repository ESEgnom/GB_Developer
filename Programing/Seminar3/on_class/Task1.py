# Задайте список. Напишите программу, которая определит, присутствует ли в заданном списке строк некое число.
# ['ssss', 'sngujn556', 56] -> Yes ['56', 'sgnbsb'] -> No
str_list = ['ssss', 'sngujn556', 56]
val = 56
if val in str_list:
    print("да")
else:
    print("нет")
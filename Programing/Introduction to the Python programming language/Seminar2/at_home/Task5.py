# Реализуйте алгоритм перемешивания списка.

import random
rand_list = [random.randint(0, 10) for i in range(random.randint(10, 10))]
print(f'{rand_list} ->', end=' ')
random.shuffle(rand_list)
print(rand_list)
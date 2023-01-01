import sympy
from random import random as rnd

def create_polinom(k:int, simple: bool = True) -> str:
    '''Генерирует полином со случайными коэфициентами степени k
    simple = False вернет плином без сокращения нулевых коэфициентов'''
    polinom = ''
    for i in range(k, -1, -1):
        polinom += f''
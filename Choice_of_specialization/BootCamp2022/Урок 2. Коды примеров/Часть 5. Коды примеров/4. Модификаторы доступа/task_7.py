class Auto:
    def __init__(self):
        self.auto_name = "Mazda"
        self._auto_year = 2019
        self.__auto_model = "CX9"

    def __my_func(self):
        print(self.__auto_model)


a = Auto()
print(a.auto_name)  # -> Mazda
a.auto_name = 'Ваз'
print(a.auto_name)
print(a._auto_year)  # -> AttributeError: 'Auto' object has no attribute 'auto_model'
a._auto_year = 2020
print(a._auto_year)
print(a._Auto__auto_model)
a._Auto__auto_model = 1
print(a._Auto__auto_model)
#a.my_func()

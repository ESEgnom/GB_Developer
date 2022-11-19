class Auto:
    def on_start(self):
        info = "Автомобиль заведен"
        return info


a = Auto()
print(a.info)  # -> AttributeError: 'Auto' object has no attribute 'info'

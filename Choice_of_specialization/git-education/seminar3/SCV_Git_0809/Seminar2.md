
>>># Работа с Git ![gitlogo](https://y-skills.com/upload/iblock/bd1/bd1d0cac6e1d6d4ef8991ee298e7886e.jpeg)

>>## 1. Проверка наличия установленного Git
В терминале выполнить команду 
```
git --version
```
>>## 2. Установка Git
Зайти на сайт [Git](https://git-scm.com/downloads) скачать установочный файл и установить с настройками по умолчанию.
>>## 3. Настройка Git
При первом использовании необходимо представиться. Для этого нужно в терминале выполнить 2 команды
```
git config --global user.name «Ваше имя английскими буквами»
git config --global user.email ваша почта@example.com
```
>>## 4. Инициализация репозитория
Что бы за какой папкой нужно следить, необходимо выполнить команду:
```
git init
```
При этом нужно по средствам терминала зайти в нужную папку.
>>## 5. Отображение состояния репозитория
Что бы посмотреть текущее состояние гита выполните команду:
```
git status
```
после выполнения данной комады гит покажет на какой ветке сейчас находится, были ли внесены какие либо изменнения и в какие файлы.
>>## 6. Создание и удаление файлов и папок из репозитория
Что бы создать папку в репозитории выполните команду
```
mkdir <название папки>
```
Что бы создать файл в репозитории введите в терминале bash следующее
```
touch <название.расширение>
```
если в файле пропала необходимость его можно удалить командой
```
git rm <название.расширение>
```
>>## 7. добавление содержимого в индекс git
что бы показать гиту в каком файле произошли изменения нужно выполнить команду
```
git add <название.расширение>
```
так же можно попросить гит отслеживать все файлы разом для этого введите в терминале
```
git add .
```
или
```
git add --all
```
>>## 8. Фиксация
После завершения работы, необходимо зафиксировать изменения
```
git commit -m "<комментарий>"
```
что бы перезаписать ошибочный комментарий используй команду
```
git commit --amend -m "исправленный комментарий"
```
>>## 9. История изменений
что бы посмотреть всю историю изменений введи
```
git log
```
отображение в данном случае хоть более инормативное, но весьма громоздкое. поэтому есть более "сухой" вариант
```
git log --oneline
```
при таком варианте отобразится только первые символы хеша и комментарий каждого коммита
Данная команда поможет визуализировать структуру репозитория
```
git log --graph
```
>>## 10. Перемещение между изменениями
что бы переключаться между текущей и ранее зафиксированными версиями используют команду
```
git checkout <первые 4 символа хеша коммита>
```
что бы переключиться на последнюю актуальную версию используй
```
git checkout master
```
Что бы перейти на ветку используй команду с добавлением имени ветку на которую хочешь перейти
```
git checkout <name branch>
```
>>## 11.  Просмотр дельты
что бы просмотреть какие изменения были внесены по сравнению с последним коммитом 
```
git diff
```
>>## 12. Просмотр веток
Чтобы просмотреть какие ветки созданы используй команду
```
git branch
```
>>## 13. Создание ветки
Чтобы создать ветку нужно ввести команду с добавлением имени ветки
```
git branch <name>
```
Так же можно создать ветку и сразу перейти на нее воспользовавшись командой
```
git checkout -b <name>
```
>>## 14. Слияние веток
Чтобы слить все ветки в одну, нужно перейти на ту ветку в которую хочешь слить все остальные и выполнить команду с добавлением имени ветки которую хочешь слить.
```
git merge <name>
```
>># 15. Удаление веток
Дла того что бы удалить ненужную ветку, перейди на основную ветку,после чего используй команду с добавлением имени ветки которую хочешь удалить
```
git branch -d <name>
```
данная команда удалит ветку только в том случае если ветка слита с основной. Так же есть способ удаления ветки "в любом случае".
```
git branch -D <name>
```
>># Работа с удаленым репозиторием

>>># **_[Guthub.com](github.com)_** ![githublogo](https://wiki.proxlab.fr/images/thumb/d/d1/Github.jpg/360px-Github.jpg)

* Это сервис который позволяет хранить (и делиться)
свои репозитории удаленно.
* Для работы с удалеными репозиториями необходимо создать аккаунт на сервисе [Github](github.com)
* После регистрации необходимо создать удаленый репозиторий на этом сервисе
>>## 1. Привязка локального репозитория к удаленому
Для того что бы репозитории синхронизировались используй команду
```
git remote add <псевдоним репозитория по умолчанию origin> <ссылка на удленый репозиторий сгенерировання на github  при создании там репозитория>
 ```
Далее необходимо выполнить несколько команд которые исключат ошибки названия основной ветки
```
git branch -M main
```
таким образом мы переименовываем основную ветку локального репозитория. Основные ветки должны называться одинакого на обоих репозиториях, воизбежания конфликтов названий.
И уведомить github о изменениях на локальном репозиторияии командой 
```
git push -u origin main
```
>>## 2. Отправка изменений на удаленый репозиторий
После проведения работ на локальном репозитории, все изменения необходимо загрузить на репозиторий удаленый. Для этого используй команду:
```
git push
```
или более точный вариант, в котором указано конкретное место репозитория куда будут загружены изменения
```
git push origin main
```
>>## 3. Получение данных из удаленого репозитория
Для того что бы получить данные из удаленого репозитория испльзуй команду
```
git pull
```
в том случает если это твой репозиторий и ты с ним уже работал
```
git clone <ссылка на удаленый репозиторий>
```
если у тебя нет синхронизированной локальной версии репозитория
>># 4. Работа с открытыми репозиториями других пользователей [github](github.com)
># 4.1 Получение данных из открытого репозитория
Для начала необходимо сделать "форк" репозитория. Это можно сделать по средствам интерфейса github
После того как копия чужого репозитория появится в списке твоих репозиториев его нужно клонировать на локальный компьютер команду git clone см. выше. 
># 4.2 Работа с локальным клоном 
Далее можно вносить доработки уже локально. Важно, все изменения и доработки нужно проводить в отдельно созданной ветке.
># 4.3 Отправка данных на удаленый репозиторий
После завершения работ с локальным клоном, необходимо залить результат на github команду git push см. выше.
после чего в клонированом репозитории на github, создать pull request, для владельца клонированного репозитория. 

>># Получение справки в GIT
Полная справка
```
git help
```
так же можно посмотреть справку по каждой из команд, для этого нужно ввести название команды и добавить соотвтствующий флаг
```
git status -h
```
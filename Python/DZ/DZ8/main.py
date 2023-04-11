'''Задача №49. Решение в группах
Создать телефонный справочник с возможностью импорта и экспорта данных в формате .txt. Фамилия, имя, отчество, номер
телефона - данные, которые должны находиться в файле.
1. Программа должна выводить данные
2. Программа должна сохранять данные в текстовом файле
3. Пользователь может ввести одну из характеристик для поиска определенной записи(Например имя или фамилию человека)
4. Использование функций. Ваша программа не должна быть линейной
'''


def data_input():
    users = {}
    users['surname'] = (input("Введите Фамилию: "))
    users['phone'] = (input("Введите телефона: "))
    users['name'] = (input("Введите Имя: "))
    users['patronymic'] = (input("Введите Отчество: "))
    return users


def data_save(data_input):
    file = open("Python/DZ/DZ8/file1.txt", "a", encoding="utf-8")
    file.write("\n{")
    num = 0
    for key in data_input:
        file.write(f'"{key}": "{data_input[key]}"')
        num += 1
        if num != len(data_input):
            file.write(", ")
        else:
            file.write("}")
    file.close()


def data_read():
    file = open("Python/DZ/DZ8/file1.txt", "r", encoding="utf-8")
    onstring = file.read().split("\n")
    arr = []
    for item in onstring:
        arr.append(dict(eval(item)))
    file.close()
    return arr


def data_search(data_read):
    user = []
    input_search = input(
        "Введите Фамилию искомого абонента: ")
    for dict in data_read:
        for i in dict:
            if input_search == dict[i]:
                user.append(dict['phone'])
                user.append(dict['name'])
                user.append(dict['patronymic'])
    return user

def data_output(action):
    if action == 1:
        for i in data_search(data_read()):
            print(f'{i}')


while True:
    print("1- добавить пользователя, 2 - найти пользователя, 3 - вывести весь список, 4 - выход из программы")
    actions = int(input("Выберете действие: "))
    if actions == 1:
        data_save(data_input())
    elif actions == 2:
        for i in data_search(data_read()):
            print(f'{i}')
    elif actions == 3:
        a = data_read()
        print(a[0])
        for i in a:
            for j in i:
                print(i[j],end= "\n")
    elif actions == 4:
        print("Вы вышли из программы")
        break

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
    users['surname'] = (input("Введите Фамилию:"))
    users['phone'] = (input("Введите телефона:"))
    users['name'] = (input("Введите Имя:"))
    users['patronymic'] = (input("Введите Отчество:"))
    return users


def data_save(data_input):
    file = open("Python/DZ/DZ8/file1.txt", "a", encoding="utf-8")
    for key in data_input:
        file.write(f"{key} {data_input[key]}\n")
    file.close()


# data_save(data_input())


def data_read():
    file = open("Python/DZ/DZ8/file1.txt", "r", encoding="utf-8")
    onstring = file.read().split("\n")[:-1]
    arr = []
    array = {}
    for item in onstring:
        key = item.split(" ")[0]
        value = item.split(" ")[1]
        array[key] = value
    arr.append(array)

    print(f'{arr}\n')
    file.close()

    return arr


print(data_read())


def data_search(data_read):
    input_search = input(
        "Введите Фамилию искомого абонента: ")
    for key in data_read:
        if input_search == data_read["surname"]:
            print(
                f"{data_read['phone']}, {data_read['name']}, {data_read['patronymic']}, ")
            break
        else:
            return False


def data_output(data_search, data_read):
    file = open("Python/DZ/DZ8/file1.txt", "r", encoding="utf-8")
    file.read()
    file.close()


data_output(data_search(data_read()), data_read())

'''Задача 22: Даны два неупорядоченных набора целых чисел (может быть, с повторениями). Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
Пользователь вводит 2 числа. n - кол-во элементов первого множества. m - кол-во элементов второго множества. Затем пользователь вводит сами элементы множеств.'''

import random
n = int(input("Введите n: "))
m = int(input("Введите m: "))
list1 = []
list2 = []
list3 = []
for i in range(n):
    list1.append(random.randint(10, 20))
print(list1)
for i in range(m):
    list2.append(random.randint(10, 20))
print(list2)
a = 0
for i in range(n):
    for j in range(m):
        if list1[i] != list2[j]:
            a = list2[i]
    if a != list1[i]:
        list3.append(a)
        list3.append(list1[i])
print(list3)

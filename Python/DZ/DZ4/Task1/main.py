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
for j in list1:
    list3.append(j)
for i in list2:
    list3.append(i)
res = list(set(list3))
res.sort()
for i in res:
    print(int(i), end=', ')

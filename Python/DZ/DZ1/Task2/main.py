'''
Задача 4: Петя, Катя и Сережа делают из бумаги журавликов. Вместе они сделали S журавликов.
Сколько журавликов сделал каждый ребенок, если известно, что Петя и Сережа сделали одинаковое
количество журавликов, а Катя сделала в два раза больше журавликов, чем Петя и Сережа вместе?
'''
print("Введите общее колличество изготовленых карабликов: ")
S = int(input())
P = round((S/6))
S = round((S/6))
K = round((P+S)*2)
print(f'{S} -> {P} {K} {P}')

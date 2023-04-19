n1 = int(input("Введите искомый элемент: "))


def fib(n):
    if n in [0, 1]:
        return 1
    return fib(n - 1) + fib(n - 2)


list_1 = []
for i in range(0, n1 + 1):
    list_1.append(fib(i))
print(*list_1)

print(list_1[n1])

def is_prime(n, i=2):
    if n == 2 or i > int(n ** 0.5):
        return True
    if n % i == 0:
        return False
    return is_prime(n, i+1)


n = int(input("Введите число: "))
if is_prime(n):
    print(n, "является простым числом")
else:
    print(n, "не является простым числом")

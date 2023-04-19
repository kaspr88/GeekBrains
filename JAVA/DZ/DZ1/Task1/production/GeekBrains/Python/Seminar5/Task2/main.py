def vasya_bad_hacker(array):
    array_new = [0]*len(array)
    for i in range(len(array)):
        if array[i] == max(array):
            array_new[i] = min(array)
        else:
            array_new[i] = array[i]
    return array_new


array = [1, 3, 4, 5, 2, 5, 2, 3, 5, 4]
print(f"Первоначальные оценки {array}")
print(f"Итоговые оценки {vasya_bad_hacker(array)}")

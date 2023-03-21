'''Задача 20: * В настольной игре Скрабл (Scrabble) каждая буква имеет определенную ценность.
В случае с английским алфавитом очки распределяются так:A, E, I, O, U, L, N, S, T, R – 1 очко;
D, G – 2 очка; B, C, M, P – 3 очка; F, H, V, W, Y – 4 очка; K – 5 очков; J, X – 8 очков; Q, Z – 10 очков.
А русские буквы оцениваются так: А, В, Е, И, Н, О, Р, С, Т – 1 очко; Д, К, Л, М, П, У – 2 очка;
Б, Г, Ё, Ь, Я – 3 очка; Й, Ы – 4 очка; Ж, З, Х, Ц, Ч – 5 очков; Ш, Э, Ю – 8 очков; Ф, Щ, Ъ – 10 очков.
Напишите программу, которая вычисляет стоимость введенного пользователем слова. Будем считать,
что на вход подается только одно слово, которое содержит либо только английские, либо только русские буквы.'''
a, b, c, d, e, f, g = 1, 2, 3, 4, 5, 8, 10
valueLetter = {'A': a, 'E': a, 'I': a, 'O': a, 'U': a, 'L': a, 'N': a, 'S': a, 'T': a, 'R': a,
               'D': b, 'G': b,
               'B': c, 'C': c, 'M': c, 'P': c,
               'F': d, 'H': d, 'V': d, 'W': d, 'Y': d,
               'K': e,
               'J': f, 'X': f,
               'Q': g, 'Z': g}
word = str(input("Введите слово на английском языке: ").upper())
count = 0
for i in word:
    for j in valueLetter:
        if i == j:
            count = count + valueLetter[j]
print(f'Ценность слова: {count}')

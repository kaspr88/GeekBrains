from math import pi


def find_farthest_orbit(list_of_orbits: list) -> tuple:
    squares_iterable = map(
        lambda el: pi * el[0] * el[1] if el[0] != el[1] else None, list_of_orbits)
    squares_list = list(squares_iterable)
    max_square = max(filter(lambda el: el is not None, squares_list))
    index_of_max_square = squares_list.index(max_square)
    return list_of_orbits[index_of_max_square]


def main() -> None:
    orbits = [(6, 6), (1, 3), (2.5, 10), (7, 2), (4, 3)]
    print(*find_farthest_orbit(orbits))


if __name__ == '__main__':
    main()

def same_by(characteristic, objects) -> bool:
    result = set([characteristic(obj) for obj in objects])
    return len(result) <= 1


if __name__ == "__main__":
    values = [0, 2, 10, 6]
    if same_by(lambda x: x % 2, values):
        print('same')
    else:
        print('different')

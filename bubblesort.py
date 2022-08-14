
def print_arr(arr):
    for i in arr:
        print(i, end=", ")
    print()


def bubble_sort(arr):
        for i in range(len(arr)-1):
            for j in range(0, len(arr)-1-i):
                if arr[j] > arr[j+1]:
                    arr[j], arr[j+1] = arr[j+1], arr[j]


def main():
    arr = [2,5,1,3,6,8,9,9,4]
    print_arr(arr)
    bubble_sort(arr)
    print_arr(arr)


if __name__ == '__main__':
    main()

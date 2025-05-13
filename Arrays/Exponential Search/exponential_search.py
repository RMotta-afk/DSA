def binary_search(nums, n, lo = 0, hi = 0):
    while lo < hi:
        steps+=1
        mid = int((lo+hi)/2)
        if nums[mid] == n:
            print("step: ", steps)
            return mid
        elif nums[mid] < n:
            lo = mid+1
        else:
            hi = mid
    return -1

def exponential_search(arr, target):
    if arr[0] == target:
        return 0
    n = len(arr)
    i = 1

    while i < n and arr[i] < target:
        i *= 2
    if arr[i] == target:
        return i
    return binary_search(arr, target, i//2, min(i,n-1))

a = [1,2,3,4,5,6,7,8,9]

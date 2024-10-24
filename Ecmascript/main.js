function fibo(turn){
let start=1;
let second=0;


for(let i=1; i<=turn; i++){
    console.log(second);
    let third=start+second;
    second=start;
    start=third







}


}

fibo(5);


function swap(arr, a, b) {
    let tmp = arr[a];
    arr[a] = arr[b];
    arr[b] = tmp;
}


function partition(arr, premier, dernier, pivot) {
    swap(arr, pivot, dernier); // Move pivot to the end
    let j = premier;
    for (let i = premier; i < dernier; i++) {
        if (arr[i] <= arr[dernier]) { 
            swap(arr, i, j);
            j++;
        }
    }
    swap(arr, dernier, j); // Move pivot to correct position
    return j;
}


function quickSort(arr, premier, dernier) {
    if (premier < dernier) {
        let pivot = Math.floor(Math.random() * (dernier - premier + 1)) + premier; // Random pivot
        pivot = partition(arr, premier, dernier, pivot);
        quickSort(arr, premier, pivot - 1); // Recursively sort left part
        quickSort(arr, pivot + 1, dernier); // Recursively sort right part
    }
}

let arr=[1,55,77,99,99,4,3]

quickSort(arr, 0, arr.length-1)
console.log(arr)
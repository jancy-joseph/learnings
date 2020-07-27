var names = ["Sam","John","giraffe","jacob","Johnny"];
function GreetUser(arr){
    for(var i =0; i< arr.length;i++){
        if((arr[i][0] == 'J')||(arr[i][0] =='j')){
            console.log("Goodbye"+"J"+arr[i])
        }
        else{
            console.log("Hello"+arr[i]);
        }
    }

}
GreetUser(names);
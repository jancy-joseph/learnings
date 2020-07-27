function makemultiplier(multiplier){
    var myfunc = function(x){
        return multiplier*x;
        };
    return myfunc;
}

var multiplyby3 = makemultiplier(3);
console.log(makemultiplier);
console.log(multiplyby3(3));

function doOperation(x,operation){
    return operation(x);
}

console.log(doOperation(5,multiplyby3));

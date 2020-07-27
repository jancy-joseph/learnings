const beatles = ['Paul', 'George', 'John', 'Ringo'];
function printNames(names) {
  function actuallyPrintingNames() {
    for (let index = 0; index < names.length; index++) {
      const name = names[index];
  
      console.log(name + ' was found at index ' + index);
    }
  }
  actuallyPrintingNames();
}
printNames(beatles);


/*
You might think this change doesn't make sense, because, while name doesn't change on one iteration, 
it will certainly change on the next. That's true, but the nature of block scoping creates an 'environment'
 for that iteration only and on
 the next a whole new environment will exist for the block. Our final refactored code should look like this:
*/
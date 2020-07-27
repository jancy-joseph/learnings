const beatles = ['Paul', 'George', 'John', 'Ringo'];

function actuallyPrintingNames(names) {
    for (let index = 0; index < names.length; index++) {
      let name = names[index];
      console.log(name + ' was found at index ' + index);
    }
    console.log('name and index after loop is ' + name + ':' + index);
  }    
  
  actuallyPrintingNames(beatles);   
const beatles = ['Paul', 'George', 'John', 'Ringo'];
function actuallyPrintingNames(names) {
    let index = 0;
    let name;
    for (; index < names.length; index++) {
      name = names[index];
      console.log(name + ' was found at index ' + index);
    }
    console.log('name and index after loop is ' + name + ':' + index);
  }

actuallyPrintingNames(beatles);      
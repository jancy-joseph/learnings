// Given an array of objects representing people
// and a string representing a bad habit
// return a "santasNaughtyList" containing the first and last names of all the people
// who have the matching bad habit so that santa knows how much coal he needs.

// you can solve this iteratively or using functional programming. if you finish early, try
// implementing it both ways!
const students = [
    {
        firstName: "FN1",
        lastName: "LN1",
        habits: [
        "doesn't wash dishes",
        "falls asleep in lecture",
        "shows up early",
        ],
    },
    {
        firstName: "FN2",
        lastName: "LN2",
        habits: ["shows up late", "washes dishes", "helps peers"],
    },
    {
        firstName: "FN3",
        lastName: "LN3",
        habits: ["doesn't wash dishes", "hoards snacks", "shows up late"],
    },
    {
        firstName: "FN4",
        lastName: "LN4",
        habits: ["shows up early", "helps peers", "washes dishes"],
    },
];

function dict2Search(dictname,habitstring){

    let santasNaughtyList =[]

    for (var item of dictname){
        if (item.hasOwnProperty("habits") && item["habits"].includes(habitstring)){
            let username = item.firstName + " " +item.lastName;
            santasNaughtyList.push(username);
        }
    }
     return santasNaughtyList;
}

console.log(dict2Search(students,"doesn't wash dishes"));

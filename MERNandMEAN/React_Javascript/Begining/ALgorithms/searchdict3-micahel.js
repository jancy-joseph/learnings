//https://www.udemy.com/course/js-algorithms-and-data-structures-masterclass/learn/lecture/9816148#content
    
/*
  Given an array of ailements (illnesses), and an array of medication objects that have a nested array of treatedSymptoms
  return the medication name(s) that treats the most given symptoms
*/

const medications = [
    {
      name: "Sulforaphane",
      treatableSymptoms: [
        "dementia",
        "alzheimer's",
        "cancer",
        "inflammation",
        "neuropathy",
      ],
    },
    {
      name: "Longvida Curcumin",
      treatableSymptoms: [
        "pain",
        "inflammation",
        "depression",
        "arthritis",
        "anxiety",
      ],
    },
    {
      name: "Hericium erinaceus",
      treatableSymptoms: ["anxiety", "cognitive decline", "depression"],
    },
    {
      name: "Nicotinamide mononucleotide",
      treatableSymptoms: [
        "ageing",
        "low NAD",
        "obesity",
        "mitochondrial myopathy",
        "diabetes",
      ],
    }
]


function MedicationFinder(ailments, medications) {
        let result = [];
        let count = 0;
        let flag = false;

        medications.forEach((obj) => {
            obj.treatableSymptoms.forEach((treatment) => {
                for (let i = 0; i < ailments.length; i++) {
                    if (ailments[i] == treatment) {
                        flag = true;
                    }
                    else {
                        flag = false;
                    }
                }
                if (flag == true) {
                    if (count < obj.treatableSymptoms.length) {
                        count = obj.treatableSymptoms.length
                    if (result.length == 0) {
                        result.push(obj.name)
                    }
                    else {
                        result.pop()
                        result.push(obj.name)
                    }
                }
            }
        });
    })
    return result;
}

    console.log(MedicationFinder(["pain"],medications));

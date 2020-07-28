using System;
using Microsoft.AspNetCore.Mvc;
using Sports_ORM.Models;

namespace Sports_ORM.Controllers
{
    public class DataController : Controller
    {
        
        private static Context context;
        
        public DataController(Context DBContext)
        {
            context = DBContext;
        }

        private static string[] leagues = {
            "International Conference of Amateur Ice Hockey,Ice Hockey",
            "International Collegiate Baseball Conference,Baseball",
            "Atlantic Federation of Amateur Baseball Players,Baseball",
            "Atlantic Federation of Basketball Athletics,Basketball",
            "Atlantic Soccer Conference,Soccer",
            "International Association of Womens' Basketball Players,Basketball",
            "American Conference of Amateur Football,Football",
            "Atlantic Amateur Field Hockey League,Field Hockey",
            "Transamerican Womens' Football Athletics Conference,Football",
            "Pacific Ice Hockey Conference,Ice Hockey"
        };

        private static string[] teams = {
            "Dallas,Nets,2",
            "California,Padres,4",
            "Montreal,White Sox,3",
            "Houston,Hornets,4",
            "Alberta,Texans,7",
            "Florida,Jets,7",
            "Puerto Rico,Breakers,9",
            "South Carolina,Wolverines,2",
            "Ohio,Black Sox,2",
            "Washington,Roughriders,8",
            "Edmonton,Warriors,8",
            "Toronto,Kings,9",
            "Wisconsin,Rams,9",
            "Michigan,Timberwolves,8",
            "Oakland,Sails,10",
            "Ohio,Seahawks,4",
            "Indianapolis,Athletics,2",
            "Minneapolis,Wizards,5",
            "Phoenix,Rays,8",
            "Vancouver,Rangers,9",
            "Pittsburgh,Bruins,5",
            "Ontario,Gunslingers,9",
            "Texas,Diamondbacks,9",
            "Oregon,Colts,7",
            "Mexico City,Cave Spiders,2",
            "Raleigh,Bulls,8",
            "Montreal,Wild,7",
            "Boston,Penguins,4",
            "DC,Generals,2",
            "Cleveland,Dolphins,5",
            "Michigan,Blue Jays,6",
            "Wisconsin,Devils,8",
            "Indiana,Royals,8",
            "Calgary,Blackhawks,7",
            "Maryland,Cowboys,8",
            "Atlanta,Raptors,10",
            "Manitoba,Tiger-Cats,4",
            "Connecticut,Packers,9",
            "Vancouver,Ravens,9",
            "Wichita,Vikings,7",
            "Colorado,Capitals,9",
            "Ontario,Outlaws,3",
            "Pennsylvania,Reds,6",
            "Toronto,Pirates,5",
            "Dallas,Angels,7",
            "Pittsburgh,Maple Leafs,1",
            "Arizona,Kings,8",
            "Golden State,Raptors,5",
            "Kansas City,Spurs,8",
            "Colorado,Twins,9"
        };

        private static string[] players = {
            "Michael,Flores,8",
            "Nathan,Bryant,7",
            "Wyatt,Bell,23",
            "Lucas,Martin,22",
            "Ryan,Ross,49",
            "Abigail,Foster,29",
            "Caleb,Peterson,26",
            "Mason,Williams,11",
            "Olivia,Rodriguez,11",
            "Benjamin,Perez,42",
            "Ryan,Phillips,9",
            "Andrew,Torres,15",
            "Christopher,Torres,33",
            "Luke,Lopez,20",
            "Dylan,Rodriguez,12",
            "Luke,Bell,22",
            "Ryan,Williams,30",
            "Jaxon,Howard,37",
            "David,Flores,10",
            "Elijah,Powell,29",
            "James,Ross,38",
            "James,Griffin,21",
            "Mason,James,31",
            "Benjamin,King,24",
            "Daniel,Roberts,3",
            "Isaac,Perry,1",
            "Christopher,Baker,42",
            "Caleb,Martinez,24",
            "Lucas,Green,26",
            "Jack,Young,38",
            "Charlotte,Jones,25",
            "Ava,Collins,18",
            "Sophia,Rivera,25",
            "Isabella,Griffin,17",
            "Emma,King,46",
            "Anthony,Martinez,34",
            "Landon,Walker,3",
            "Jaxon,Gonzales,45",
            "Charlotte,Bell,49",
            "Emily,Sanchez,7",
            "Jaxon,Torres,24",
            "Liam,Watson,7",
            "Sophia,Bailey,4",
            "Benjamin,Young,26",
            "James,Smith,13",
            "Dylan,Garcia,13",
            "Anthony,Morgan,18",
            "Joshua,Cooper,23",
            "Aiden,Rivera,22",
            "Landon,Cooper,29",
            "Benjamin,Alexander,23",
            "Lucas,Hughes,3",
            "Elijah,James,25",
            "Ava,Henderson,23",
            "Alexander,Bailey,31",
            "Liam,King,3",
            "Jackson,Thomas,33",
            "Landon,Hernandez,28",
            "Joshua,Hayes,7",
            "Joshua,Henderson,36",
            "Henry,Flores,10",
            "Abigail,Davis,8",
            "Ethan,Diaz,18",
            "Levi,Rodriguez,37",
            "Lucas,Lewis,4",
            "Lucas,Allen,14",
            "Landon,Mitchell,7",
            "Wyatt,Peterson,43",
            "Jaxon,Brown,14",
            "Alexander,Wright,48",
            "Wyatt,Alexander,29",
            "Abigail,Richardson,1",
            "Jacob,Jenkins,1",
            "Mason,Rogers,33",
            "Jaxon,Anderson,19",
            "Isabella,Gonzales,43",
            "Charles,Collins,23",
            "Michael,Clark,30",
            "Landon,Gray,8",
            "Nathan,Brooks,41",
            "Gabriel,Rogers,30",
            "Levi,Miller,29",
            "Isabella,Bennett,45",
            "William,Martin,16",
            "David,Martin,36",
            "Lucas,Perry,13",
            "Wyatt,Bennett,28",
            "Charles,Campbell,5",
            "Isaac,Campbell,16",
            "Benjamin,Moore,32",
            "Joshua,Long,8",
            "Alexander,Parker,24",
            "Christopher,Powell,32",
            "Nathan,Mitchell,8",
            "Benjamin,Perry,41",
            "Levi,Lopez,34",
            "William,Anderson,19",
            "Charlotte,Ross,27",
            "Ethan,Davis,4",
            "Emma,Foster,44",
            "Abigail,Perez,18",
            "Oliver,Kelly,6",
            "Christian,Perry,44",
            "James,Ramirez,17",
            "Abigail,Smith,3",
            "Daniel,Martinez,50",
            "Jayden,Hill,31",
            "Jack,Rodriguez,18",
            "Ryan,Peterson,6",
            "Levi,Thomas,26",
            "Olivia,Griffin,10",
            "Gabriel,Roberts,31",
            "Joshua,Coleman,32",
            "Isabella,Lopez,45",
            "Samuel,Evans,1",
            "Charlotte,Harris,38",
            "Sophia,Howard,32",
            "David,Hayes,35",
            "John,Edwards,8",
            "Benjamin,James,46",
            "Henry,Martin,17",
            "Isaiah,Alexander,43",
            "Caleb,Collins,22",
            "Ryan,Gonzales,13",
            "Joseph,Roberts,24",
            "Olivia,Diaz,2",
            "Carter,Adams,32",
            "Alexander,Adams,26",
            "David,Watson,20",
            "Jaxon,Evans,49",
            "Jacob,Green,16",
            "Jackson,Bryant,49",
            "Luke,Robinson,49",
            "Ava,Rodriguez,33",
            "Abigail,Long,6",
            "Landon,James,27",
            "Oliver,Robinson,4",
            "Daniel,Davis,45",
            "Isaiah,Jackson,10",
            "Sebastian,Carter,46",
            "Levi,Kelly,16",
            "Charlotte,Brown,45",
            "Logan,King,23",
            "Andrew,Adams,17",
            "Levi,Nelson,43",
            "David,Garcia,15",
            "Michael,Cooper,47",
            "Luke,Clark,6",
            "Andrew,Hayes,10",
            "Isabella,Lewis,34",
            "Jacob,Gray,24",
            "Noah,Bennett,46",
            "Jayden,Robinson,19",
            "Alexander,Walker,10",
            "Nathan,Ward,11",
            "Christian,Perez,4",
            "Joshua,White,1",
            "Harper,James,43",
            "Jaxon,Allen,49",
            "Liam,Robinson,24",
            "Aiden,Hernandez,5",
            "Christian,Wood,27",
            "Carter,Robinson,3",
            "Joshua,Parker,12",
            "David,Sanchez,28",
            "Owen,Smith,49",
            "Ethan,Sanchez,50",
            "Noah,Brooks,50",
            "Alexander,Flores,9",
            "Harper,Hill,18",
            "Abigail,Hernandez,9",
            "Daniel,Kelly,31",
            "Charles,Campbell,13",
            "Mason,Henderson,13",
            "Nathan,Flores,6",
            "Jackson,Perry,5",
            "Noah,Taylor,24",
            "Ryan,Butler,35",
            "Andrew,Gray,19",
            "Levi,Richardson,10",
            "Levi,Lewis,47",
            "Levi,Price,43",
            "Caleb,Parker,9",
            "Levi,Howard,39",
            "Joshua,Smith,8",
            "Alexander,Cooper,48",
            "Jayden,Perez,39",
            "Jack,Phillips,8",
            "Jacob,Watson,14",
            "Isabella,Bennett,19",
            "Joseph,Parker,31",
            "Elijah,Richardson,34",
            "Emily,Jackson,38",
            "Christopher,Wood,2",
            "Olivia,Young,45",
            "Abigail,Torres,6",
            "Caleb,Johnson,26",
            "Christopher,Sanders,34",
            "Gabriel,Davis,19",
            "Daniel,Miller,10"
        };
        
        private static string[] teamplayers = {
            "1,26",
            "1,27",
            "1,33",
            "1,34",
            "1,37",
            "1,52",
            "1,71",
            "1,72",
            "1,73",
            "1,82",
            "1,115",
            "1,157",
            "2,68",
            "2,87",
            "2,107",
            "2,122",
            "2,126",
            "2,131",
            "2,137",
            "2,141",
            "2,156",
            "2,165",
            "2,182",
            "2,191",
            "2,194",
            "3,1",
            "3,25",
            "3,27",
            "3,37",
            "3,52",
            "3,56",
            "3,72",
            "3,73",
            "3,82",
            "3,105",
            "3,115",
            "3,121",
            "3,157",
            "3,163",
            "3,185",
            "3,188",
            "4,43",
            "4,65",
            "4,84",
            "4,99",
            "4,137",
            "4,141",
            "4,156",
            "4,165",
            "4,172",
            "5,4",
            "5,42",
            "5,49",
            "5,59",
            "5,88",
            "5,106",
            "5,109",
            "5,124",
            "5,125",
            "5,160",
            "5,161",
            "5,176",
            "5,187",
            "5,198",
            "6,42",
            "6,95",
            "6,98",
            "6,102",
            "6,109",
            "6,135",
            "6,142",
            "6,148",
            "6,168",
            "6,175",
            "6,196",
            "7,2",
            "7,14",
            "7,36",
            "7,40",
            "7,42",
            "7,46",
            "7,59",
            "7,67",
            "7,88",
            "7,106",
            "7,116",
            "7,123",
            "7,138",
            "7,151",
            "7,187",
            "8,1",
            "8,10",
            "8,27",
            "8,53",
            "8,62",
            "8,79",
            "8,91",
            "8,94",
            "8,119",
            "8,144",
            "8,163",
            "8,185",
            "8,188",
            "9,6",
            "9,10",
            "9,11",
            "9,34",
            "9,115",
            "9,121",
            "9,163",
            "9,169",
            "9,171",
            "9,183",
            "9,188",
            "10,5",
            "10,7",
            "10,19",
            "10,57",
            "10,61",
            "10,110",
            "10,111",
            "10,117",
            "10,139",
            "10,147",
            "10,149",
            "10,153",
            "10,154",
            "10,180",
            "10,199",
            "10,200",
            "11,5",
            "11,7",
            "11,8",
            "11,9",
            "11,44",
            "11,61",
            "11,75",
            "11,132",
            "11,134",
            "11,155",
            "11,159",
            "11,166",
            "11,181",
            "11,197",
            "12,2",
            "12,15",
            "12,30",
            "12,36",
            "12,42",
            "12,59",
            "12,102",
            "12,124",
            "12,138",
            "12,142",
            "12,151",
            "12,164",
            "13,36",
            "13,45",
            "13,46",
            "13,83",
            "13,86",
            "13,88",
            "13,95",
            "13,123",
            "13,124",
            "13,173",
            "13,174",
            "13,184",
            "13,196",
            "14,8",
            "14,29",
            "14,57",
            "14,61",
            "14,66",
            "14,69",
            "14,97",
            "14,110",
            "14,111",
            "14,113",
            "14,117",
            "14,127",
            "14,133",
            "14,139",
            "14,147",
            "14,153",
            "14,159",
            "14,179",
            "14,180",
            "14,189",
            "14,190",
            "14,199",
            "15,12",
            "15,35",
            "15,140",
            "15,146",
            "16,43",
            "16,76",
            "16,84",
            "16,89",
            "16,122",
            "16,131",
            "16,141",
            "16,156",
            "16,194",
            "17,26",
            "17,34",
            "17,82",
            "17,104",
            "17,115",
            "17,119",
            "17,121",
            "17,144",
            "17,183",
            "17,185",
            "17,188",
            "18,32",
            "18,47",
            "18,63",
            "18,70",
            "18,78",
            "18,101",
            "18,108",
            "18,170",
            "19,29",
            "19,44",
            "19,75",
            "19,97",
            "19,110",
            "19,117",
            "19,134",
            "19,139",
            "19,153",
            "19,155",
            "19,179",
            "19,190",
            "19,197",
            "19,199",
            "20,14",
            "20,42",
            "20,102",
            "20,116",
            "20,129",
            "21,22",
            "21,32",
            "21,78",
            "21,101",
            "21,103",
            "21,170",
            "22,2",
            "22,4",
            "22,15",
            "22,16",
            "22,21",
            "22,24",
            "22,28",
            "22,36",
            "22,49",
            "22,80",
            "22,109",
            "22,123",
            "22,148",
            "22,150",
            "22,151",
            "22,161",
            "22,168",
            "23,2",
            "23,3",
            "23,15",
            "23,21",
            "23,48",
            "23,49",
            "23,51",
            "23,54",
            "23,77",
            "23,88",
            "23,135",
            "23,143",
            "24,24",
            "24,28",
            "24,36",
            "24,41",
            "24,59",
            "24,92",
            "24,98",
            "24,109",
            "24,125",
            "24,129",
            "24,151",
            "24,160",
            "24,177",
            "24,195",
            "25,1",
            "25,10",
            "25,25",
            "25,26",
            "25,27",
            "25,31",
            "25,33",
            "25,53",
            "25,62",
            "25,79",
            "25,91",
            "25,115",
            "25,119",
            "25,121",
            "25,157",
            "25,183",
            "26,7",
            "26,29",
            "26,44",
            "26,75",
            "26,97",
            "26,110",
            "26,113",
            "26,118",
            "26,128",
            "26,130",
            "26,139",
            "26,153",
            "26,179",
            "26,181",
            "26,197",
            "26,199",
            "27,3",
            "27,30",
            "27,77",
            "27,83",
            "27,92",
            "27,95",
            "27,98",
            "27,106",
            "27,136",
            "27,160",
            "27,162",
            "27,167",
            "27,187",
            "28,18",
            "28,43",
            "28,55",
            "28,58",
            "28,76",
            "28,84",
            "28,87",
            "28,141",
            "28,165",
            "28,172",
            "28,194",
            "29,6",
            "29,20",
            "29,34",
            "29,50",
            "29,53",
            "29,71",
            "29,72",
            "29,82",
            "29,119",
            "29,157",
            "29,171",
            "30,17",
            "30,32",
            "30,78",
            "30,81",
            "30,101",
            "30,108",
            "30,170",
            "30,186",
            "31,18",
            "31,23",
            "31,43",
            "31,55",
            "31,107",
            "31,112",
            "31,141",
            "31,156",
            "31,165",
            "31,172",
            "31,191",
            "32,5",
            "32,13",
            "32,44",
            "32,90",
            "32,93",
            "32,111",
            "32,113",
            "32,117",
            "32,118",
            "32,127",
            "32,128",
            "32,149",
            "32,159",
            "32,180",
            "33,13",
            "33,57",
            "33,74",
            "33,110",
            "33,113",
            "33,118",
            "33,132",
            "33,134",
            "33,139",
            "33,166",
            "33,179",
            "33,181",
            "33,189",
            "34,24",
            "34,36",
            "34,77",
            "34,95",
            "34,96",
            "34,116",
            "34,143",
            "34,150",
            "34,160",
            "34,192",
            "34,198",
            "35,19",
            "35,29",
            "35,69",
            "35,97",
            "35,118",
            "35,132",
            "35,147",
            "35,149",
            "35,159",
            "35,166",
            "35,178",
            "35,180",
            "35,197",
            "36,12",
            "36,60",
            "36,85",
            "36,140",
            "36,146",
            "36,152",
            "37,18",
            "37,43",
            "37,55",
            "37,64",
            "37,84",
            "37,126",
            "37,131",
            "37,156",
            "37,158",
            "37,172",
            "38,2",
            "38,4",
            "38,21",
            "38,30",
            "38,45",
            "38,48",
            "38,114",
            "38,116",
            "38,142",
            "38,193",
            "38,195",
            "39,38",
            "39,41",
            "39,45",
            "39,92",
            "39,136",
            "39,142",
            "39,160",
            "39,184",
            "39,187",
            "39,195",
            "40,15",
            "40,49",
            "40,54",
            "40,80",
            "40,106",
            "40,109",
            "40,116",
            "40,168",
            "40,184",
            "40,198",
            "41,24",
            "41,77",
            "41,80",
            "41,95",
            "41,102",
            "41,114",
            "41,124",
            "41,129",
            "41,175",
            "41,187",
            "41,198",
            "42,6",
            "42,10",
            "42,20",
            "42,25",
            "42,26",
            "42,27",
            "42,34",
            "42,52",
            "42,53",
            "42,56",
            "42,72",
            "42,91",
            "42,115",
            "42,144",
            "42,183",
            "43,18",
            "43,68",
            "43,76",
            "43,84",
            "43,122",
            "43,126",
            "43,145",
            "43,158",
            "43,172",
            "43,182",
            "43,191",
            "44,32",
            "44,47",
            "44,70",
            "44,78",
            "44,100",
            "44,103",
            "44,108",
            "44,186",
            "45,3",
            "45,30",
            "45,38",
            "45,40",
            "45,59",
            "45,80",
            "45,83",
            "45,98",
            "45,114",
            "45,138",
            "45,142",
            "45,195",
            "45,198",
            "46,12",
            "46,35",
            "46,60",
            "46,120",
            "46,140",
            "46,146",
            "46,152",
            "47,7",
            "47,13",
            "47,57",
            "47,66",
            "47,128",
            "47,147",
            "47,149",
            "47,181",
            "47,190",
            "47,197",
            "48,32",
            "48,63",
            "48,70",
            "48,78",
            "48,101",
            "48,103",
            "48,186",
            "49,5",
            "49,7",
            "49,13",
            "49,39",
            "49,93",
            "49,113",
            "49,130",
            "49,132",
            "49,133",
            "49,139",
            "49,153",
            "49,159",
            "49,166",
            "49,189",
            "49,190",
            "50,3",
            "50,41",
            "50,42",
            "50,46",
            "50,106",
            "50,109",
            "50,123",
            "50,129",
            "50,167",
            "50,168",
            "50,184"
        };

        // [HttpGet("getallthedata")]
        public IActionResult GetData()
        {
            // Create all of the Leagues
            foreach(string l in leagues)
            {
                string[] info = l.Split(",");
                context.Leagues.Add(
                    new League() {
                        Name=info[0],
                        Sport=info[1]
                    }
                );
            }
            context.SaveChanges();
            // Create all of the Teams
            foreach(string t in teams)
            {
                string[] info = t.Split(",");
                context.Teams.Add(
                    new Team() {
                        Location=info[0],
                        TeamName=info[1],
                        LeagueId=Int32.Parse(info[2])
                    }
                );
            }
            context.SaveChanges();
            // Create all of the Players
            foreach(string p in players)
            {
                string[] info = p.Split(",");
                context.Players.Add(
                    new Player() {
                        FirstName=info[0],
                        LastName=info[1],
                        TeamId=Int32.Parse(info[2])
                    }
                );
            }
            context.SaveChanges();
            // Create the Player - Team relationships
            foreach(string t in teamplayers)
            {
                string[] info = t.Split(",");
                context.PlayerTeams.Add(
                    new PlayerTeam() {
                        TeamId=Int32.Parse(info[0]),
                        PlayerId=Int32.Parse(info[1])
                    }
                );
            }
            context.SaveChanges();
            return Redirect("/");
        }
    }
}
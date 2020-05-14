class Ninja
{
    // constructor(name, health)
    // {
    //      this.name = name;
    //      this.health = health;
    //      this.speed = 3;
    //      this.strength= 3;
    // }
    constructor(name,health,speed=3,strength=3)
    {
        this.name = name;
        this.health = health;
        this.speed = speed;
        this.strength= strength;

    }
    sayName()
    {
        console.log(this.name);
    }

    showStats()
    {
        console.log(`Name: ${this.name} Health: ${this.health} Speed: ${this.speed}Strength: ${this.strength}`)
    }

    drinkSake()
    {
        this.health+=10;
    }
}

class Sensei extends Ninja{
    constructor(name)
    {
        super(name,200,10,10);
        this.wisdom = 10;
    }

    speakWisdom()
    {
        super.drinkSake();
        console.log("If you want a rainbow,you gotta put up with the rain");
    }

}

// const n1 = new Ninja("suraj", 100);
// n1.sayName();
// n1.showStats();
// n1.drinkSake();
// n1.showStats();

const s1 = new Sensei("Sensei2");
s1.showStats();
s1.speakWisdom();
s1.showStats();



class Card{
    constructor (name,cost)
    {
        this.name = name;
        this.cost = cost;
    }
}

class Unit extends Card{
    constructor(name,cost,power,res)
    {
        super(name,cost);
        this.power = power;
        this.res = res;

    }

    attack(target)
    {

    }
}

class Effect extends Card{
    cosntructor(stat,text)
    {
        super()
    }
    play( target ) {
        if( target instanceof Unit ) {
            // implement card text here
            target.res -=stat;
            target.power +-stat;
        } else {
            throw new Error( "Target must be a unit!" );
        }
    }
}
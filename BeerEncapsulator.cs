namespace encapsulation;
class BeerEncapsulator
{
    private double _availableBeerVolume;//centilitres
    private int _availableBottles;
    private int _availableCapsules;
    private int _maxSize = 33;
    private int _producedBottles;

    public double getBeerVolume(){
        return this._availableBeerVolume;
    }
    public void setBeerVolume(double availableBeerVolume){
        this._availableBeerVolume = availableBeerVolume;
        if(availableBeerVolume < 0){
            throw new ArgumentException("The amount of beer can't be less than 0");
        }
    }

    public int getBottles(){
        return this._availableBottles;
    }
    public void setBottles(int bottles){
        this._availableBottles = bottles;
        if(bottles < 0){
            throw new ArgumentException("The number of bottles can't be less than 0");
        }
    }

    public int getCapsules(){
        return this._availableCapsules;
    }
    public void setCapsules(int capsules){
        this._availableCapsules = capsules;
        if(capsules < 0){
            throw new ArgumentException("The number of capsules can't be less than 0");
        }
    }

    public double addBeer(double beer){
        this._availableBeerVolume = this._availableBeerVolume + beer;
        return this._availableBeerVolume;
    }

    public int ProduceEncapsulatedBeerBottles(int nB){
        for(int i = 0; i < nB; i++){
            if(this._availableBeerVolume >= 33 && this._availableBottles >= 1 && this._availableCapsules >= 1){
                this._producedBottles = this._producedBottles + 1;
            }
            else{
                if(this._availableBeerVolume < 33){
                    double addBeer = 33 - this._availableBeerVolume;
                    Console.WriteLine("Add at least " + addBeer + " centiliters of beer");
                }
                else if(this._availableBottles < 1){
                    Console.WriteLine("Add at least 1 bottle");
                }
                else if(this._availableCapsules < 1){
                    Console.WriteLine("Add at least 1 capsule");
                }
                return 0;
            }
            this._availableBeerVolume = this._availableBeerVolume - 33;
            this._availableBottles = this._availableBottles - 1;
            this._availableCapsules = this._availableCapsules - 1;
        }      
        return this._producedBottles;  
    }

    static void Main(string[] args)
    {
        BeerEncapsulator b = new BeerEncapsulator();
        Console.Clear();
        Console.WriteLine("Welcome to Encapsulator!\nPlease enter available Beer Volume in Centiliters: ");
        string beerVolume = Console.ReadLine();
        b.setBeerVolume(Convert.ToDouble(beerVolume));
        Console.WriteLine("Now, please enter the number of available bottles: ");
        string bottles = Console.ReadLine();
        b.setBottles(Convert.ToInt32(bottles));
        Console.WriteLine("Now, please enter the number of available capsules: ");
        string capsules = Console.ReadLine();
        b.setCapsules(Convert.ToInt32(capsules));

        Console.WriteLine("Thanks, how much bottles need to be encapsulated ??");
        string BottlesToEncapsulate = Console.ReadLine();
        b.ProduceEncapsulatedBeerBottles(Convert.ToInt32(BottlesToEncapsulate));

        Console.WriteLine("Amount produced: " + b._producedBottles);
        /*Console.Clear();
        Console.WriteLine("Welcome to Encapsulator!");
        var val = Console.ReadKey();
        if(val.Key = ConsoleKey.DownArrow){

        }
        else if(val.Key = ConsoleKey.UpArrow){

        } 
        else if(val.Key = ConsoleKey.Enter){

        }
        Console.ReadLine();*/
    }
}

class Lasagna
{

    int expectedOvenTimeInMinutes = 40;
    public int ExpectedMinutesInOven()
    {
        return expectedOvenTimeInMinutes;
    }
    
   
       public int RemainingMinutesInOven(int actualOvenTimeInMinutes)
    {
        return ExpectedMinutesInOven() - actualOvenTimeInMinutes;
    }
   


 public int PreparationTimeInMinutes(int numberOfLayers )
 {
     return numberOfLayers * 2;
 }
   
 public int ElapsedTimeInMinutes(int numberOfLayers, int actualOvenTimeInMinutes)
{
    return PreparationTimeInMinutes(numberOfLayers) + actualOvenTimeInMinutes;
}


}

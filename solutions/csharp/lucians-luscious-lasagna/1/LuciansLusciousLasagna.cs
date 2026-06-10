class Lasagna
{

    int expectMins = 40;
    public int ExpectedMinutesInOven()
    {
        return expectMins;
    }
    
   
       public int RemainingMinutesInOven(int remainingMins)
    {
        return expectMins - remainingMins;
    }
   

    int numOfLayer = 2;
 public int PreparationTimeInMinutes(int numOfLayer )
 {
     return numOfLayer * 2;
 }
   
 public int ElapsedTimeInMinutes(int numOfLayer, int numOfMins)
{
    return PreparationTimeInMinutes(numOfLayer) + numOfMins;
}


}

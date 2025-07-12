class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
        public int ExpectedMinutesInOven() => 40;
    

    // TODO: define the 'RemainingMinutesInOven()' method
         public int RemainingMinutesInOven(int actualMin) => ExpectedMinutesInOven() - actualMin;
         

    // TODO: define the 'PreparationTimeInMinutes()' method
        public int PreparationTimeInMinutes(int numLayers) => 2 * numLayers;
        

    // TODO: define the 'ElapsedTimeInMinutes()' method
        public int ElapsedTimeInMinutes(int numLayers, int minInOven) => PreparationTimeInMinutes(numLayers) + minInOven;
       
}

class Settings{
    public int wordLength = 5;
    public int numOfAttempts = 6;

    //Show the settings screen
    public void Show(){
        Console.WriteLine($"\n--Settings-- \n\n1. Word length: {wordLength} \n2. Number of attemps: {numOfAttempts} \n\n Type the corresponding number to change a setting");

        
    }

}
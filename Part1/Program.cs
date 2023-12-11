class Program{
    static void Main(string[] args){
        NaturalNumbers(1,100);
    }
    static void NaturalNumbers(int startNumber, int endNumber){
        if (startNumber > endNumber){
            return;
        }
        Console.WriteLine(startNumber);
        NaturalNumbers(startNumber+1, endNumber);
    }
}
class Program{
    static void Main(string[] args){
        ReverseArrayPrint(new int[] {1,52,16,21,26,272,88,3});
    }
    static void ReverseArrayPrint(int[] array, int index = 1){
        if (index > array.Count()){
            return;
        }
        Console.WriteLine(array[array.Count() - index]);
        ReverseArrayPrint(array, index + 1);
    }
}
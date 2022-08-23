namespace AlgorithmProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchWord binarySearchWord = new BinarySearchWord();
            binarySearchWord.createSorted();

            InsertionSort insertionSort = new InsertionSort();
            insertionSort.Insertionsort1();

            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Bubblesort1();

            MergeSort mergeSort = new MergeSort();
            mergeSort.MergeArray();

            AnagramDetection anagramDetection = new AnagramDetection();
            anagramDetection.anaGramDetection();

            PalinDrome palinDrome = new PalinDrome();
            palinDrome.PalinDrome1();

            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.PrimeNumber1();

            BinarySearch binarySearch = new BinarySearch();
            binarySearch.binarySearch1();
        }
    }
}

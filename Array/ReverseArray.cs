class HelloWorld {
    static void Main() {
        int[] input = new int[] {1,2,3,4,5};
        
        for(var i = input.Length - 1 ; i >= 0 ; i--) {
            Console.Write(input[i] + " ");
        }
    }
}

//new array that largest numbers will go into
int[] newArray = { 0,0,0 };
//array sorting funciton
void arrSort(int[][] arr)
{
    //loop through array
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            //int to hold value of array value
            int largest = arr[i][0];
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                //if array index is bigger than "largest" reassign largest value to the index
                if (arr[i][j] > largest)
                {
                    largest = arr[i][j];
                    //set array index to largest value
                    newArray[i] = largest;
                }
            }
        }
    //join newArray values into string seperarated by comma
    Console.WriteLine(String.Join(",", newArray.Cast<int>()));
}
//setup of jagged array
int[][] array = new int[2][];
array[0] = new int[] { 4, 2, 7, 1 };
array[1] = new int[] { 20, 70, 40, 90 };
array[2] = new int[] { 1, 2, 0 };
arrSort(array);

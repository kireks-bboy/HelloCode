int Max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg1 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result;
}

//             0 1 2 3 4 5 6 7   8     9
int[] array = { 12, 25, 3, 41, 57777, 611, 7, 82, 29 };
// array [0] = 13;
// Console.WriteLine(array[3]);

int result = Max(
  Max(array[0], array[1], array[2]),
  Max(array[3], array[4], array[5]),
  Max(array[6], array[7], array[8])
);
Console.WriteLine(result);



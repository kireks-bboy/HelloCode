// // Вид 1
// // void Method1()
// // {
// //   System.Console.WriteLine("Автор Денисевич Кирилл");
// // }
// // Method1();




// // Вид 2
// void Method2(string msg)
// {
//   System.Console.WriteLine(msg);
// }
// // Method2(msg:"Текст сообщения");


// void Method21(string msg, int count)
// {
//   int i = 0;
//   while (i < count)
//   {
//     System.Console.WriteLine(msg);
//     i++;
//   }
// }
// Method21(msg: "Текст", 4);



// // Вид 3
// int Method3()
// {
//   return DateTime.Now.Year;
// }
// int year = Method3();
// // System.Console.WriteLine(year);


// // Вид 4

// // string Method4(int count, string text)
// // {
// //   int i = 0;
// //   string result = String.Empty;

// //   while (i < count)
// //   {
// //     result = result + text;
// //     i++;
// //   }
// //   return result;
// // }


// // for
// string Method4(int count, string text)
// {
//   string result = String.Empty;
// for ( int i = 0; i < count; i++)
//   {
//     result = result + text;
//   }
//   return result;
// }
// string res = Method4(10, "r");
// // System.Console.WriteLine(res);



// // Цикл в цикле
// // for ( int i = 2; i <= 10; i++)
// // {
// //   for (int j = 2; j <= 10; j++)
// //   {
// // System.Console.WriteLine($"{i} x {j} = {i*j}");
// //   }
// //   System.Console.WriteLine();
// // }



// // Следующим пунктом предлагаю потренировать использование методов и цикла for. Здесь
// // самым классическим примером будут являться программы обработки текста.
// // Итак, задача. Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
// // заменить большими «К», а большие «С» заменить на маленькие «с».

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             012
// // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//   string result = String.Empty;

//   int length = text.Length;
//   for (int i = 0; i < length; i++)
//   {
//     if(text[i] == oldValue) result = result + $"{newValue}";
//     else result = result + $"{text[i]}";
//   }

//   return result;
// }

// string newText = Replace(text, ' ',  '|');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replace(newText, 'k',  'K');
// System.Console.WriteLine(newText);


// // Упорядочить массив
//  int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
// int count = array.Length;

// for (int i = 0; i < count; i++)
// {
//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine();
// }

// PrintArray(arr);

// void SelectionSort(int[] array)
// {
// for (int i = 0; i < array.Length - 1 ; i++)
// {
// int minPosition = i;

//     for (int j = i + 1; j < array.Lenght; j++)
//     {
//         if(array[j] < array[minPosition]) minPosition = j;
//     }
//     int temporary = array[i];
//     array[i] = array[minPosition];
//     array[minPosition] = temporary;
// }
// }
// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);



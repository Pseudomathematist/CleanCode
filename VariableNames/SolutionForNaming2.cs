6.1
avarageValue - averageNeighborValue (average_neighbor_value)
// среднее арифметическое соседних элементов массива, а не какого-то множества значений
amount - paymentAmountInCents (payment_amount_in_Cents)
// сумма платежа в центах, переменная в функции округления цены до целых долларов
userCredentials - userPassword (user_password)
// пароль пользователя, а не какие-то его общие данные
array - sortedArray (sorted_array)
// упорядоченный массив, а не какой-то массив
createdButtonWithText - createdButton (created_button)
// Созданная кнопка вообще, а не конкрено созданная кнопка с текстом
6.2
Назвать структуру stableSortedStructure
Назвать переменую HashIndex
Назвать пространство имен HighOrdedFuncions
Назвать функцию EvaluteLikeFiniteAutomata
6.3
public class Node
   {
     public int value;
     public Node next, prev;
    ...
   }
// Аргументы ноды двухсвязного списка

public static bool IsTrueBracketsSeq(string str)
   {
       Stack<char> leftBrackets = new Stack<char>();
       foreach (char i in str)
       {
         if (i == '(') leftBrackets.Push(i);
         else if (i == ')') 
         { 
           if (leftBrackets.Size() == 0) return false;
           leftBrackets.Pop();
         }
       }
       return leftBrackets.Size() == 0;
   }
// Переменная в методе IsTrueBracketsSeq

public static bool IsPalindrome(string str)
    {
       Deque<char> strDeque = new Deque<char>();
       foreach (var i in str) strDeque.AddFront(i);
       for (int i = strDeque.Size(); i > 1; --i) 
         if (strDeque.RemoveFront() != strDeque.RemoveTail()) return false;
       return true;
    }
// Переменная метода IsPalindrome

6.4
avg - averageNeighborValue (average_neighbor_value)
// среднее арифметическое соседних элементов массива
vec1 - firstVector (first_vector)
// Первый параметр функции, один из двух vector'ов
temp - substrBetweenPoints (substr_between_points)
// Подстрока, ограниченная двумя точками
i - indexOfSubstrStart (index_of_substr_start)
// Индекс начала подстроки
number - twoNumbers (two_numbers)
// массив содержащий ровно два числа
  

  

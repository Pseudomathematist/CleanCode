6.1
6.2
6.3
public class Node
   {
     public int value;
     public Node next, prev;
    ...
   }
// Аргументы ноды двухсвязного списка

public class LinkedList2
   {
     public Node head;
     public Node tail;
     private int count;
     ...
      
     public void InsertAfter(Node _nodeAfter, Node _nodeToInsert)
     {
       _nodeToInsert.next = _nodeAfter.next;
       _nodeToInsert.prev = _nodeAfter;
       _nodeToInsert.next.prev = _nodeToInsert;
       _nodeAfter.next = _nodeToInsert;
       ++count;
     }
      ...
    }
// Переменные в методе InsertAfter


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
  

  

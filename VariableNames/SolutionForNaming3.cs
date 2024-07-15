7.1. 
magicAllowed - isMagicEnabled (is_magic_enabled)
eventTriggered - isEventActive
inCombat - isInCombat
notHasItem - hasItem
notEnoughSkillPoints - areSkillPointsEnough
7.2.
public bool IsTree(graph inputGraph)
  {
      bool find = (FindCycleIn(inputGraph) != null);
      bool isInputConnective = IsGraphConnective(inputGraph);
      return !find && isInputConnective;
  }

//

static bool CheckForMatchingProducts(List<Product> products, string targetName)
{
    bool productFound = false; 
    int foundProductCount = 0; 

    foreach (Product product in products)
    {
        if (product.Name == targetName)
        {
            productFound = true; 
            foundProductCount++; 
        }
    }

    if (foundProductCount > 1) 
    {
        Console.WriteLine($"Найдено {foundProductCount} продуктов с именем {targetName}"); 
    }

    return productFound; 
}


7.3.
bool FindElementInMatrix(int[,] matrix, int targetElement)
{
    for (int row = 0; row < matrix.GetLength(0); row++) 
    {
        for (int col = 0; col < matrix.GetLength(1); col++) 
        {
            if (matrix[row, col] == targetElement)
            {
                return true;
            }
        }
    }

    return false;
}

7.4. 

7.5.
temp - bufferOfDigits (buffer_of_digits)

public static int PostfixOperations(string str)
      {
          var operationsDictionary = new Dictionary<string, Operation>
          {
              {"+", (x, y) => x + y},
              {"*", (x, y) => x * y},
              {"-", (x, y) => x - y},
              {"/", (x, y) => x / y}
          };
          Stack<string> buffer = new Stack<string>();
          Stack<int> result = new Stack<int>();
          string temp = "";
          char[] operations = {'+', '*', '-', '/', '='};
          for (int i = str.Length - 1; i >= 0; --i)
          {
            if (Char.IsDigit(str[i]))
            {
                temp = str[i] + temp;
                if (i == 0) buffer.Push(temp);
            }
            else if (str[i] == ' ' && temp != "")
            {
                buffer.Push(temp);
                temp = "";
            }
            else foreach (char j in operations)
            {
                if (str[i] == j)
                {
                    buffer.Push(str[i].ToString());
                    break;
                }
            }
          }
          for (int i = buffer.Size(); i > 0; --i)
          {
              temp = buffer.Pop();
              int number;
              if (int.TryParse(temp, out number)) result.Push(number);
              else if (temp == "=") return result.Pop();
              else
              {
                  int numberSecond = result.Pop(), numberFirst = result.Pop();
                  result.Push(operationsDictionary[temp](numberFirst, numberSecond));
              }
          }
          return default(int);
           
	    }


  
Можно убрать отдельную переменную node
public Node Find(int _value)
     {
       Node node = head;
       while (node != null)
       {
         if (node.value == _value) return node;
         node = node.next;
       }
       return null;
     }

Вот так
public Node Find(int _value)
     {
       for(Node node = head; node != null; node = node.next)
       {
         if (node.value == _value) return node;
       }
       return null;
     }

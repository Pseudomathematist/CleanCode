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

7.5

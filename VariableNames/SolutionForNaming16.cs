Улучшение кода по типу 1
////////////////////////
// Проверка на collision
if (Physics.CheckSphere(transform.position, 1f))
{
    // Применить действие
    ApplyAction();
}

// Применить действие, если объект сталкивается с другим объектом в радиусе 1 метра
if (Physics.CheckSphere(transform.position, 1f))
{
    ApplyAction();
}



////////////////////////
Улучшение кода по типу 2


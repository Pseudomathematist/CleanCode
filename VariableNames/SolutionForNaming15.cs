// Проверяет, находится ли игрок в зоне действия предмета
if (player.position.x >= item.position.x - item.range && 
    player.position.x <= item.position.x + item.range &&
    player.position.y >= item.position.y - item.range &&
    player.position.y <= item.position.y + item.range) {
    // Взаимодействие с предметом
}
//Улучшение
if (player.isInRangeOf(item)) {
    // Взаимодействие с предметом
}


// Устанавливает здоровье игрока на начальное значение
player.health = player.maxHealth;
//Улучшение 
player.ResetHealth();



// Исходный код (с комментарием)
// Применяет эффект "Огненный шар" к объекту
entity.ApplyEffect(FireballEffect); 
//Улучшение 
entity.Ignite();


// Класс для записи данных в текстовый файл
public class TextFileWriter
{
    // Метод для записи данных в файл
    public void WriteToFile(string filePath, string data)
    {
        // Открытие файла для записи
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            // Запись данных в файл
            writer.Write(data);
        }
    }
}
//Улучшение
public class TextFileWriter
{
    public void WriteToFile(string filePath, string data)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.Write(data);
        }
    }
}

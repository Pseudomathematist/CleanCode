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


public class Character
{
    // Метод для атаки персонажа
    public void Attack(Character target)
    {
        // Проверяем, жив ли целевой персонаж
        if (target.IsAlive)
        {
            // Вычисляем урон
            int damage = CalculateDamage();

            // Наносим урон целевому персонажу
            target.TakeDamage(damage);

            // Выводим сообщение об атаке
            Console.WriteLine($"{this.Name} атакует {target.Name} и наносит {damage} урона!");
        }
        else
        {
            // Выводим сообщение о том, что цель уже мертва
            Console.WriteLine($"{target.Name} уже мертв!");
        }
    }

    // Метод для вычисления урона
    private int CalculateDamage()
    {
        // Логика вычисления урона
        return 10; // Простое значение для примера
    }
}



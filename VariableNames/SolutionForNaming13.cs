inventory = ["Меч", "Щит", "Зелье исцеления"]
//
inventory = {"Меч": 1, "Щит": 1, "Зелье исцеления": 3}
// Использовать словарь вместо массива для хранения предметов в инвентаре.

int[] timers = new int[5]; // 5 таймеров
//
Dictionary<string, float> timers = new Dictionary<string, float>() 
{
    { "AttackCooldown", 0f },
    { "PowerUpDuration", 10f }
};
// Использование словаря для хранения таймеров с названиями


int[] eventScore = { 10, 5, 20, 3 }; 
//
Dictionary<string, object> eventScore = new Dictionary<string, object>()
{
    { "LevelUP", 10 },
    { "Coin", 5 },
    { "Kill", 20 },
    { "CommonItem", 3 }
};
// Использование словаря для хранения кол-ва очков за действие.

string[] chatMessages = new string[50]; 
//
Queue<string> chatMessages = new Queue<string>();
chatMessages.Enqueue("Привет!");
chatMessages.Enqueue("Как дела?");
// Использование очереди (Queue) для хранения сообщений чата


// Создание HashSet для хранения имен гостей
HashSet<string> guests = new HashSet<string>();

guests.Add("Иван");
guests.Add("Мария");
guests.Add("Иван");

if (!guests.Add("Иван"))
{
    Console.WriteLine("Гость 'Иван' уже на вечеринке.");
}

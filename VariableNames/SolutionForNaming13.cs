inventory = ["Меч", "Щит", "Зелье исцеления"]
inventory = {"Меч": 1, "Щит": 1, "Зелье исцеления": 3}
// Использовать словарь вместо массива для хранения предметов в инвентаре.
int[] timers = new int[5]; // 5 таймеров


Dictionary<string, float> timers = new Dictionary<string, float>() 
{
    { "AttackCooldown", 0f },
    { "PowerUpDuration", 10f }
};
// Использование словаря для хранения таймеров с названиями

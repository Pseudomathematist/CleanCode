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



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

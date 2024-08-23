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


// Создание эффекта взрыва
GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
// Уничтожение эффекта взрыва
Destroy(explosion, 2f);

// Создание эффекта взрыва на текущем положении объекта и уничтожение его через 2 секунды
GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
Destroy(explosion, 2f);
////////////////////////
Улучшение кода по типу 3
////////////////////////
// Движение персонажа вправо
if (Input.GetKey(KeyCode.D))
{
    transform.position += Vector3.right * speed * Time.deltaTime;
}
// Движение персонажа влево
if (Input.GetKey(KeyCode.A))
{
    transform.position += Vector3.left * speed * Time.deltaTime;
}


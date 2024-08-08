Внес глобальную переменую health в поле класса Character.
Глобальный список объектов gameObjects был перенесен в поле класса Game
Глобальная переменная eventTriggered была перенесена в поле класса EventManager
Глобальная переменная counter была заменена локальной переменной в каждой функции
Переменная spawnEnemyCount, которая раньше была полем класса Game, стала локальной переменной в методе SpawnEnemy
Сделал публичное поле speed обьекта GameObject приватным и обращаюсь к нему с помощь методов SetSpeed и GetSpeed
Переменная isActive теперь приватная, и доступ к ней осуществляется через методы Activate, Deactivate, IsActive. Это позволяет контролировать, как активируется и деактивируется объект.
Поле position стало приватным, доступ к нему только через Move и GetPosition. Это позволяет контролировать перемещение объекта и добавить проверки, например, чтобы он не выходил за границы.
Переменная shotsFired, которая раньше была полем класса Weapon, стала локальной переменной в методе Fire, что делает ее доступной только в контексте этого метода.
Сделал discount поля класса Order локальной переменной в GetTotalPrice.
Локализовал все операции, связанные с расчетом скидки, в одну функцию. Теперь меньше кода между обращениями к price и discountPercentage.
Создал функцию, которая отвечает только за чтение данных из файла. Теперь data локальна внутри этой функции.
Выделил логику сохранения пользователя в отдельную функцию. Теперь name и email локальны внутри SaveUser.
Выделил проверку возраста в отдельную функцию. Теперь age локальна.
currentPrice из поля класса была удалена, добавлен метод ApplyTax который принимает цену продукта и ставку налога в качестве аргументов.

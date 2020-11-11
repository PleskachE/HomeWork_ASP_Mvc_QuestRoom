# HomeWork_ASP_Mvc_QuestRoom

В серии домашних заданий по ASP.NET MVC необходимо разработать сайт – каталог квест-комнат.

Task 1:

В данном домашнем задании нужно разработать модель для
описания квест-комнаты.
О квест-комнате нужно хранить следующую информацию:
- название;
- описание;
- время прохождения;
- минимальное и максимальное количество игроков;
- минимальный возраст игроков;
- адрес;
- номера телефонов;
- e-mail;
- компания;
- рейтинг;
- уровень страха (по пятибалльной шкале);
- уровень сложности (по пятибалльной шкале);
- логотип;
- галерея изображений.

Создать контроллер и метод действия, а также представление
для отображения информации о квест-комнате. Установить стан-
дартный маршрут на этот контроллер и метод действия.

Task 2:

Необходимо в класс имитированного хранилища добавить несколько квест-комнат. Создать метод действия в контроллере,
разработанном в прошлом ДЗ, для вывода списка квест-комнат.Также создать представление, в котором будет отображаться краткая
информация о каждой квест-комнате (название, фото, минимальное и максимальное количество игроков, время прохождения и рейтинг).

Название каждой квест-комнаты должно быть ссылкой на метод действия, 
выводящий подробную информацию о ней. Переделать стандартный маршрут, чтобы он ссылался на страницу сосписком комнат. 
Создать мастер-страницу, в которой определить общий интерфейс сайта.
Создайте админ-панель для управления каталогом квест-комнат. Создайте новый контроллер и добавьте методы действий
и представления для добавления, удаления и редактирования
квест-комнат. В формах сделать необходимую валидацию данных.

Task 3:

Спроектировать базу данных для хранения информации о квест-комнатах.
Заполнить информацией о нескольких квест-комнатах. С помощью Entity Framework ассоциировать нашу модель
с базой. Создать класс хранилища, который через контекст обращается к базе данных.
Вместо класса имитированного хранилища, использовать для вывода списка квест-комнат и подробной информации новый класс хранилища.
На главную страницу, где отображается список квест-комнат, добавить форму с возможностью фильтрации списка по сложности,
количеству игроков, уровню страха.

Есть задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

В данном коде используется метод CreateUsersTextArray с фиксированным разметом 4 (как в примере), который принимает исходный массив строк задаваемый юзером. Юзер вводит поочередно четыре элемента массива в виде текста при помощи клавиатуры.

Метод NewTextArray с помощью цикла for перебирает массив и находит в нем элементы меньше и равные 3 символам, в этом же методе создаем новый массив с новым размером.

Далее выводим в терминал массив который ввел пользователь usersTextArray и новый массив newTextArray в виде [" ", " ", " ", " "] -> [" ", " " ]. 
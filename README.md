# Итоговое задание основного блока.

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:  

["hello", "2", "word, ":-)"] -> ["2", ":-)"]  
["1234", "1567", "2", "computer sience"] -> ["2"]  
["Russia", "Denmark", "Kazan"] -> []

_________________________________________________________________

## Описание решения данного задания.

### Для выполнения программы мы применяем следующие методы:

Ввод целочисленного значения, для задания размерности исходного массива строк

    InputInt()

Создание исходного массива строк, где каждый элемент массива мы вводим вручную с клавиатуры.

    GenerateArray()

**_Ключевой метод нашей программы_** - преобразование исходного массива строк, в массив, в котором будут находиться только те строковые элементы, которые удовлетворяют условию задания (количество символов в строке не превышает 3).

    CreateNewArray()

В конце мы применяем метод, который выводит новый полученный массив из строковых элементов в консоль.

    ShowArray()
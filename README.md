# **Задача** : 
### Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## **Решение** :

### Объявляется два массива: Первый, который содержит строки "AB33", "12", "12345", "Hello World!", "GiT"  и вторый такой же длины. Объявляется переменная count необходимая для поочередного копирования элементов массива(иначе между элементами второго массива могут быть пробелы). Создаем метод, в котором цикл продолжительность которого равна длине массива. Внутри цикла идет проверка условия (<=3), если условие выполняется, элемент первого массива заносится в count элемент второго массива и переменная count увеличивается на 1. Происходит возвращение к циклу for, в котором i увеличивается на 1 и продолжается до окончания цикла. 
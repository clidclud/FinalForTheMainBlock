# Задача
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# Решение
1. Приглашаем пользователя определиться с количеством элементов массива.
2. Приглашаем пользователя ввести те самые элементы массива.
3. Программа демонстрирует массив.
4. Создаем второй массив с максимально возможным количеством элементов, т.е. берем из *п.1*.
5. Создаем счетчик для элементов второго массива.
6. Создаем ограничение по заданию, меньше либо равно 3 символам.
7. Условие. Если количество символов элемента первого массива больше *п.6*, то цикл переходит к следующему элементу первого массива. Если количество символов элемента первого массива меньше или равно *п.6* (как раз то что нам нужно по заданию), данный элемент первого массива записывается в элемент второго массив с индексом *п.5*, далее *п.5* переходит к следующему индексу для записи следующего подходящего элемента первого массива.
8. Вывод второго массива.

# Примечание
На русском языке не работает, массив не заполняется.
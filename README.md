# Итоговая проверочная работа 
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом

## *Задача:* 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

## Алгоритм решения задачи
* Просим ввести пользователя строки массива. Ставим ограничение в 5 строк
* Создаем массив из введенных строк
* Проводим проверку, перебирая весь массив, выбирая нужные элементы из введенного массива согласно условию задачи ( <= 3 )
* Выводим заданный массив и массив с элементами <= 3 символов

**! Блок-схема представлена в файле BlockShema.png**

# CheckersGame
Проект "Шашки" с авторизацией и регистрацией

**Решения возможных ошибок связанных с проектом**
1. Пример текста ошибки: 
Не удалось обработать файл Form1.resx из-за того, что он находится в Интернете или зоне ограниченного доступа или имеет отметку Интернета на файле. Удалите метку Интернета, если вы хотите обработать эти файлы.

Решение: Запускаем PowerShell -> вписываем туда данную строку  gci -recurse "C:\Users\Vadim\Desktop\CheckersGame-master" | Unblock-File **(вместо моего расположения ,указываем своё). 

Готово.

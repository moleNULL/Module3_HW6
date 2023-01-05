# &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;NIX Solutions Module #3 Homework #6

                                                          Задача:

класс MessageBox\
&nbsp;&nbsp;&nbsp;&nbsp;○ Містить метод async Task Open()\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;■ Метод пише на екрані повідомлення з текстом, що відкрито вікно\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;■ потім чекає 3 секунди\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;■ Після чого пише повідомлення, що вікно було закрито користувачем\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;■ Викликаємо подію про те, що вікно закрите і як параметр передаємо випадкове значення State\
&nbsp;&nbsp;&nbsp;&nbsp;○ Містить подію про те, що вікно було зачинено

enum: State = Ok | Cancel

в Starter викликати метод Open() і написати в консоль якщо State\
&nbsp;&nbsp;&nbsp;&nbsp;○ Ok - операція була підтверджена\
&nbsp;&nbsp;&nbsp;&nbsp;○ Cancel - операція була відхилена

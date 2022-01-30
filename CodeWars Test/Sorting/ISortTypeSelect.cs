using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ну в общем можно бы немного допилить сортировку.
//Чтобы программа при запуске спрашивала какой алгоритм юзать, юзер вводит 1 или 2. 
//Нужно чтобы вопросы эти задавались в Class Program, но не в методе Main.
//То есть сделать метод для выбора алгоритма, выбранный алгоритм должен вернуться в Main() и запуститься

namespace CodeWars_Test.Sorting
{
    interface ISortTypeSelect
    {
        void SelectSort();
    }
}

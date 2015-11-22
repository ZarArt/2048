using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2048
{
    class Logic
    {
        int size;
        int[,] map;
        DeShow show;
        ShowStat stat;
        static Random rand = new Random();
        bool moved = false;
        public Logic(int size, DeShow show, ShowStat stat)
        {
            this.size = size;
            map = new int[size, size];
            this.show = show;
            this.stat = stat;
        }

        public void InitGame()
        {
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    map[x, y] = 0;
                    show(x, y, 0);
                }
            }
            AddNumbers();
            AddNumbers();
        }

        public void ShiftLeft() // Движение ВЛЕВО
        {
            moved = false;
            for (int y = 0; y < size; y++)
            {
                Shift(size - 1, y, -1, 0);
                Combine(size - 1, y, -1, 0);
                Shift(size - 1, y, -1, 0);
            }
            if (moved)
            {
                AddNumbers();
            }
        }

        public void ShiftRight() // Движение ВПРАВО
        {
            moved = false;
            for (int y = 0; y < size; y++)
            {
                Shift(0, y, 1, 0);
                Combine(0, y, 1, 0);
                Shift(0, y, 1, 0);
            }
            if (moved)
            {
                AddNumbers();
            }
        }

        public void ShiftUp() // Движение ВВЕРХ
        {
            moved = false;
            for (int x = 0; x < size; x++)
            {
                Shift(x, size - 1, 0, -1);
                Combine(x, size - 1, 0, -1);
                Shift(x, size - 1, 0, -1);
            }
            if (moved)
            {
                AddNumbers();
            }
        }

        public void ShiftDown() // Движение ВНИЗ
        {
            moved = false;
            for (int x = 0; x < size; x++)
            {
                Shift(x, 0, 0, 1);
                Combine(x, 0, 0, 1);
                Shift(x, 0, 0, 1);
            }
            if (moved)
            {
                AddNumbers();
            }
        }

        public bool GameOver() // Проверка на окончание игры
        {
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if (map[x, y] == 0)
                    {
                        return false;
                    }
                }
            }
            for (int x = 0; x < size - 1; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if (map[x, y] == map[x + 1, y])
                    {
                        return false;
                    }
                }
            }
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size - 1; y++)
                {
                    if (map[x, y] == map[x, y + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void AddNumbers() // Добавление нового(ых) числа(сел) после совершения нового хода
        {
            if (GameOver())
            {
                return;
            }
            int x, y;
            do
            {
                x = rand.Next(0, size);
                y = rand.Next(0, size);
            } while (map[x, y] > 0);
            map[x, y] = ChooseNumber();
            show(x, y, map[x, y]);
        }

        private int ChooseNumber() //Реализация появления 2-ки (80%) или 4-ки (20%)
        {
            switch (rand.Next(10))
            {
                case 0: return 2; break;
                case 1: return 2; break;
                case 2: return 2; break;
                case 3: return 2; break;
                case 4: return 2; break;
                case 5: return 2; break;
                case 6: return 2; break;
                case 7: return 2; break;
                case 8: return 4; break;
                case 9: return 4; break;
                default: return 2; break;
            }
        }

        private void Shift(int x, int y, int sx, int sy) // Движение..просто движение..в любую сторону
        {
            if (x + sx < 0 || x + sx >= size ||
                y + sy < 0 || y + sy >= size)
            {
                return;
            }
            Shift(x + sx, y + sy, sx, sy);
            if (map[x + sx, y + sy] == 0 && map[x, y] > 0)
            {
                map[x + sx, y + sy] = map[x, y];
                map[x, y] = 0;
                show(x + sx, y + sy, map[x + sx, y + sy]);
                show(x, y, map[x, y]);
                Shift(x + sx, y + sy, sx, sy);
                moved = true;
            }
        }

        private void Combine(int x, int y, int sx, int sy) // Суммирование двух чисел
        {
            if (x + sx < 0 || x + sx >= size ||
                y + sy < 0 || y + sy >= size)
            {
                return;
            }
            Combine(x + sx, y + sy, sx, sy);
            if (map[x + sx, y + sy] > 0 &&
                map[x + sx, y + sy] == map[x, y])
            {
                map[x + sx, y + sy] *= 2;
                map[x, y] = 0;
                show(x + sx, y + sy, map[x + sx, y + sy]);
                show(x, y, map[x, y]);
                stat(map[x + sx, y + sy]);
                Shift(x + sx, y + sy, sx, sy);
                moved = true;
            }
        }
    }
}

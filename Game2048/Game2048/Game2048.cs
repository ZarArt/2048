using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2048
{
    public delegate void DeShow(int x, int y, int score);
    public delegate void ShowStat(int balls);
    public partial class Game2048 : Form
    {
        static int size = 4;

        Label[,] labels;

        Dictionary<int, Color> backColors;

        Logic logic;

        Statistics statistics;
        public Game2048()
        {
            InitializeComponent();
            InitBackColors();
            InitLabels();
            logic = new Logic(size, Show, ShowStat);
            logic.InitGame();
            statistics = new Statistics("ToR.dat");
        }

        private void InitBackColors() //Создание коллекции цветов для чисел.
        {
            backColors = new Dictionary<int, Color>();
            backColors.Add(0, Color.FromArgb(215, 215, 215));
            backColors.Add(2, Color.FromArgb(237, 247, 248));
            backColors.Add(4, Color.FromArgb(228, 251, 227));
            backColors.Add(8, Color.FromArgb(241, 223, 122));
            backColors.Add(16, Color.FromArgb(241, 186, 103));
            backColors.Add(32, Color.FromArgb(236, 138, 79));
            backColors.Add(64, Color.FromArgb(239, 85, 32));
            backColors.Add(128, Color.FromArgb(239, 245, 120));
            backColors.Add(256, Color.FromArgb(250, 250, 52));
            backColors.Add(512, Color.FromArgb(242, 181, 233));
            backColors.Add(1024, Color.FromArgb(242, 181, 233));
            backColors.Add(2048, Color.FromArgb(242, 181, 233));
            backColors.Add(4096, Color.FromArgb(242, 181, 233));
            backColors.Add(8192, Color.FromArgb(242, 181, 233));
            backColors.Add(16384, Color.FromArgb(242, 181, 233));
            backColors.Add(32768, Color.FromArgb(242, 181, 233));
            backColors.Add(65536, Color.FromArgb(242, 181, 233));
        }

        private void InitLabels() //Инициализация всех лейблов на форме
        {
            int w = panel1.Width / size;
            int h = panel1.Height / size;
            labels = new Label[size, size];
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    labels[x, y] = CreateLabel();
                    labels[x, y].Size = new System.Drawing.Size(w - 10, h - 10);
                    labels[x, y].Location = new Point(x * w + 10, y * h + 10);
                    panel1.Controls.Add(labels[x, y]);
                }
            }
        }

        private Label CreateLabel() // Создание 1 лейбла.
        {
            Label label = new Label();
            label.BackColor = System.Drawing.Color.LightCoral;
            label.Font = new System.Drawing.Font("Tahoma", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label.Location = new System.Drawing.Point(0, 0);
            label.Text = "-";
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            return label;
        }

        public void Show(int x, int y, int score) //Отображение числа на определенном лейбле
        {
            labels[x, y].Text = score == 0 ? "" : score.ToString();
            labels[x, y].BackColor = backColors[score];
        }

        private void ShowStat(int balls) // Метод для анимации счета игры
        {
            try
            {
                int score = Convert.ToInt32(toolStripTextBoxRealScore.Text);
                string str = Convert.ToString(score + balls);
                toolStripTextBoxRealScore.Text = str;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка считывания данных", "Ошибка!");
            }
        }

        private void HandlingFinishInfo() //Метод обрабатывает окончание игры
        {
            DialogResult resultQuestionToSave = MessageBox.Show("Игра окончена.\nВаш результат " +
                toolStripTextBoxRealScore.Text + "." + "\nХотите сохранить результат?",
                "Конец игры", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultQuestionToSave == System.Windows.Forms.DialogResult.Yes)
            {
                statistics.WriteTable(toolStripTextBoxRealName.Text, toolStripTextBoxRealScore.Text);
                if (QuestionToPlayAgain() == System.Windows.Forms.DialogResult.Yes)
                {
                    logic.InitGame();
                    toolStripTextBoxRealScore.Text = "0";
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                if (QuestionToPlayAgain() == System.Windows.Forms.DialogResult.Yes)
                {
                    logic.InitGame();
                    toolStripTextBoxRealScore.Text = "0";
                }
                else
                {
                    this.Close();
                }
            }
        }

        private DialogResult QuestionToPlayAgain() //Создание запроса новой игры
        {
            DialogResult result = MessageBox.Show("Хотите сыграть заново?",
                "Game over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result;
        }

        private void Game2048_KeyDown(object sender, KeyEventArgs e) // Обработка нажатия кнопки с клавиатуры
        {
            switch (e.KeyCode)
            {
                case Keys.Left: logic.ShiftLeft(); break;
                case Keys.Right: logic.ShiftRight(); break;
                case Keys.Up: logic.ShiftUp(); break;
                case Keys.Down: logic.ShiftDown(); break;
                case Keys.Escape: logic.InitGame(); break;
                default: break;
            }
            if (logic.GameOver())
            {
                HandlingFinishInfo();
            }
        }

        private void toolStripTextBoxRealName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                panel1.Focus();
            }
        }

        private void toolStripMenuItemRestart_Click(object sender, EventArgs e)
        {
            HandlingRestartGame();
            toolStripTextBoxRealScore.Text = "0";
        }

        private void HandlingRestartGame() //Метод обрабатывает рестарт игры
        {
            DialogResult resultQuestionToSave = MessageBox.Show("Хотите сохранить результат?",
                "Сохранение игры", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultQuestionToSave == System.Windows.Forms.DialogResult.Yes)
            {
                statistics.WriteTable(toolStripTextBoxRealName.Text, toolStripTextBoxRealScore.Text);
                logic.InitGame();
            }
            else
            {
                logic.InitGame();
            }
        }

        private void toolStripComboBoxTOR_Click(object sender, EventArgs e)
        {
            toolStripComboBoxTOR.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (i < statistics.table.Count)
                {
                    toolStripComboBoxTOR.Items.Add((i + 1).ToString() + ". " + statistics.ViewItemTable(i));
                }
            }
        }

        private void toolStripMenuItemRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Классическая игра 2048.\nЦель игры - достигнуть как можно большего счета," +
                "\nс помощью сложения одинаковых чисел.", "Правила игры",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using System;
using System.Windows.Forms;

namespace ShowTime
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer vTimer = new System.Windows.Forms.Timer();

        private void ShowTime(object sender, EventArgs e)
        {
            // Отримуємо поточний час і дату
            DateTime currentTime = DateTime.Now;

            // Перетворення в рядок та відображення часу та дати
            labelTime.Text = currentTime.ToString("HH:mm:ss  dd/MM/yyyy");
        }

        public Form1()
        {
            InitializeComponent();

            // Встановлення тексту зараз, під час ініціалізації форми
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss  dd/MM/yyyy");

            // Закріплення обробника
            vTimer.Tick += new EventHandler(ShowTime);

            // Встановлення інтервалу часу (в мілісекундах)
            vTimer.Interval = 1000;

            // Запуск таймера
            vTimer.Start();
        }
    }
}

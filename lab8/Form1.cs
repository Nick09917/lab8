namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Дана матрица F(15,15). Вывести номер и среднее арифметическое элементов строки, начинающейся с 1. Если такой строки нет, то вывести сообщение «Строки нет».");
            button2.Visible = true;
        }
        int[,] a = new int[15, 15];
        int i, j;
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 15;
            dataGridView1.ColumnCount = 15;

            Random rnd = new Random();
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    a[i, j] = rnd.Next(-100, 100);

                }
            }

            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                }
            }

            List<int> results = new List<int>();

            for (i = 0; i < 15; i++)
            {
                if (a[i, 0] == 1)
                {
                    int sredArifm = 0;
                    int count = 0;

                    for (j = 0; j < 15; j++)
                    {
                        sredArifm += a[i, j];
                        count++;
                    }

                    if (count > 0)
                    {
                        int avg = sredArifm / count;
                        results.Add(avg);
                    }
                }
            }

            if (results.Count > 0)
            {
                string message = "Средние арифметические для строк, начинающихся с 1:\n";
                for (int k = 0; k < results.Count; k++)
                {
                    message += "Строка " + (k + 1) + " = " + results[k] + "\n";
                }
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Нет строк, начинающихся с 1.");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                a[1, 0] = 1;
                a[6, 0] = 1;

                for (i = 0; i < 15; i++)
                {
                    for (j = 0; j < 15; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                    }
                }
                List<int> results = new List<int>();

                for (i = 0; i < 15; i++)
                {
                    if (a[i, 0] == 1)
                    {
                        int sredArifm = 0;
                        int count = 0;

                        for (j = 0; j < 15; j++)
                        {
                            sredArifm += a[i, j];
                            count++;
                        }

                        if (count > 0)
                        {
                            int avg = sredArifm / count;
                            results.Add(avg);
                        }
                    }
                }

                if (results.Count > 0)
                {
                    string message = "Средние арифметические для строк, начинающихся с 1:\n";
                    for (int k = 0; k < results.Count; k++)
                    {
                        message += "Строка " + (k + 1) + " = " + results[k] + "\n";
                    }
                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show("Нет строк, начинающихся с 1.");
                }
            }
            catch
            {
                MessageBox.Show("Ты че дурак, Сначала массив заполни");
            }



        }

    }
}
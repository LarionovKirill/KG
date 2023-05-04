using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace Лабораторная_работа_3
{
    public partial class Task11 : Form
    {
        /// <summary>
        /// Координата по X.
        /// </summary>
        private int xn;

        /// <summary>
        /// Координата по Y.
        /// </summary>
        private int yn;

        private float[,] matrSdvig = new float[3, 3];

        private float[,] _ship = new float[12, 3];

        private float[,] _ship2 = new float[12, 3];

        private float[,] matrTurn = new float[8, 3];

        private float[,] matrOtr = new float[3, 3];

        private bool isStart = true;

        /// <summary>
        /// Множитель Х
        /// </summary>
        private float a = 1;

        /// <summary>
        /// Множитель Y
        /// </summary>
        private float b = 1;

        /// <summary>
        /// Множитель Х
        /// </summary>
        private float a2 = 1;

        /// <summary>
        /// Множитель Y
        /// </summary>
        private float b2 = 1;
        public Task11()
        {
            InitializeComponent();
            xn = pictureBox1.Width / 2;
            yn = pictureBox1.Height / 2;
        }

        float[,] center = new float[3, 2];

        /// <summary>
        /// Инициализирует ракету.
        /// </summary>
        private void InitShip()
        {
            _ship[0, 0] = 150; _ship[0, 1] = 0; _ship[0, 2] = 1;
            _ship[1, 0] = 160; _ship[1, 1] = -10; _ship[1, 2] = 1;
            _ship[2, 0] = 170; _ship[2, 1] = 0; _ship[2, 2] = 1;
            _ship[3, 0] = 170; _ship[3, 1] = 15; _ship[3, 2] = 1;
            _ship[4, 0] = 180; _ship[4, 1] = 30; _ship[4, 2] = 1;
            _ship[5, 0] = 140; _ship[5, 1] = 30; _ship[5, 2] = 1;
            _ship[6, 0] = 150; _ship[6, 1] = 15; _ship[6, 2] = 1;
            _ship[7, 0] = 150; _ship[7, 1] = 0; _ship[7, 2] = 1;
            _ship[8, 0] = 150; _ship[8, 1] = 0; _ship[8, 2] = 1;
            _ship[9, 0] = 170; _ship[9, 1] = 0; _ship[9, 2] = 1;
            _ship[10, 0] = 150; _ship[10, 1] = 15; _ship[10, 2] = 1;
            _ship[11, 0] = 170; _ship[11, 1] = 15; _ship[11, 2] = 1;
        }

        private void InitMatrOtr()
        {
            matrOtr[0, 0] = -1; matrOtr[0, 1] = 0; matrOtr[0, 2] = 0;
            matrOtr[1, 0] = 0; matrOtr[1, 1] = -1; matrOtr[1, 2] = 0;
            matrOtr[2, 0] = 0; matrOtr[2, 1] = 0; matrOtr[2, 2] = 1;
        }


        /// <summary>
        /// Рисует центр.
        /// </summary>
        private void DrawCenter()
        {
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            Pen myPen = new Pen(Color.Green, 2);// цвет линии и ширина
            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            Rectangle rect = new Rectangle(xn - 50, yn - 50, 100, 100);
            g.DrawEllipse(myPen, rect);
            g.FillEllipse(greenBrush, rect);
            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождаем ресурсы, связанные с Pen
        }

        /// <summary>
        /// Создает матрицу сдвига.
        /// </summary>
        private void InitMatrSdv(float a, float b)
        {
            matrSdvig[0, 0] = a; matrSdvig[0, 1] = 0; ; matrSdvig[0, 2] = 0;
            matrSdvig[1, 0] = 0; matrSdvig[1, 1] = b; matrSdvig[1, 2] = 0;
            matrSdvig[2, 0] = xn; matrSdvig[2, 1] = yn; matrSdvig[2, 2] = 1;
        }

        /// <summary>
        /// Рисует космический корабль.
        /// </summary>
        private void DrawShip(float[,] f)
        {
            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина
            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    g.DrawLine(myPen, f[i, j], f[i, j + 1], f[i + 1, j], f[i + 1, j + 1]);
                }
            }
            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождаем ресурсы, связанные с Pen 
        }

        /// <summary>
        /// Произведение матрицы тела и матрицы преобразования.
        /// </summary>
        /// <param name="a">Матрица тела.</param>
        /// <param name="b">Матрица преобразования.</param>
        /// <returns>Преобразованная матрица.</returns>
        private float[,] Multiply_matr(float[,] a, float[,] b)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            float[,] r = new float[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    r[i, j] = 0;
                    for (int ii = 0; ii < m; ii++)
                    {
                        r[i, j] += a[i, ii] * b[ii, j];
                    }
                }
            }
            return r;
        }


        /// <summary>
        /// Формирует матрицу поворота.
        /// </summary>
        private void InitMatrTurn(float angle)
        {
            matrTurn[0, 0] = (float)Math.Cos(Math.PI * angle / 180); matrTurn[0, 1] = (float)Math.Sin(Math.PI * angle / 180); ; matrTurn[0, 2] = 0;
            matrTurn[1, 0] = (float)Math.Sin(Math.PI * angle / 180) * -1; matrTurn[1, 1] = (float)Math.Cos(Math.PI * angle / 180); matrTurn[1, 2] = 0;
            matrTurn[2, 0] = 0; matrTurn[2, 1] = 0; matrTurn[2, 2] = 1;
        }

        /// <summary>
        /// Обработчик кнопки старт.
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;

            startButton.Text = "Стоп";
            if (isStart == true)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                startButton.Text = "Старт";
            }
            isStart = !isStart;
            DrawCenter();
            InitMatrOtr();
        }

        /// <summary>
        /// Замедляет работу потока.
        /// Кружит предмет по орбите.
        /// </summary>
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            a = 1;
            b = 1;
            a2 = 1;
            b2 = 1;
            for (int i = 36; i > 0; --i)
            {
                DrawCenter();
                InitMatrTurn(i * 10);
                InitShip();
                if (i <= 9 || i >= 27)
                {
                    a = a + 0.03f;
                    b = b + 0.03f;
                    InitMatrSdv(a, b);
                }
                else
                {
                    a = a - 0.03f;
                    b = b - 0.03f;
                    InitMatrSdv(a, b);
                }
                _ship = Multiply_matr(_ship, matrTurn);
                _ship = Multiply_matr(_ship, matrSdvig);
                DrawShip(_ship);

                //второй корабль
                InitMatrTurn(i * 20);
                InitShip();
                if (i%2==0)
                {
                    a2 = a;
                    b2 = b;
                    InitMatrSdv(a2, b2);
                }
                else
                {
                    a2 = a;
                    b2 = b;
                    InitMatrSdv(a2, b2);
                }
                _ship2  = Multiply_matr(_ship, matrOtr);
                _ship2 = Multiply_matr(_ship2, matrTurn);
                _ship2 = Multiply_matr(_ship2, matrSdvig);
                DrawShip(_ship2);
                Thread.Sleep(100);
                pictureBox1.Image = null;
                pictureBox1.Refresh();
            }
        }
    }
}

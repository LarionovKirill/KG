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
    public partial class PersonalTask : Form
    {
        /// <summary>
        /// Координата по X.
        /// </summary>
        int xn;

        /// <summary>
        /// Координата по Y.
        /// </summary>
        int yn;

        float[,] matrSdvig = new float[3, 3];

        float[,] _ship = new float[12,3];

        float[,] matrTurn = new float [8,3];

        bool isStart = true;

        /// <summary>
        /// Множитель Х
        /// </summary>
        float a = 1;

        /// <summary>
        /// Множитель Y
        /// </summary>
        float b = 1;

        public PersonalTask()
        {
            InitializeComponent();
        }

        float[,] center = new float[3, 2];

        /// <summary>
        /// Инициализирует ракету.
        /// </summary>
        private void InitShip()
        {
            _ship[0, 0] = 150; _ship[0, 1] =0; _ship[0, 2] = 1;
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

        /// <summary>
        /// Получает координаты для центра орбиты.
        /// </summary>
        /// <param name="e">События мышки.</param>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Refresh();
            xn = e.X;
            yn = e.Y;
            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина
            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            // рисуем 1 сторону треугольника
            g.DrawLine(myPen, xn, yn-30, xn-15, yn+15 );
            // рисуем 2 сторону треугольника
            g.DrawLine(myPen, xn - 15, yn + 15, xn + 15, yn + 15);
            // рисуем 3 сторону треугольника
            g.DrawLine(myPen, xn + 15, yn + 15, xn, yn - 30);
            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождаем ресурсы, связанные с Pen
        }

        /// <summary>
        /// Рисует центр.
        /// </summary>
        private void DrawCenter()
        {
            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина
            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            // рисуем 1 сторону треугольника
            g.DrawLine(myPen, xn, yn - 30, xn - 15, yn + 15);
            // рисуем 2 сторону треугольника
            g.DrawLine(myPen, xn - 15, yn + 15, xn + 15, yn + 15);
            // рисуем 3 сторону треугольника
            g.DrawLine(myPen, xn + 15, yn + 15, xn, yn - 30);
            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождаем ресурсы, связанные с Pen
        }

        /// <summary>
        /// Создает матрицу сдвига.
        /// </summary>
        private void InitMatrSdv(float a , float b)
        {
            matrSdvig[0, 0] = a; matrSdvig[0, 1] = 0; ; matrSdvig[0, 2] = 0;
            matrSdvig[1, 0] = 0; matrSdvig[1, 1] = b; matrSdvig[1, 2] = 0;
            matrSdvig[2, 0] = xn; matrSdvig[2, 1] = yn; matrSdvig[2, 2] = 1;
        }

        /// <summary>
        /// Рисует космический корабль.
        /// </summary>
        private void DrawShip()
        {
            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина
            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    g.DrawLine(myPen, _ship[i, j], _ship[i, j + 1], _ship[i + 1, j], _ship[i + 1, j + 1]);
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
        }

        /// <summary>
        /// Замедляет работу потока.
        /// Кружит предмет по орбите.
        /// </summary>
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            a = 1;
            b = 1;
            for (int i = 36; i > 0; --i)
            {
                DrawCenter();
                InitMatrTurn(i * 10);
                InitShip();
                if (i <= 9 || i >= 27)
                {
                    a = a - 0.05f;
                    b = b - 0.05f;
                    InitMatrSdv(a, b);
                }
                else
                {
                    a = a + 0.05f;
                    b = b + 0.05f;
                    InitMatrSdv(a, b);
                }
                _ship = Multiply_matr(_ship, matrTurn);
                _ship = Multiply_matr(_ship, matrSdvig);
                DrawShip();
                Thread.Sleep(100);
                pictureBox1.Image = null;
                pictureBox1.Refresh();
            }
        }
    }
}

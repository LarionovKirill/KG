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
    public partial class MainForm : Form
    {
        /// <summary>
        /// Матрица тела
        /// </summary>
        int[,] kv = new int[4, 3];

        /// <summary>
        /// Матрица осей.
        /// </summary>
        int[,] osi = new int[4, 3];

        /// <summary>
        /// Матрица преобразований.
        /// </summary>
        int[,] matr_sdv = new int[3, 3];

        /// <summary>
        /// Матрица изменения размера.
        /// </summary>
        float[,] matrSize = new float[3, 3];

        int k, l; // элементы матрицы сдвига

        float _sizeFactor = 1; // коэффициент размера.

       /// <summary>
       /// Матрица отражения
       /// </summary>
       float [,] matrRef = new float[3, 3];

        /// <summary>
        /// Матрица поворота.
        /// </summary>
        float[,] matrTurn = new float[3, 3];

        /// <summary>
        /// Нажат ли старт или нет.
        /// </summary>
        bool isStart = true;

        public MainForm()
        {
            InitializeComponent();
            k = pictureBox.Width / 2;
            l = pictureBox.Height / 2;
            InitMatrSize(_sizeFactor);
            InitMatrRef(1,0,0,1);
            InitMatrTurn(0);
        }

        /// <summary>
        /// Метод инициализирует фигуру.
        /// </summary>
        private void Init_figure()
        {
            kv[0, 0] = -50; kv[0, 1] = -50; kv[0, 2] = 1;
            kv[1, 0] = 20; kv[1, 1] = -50; kv[1, 2] = 1;
            kv[2, 0] = 34; kv[2, 1] = 15; kv[2, 2] = 1;
            kv[3, 0] = 10; kv[3, 1] = 40; kv[3, 2] = 1;
        }

        /// <summary>
        /// Формирует матрицу изменения размера.
        /// </summary>
        /// <param name="sizeFactor">Коэфициент изменения размера.</param>
        private void InitMatrSize(float sizeFactor)
        {
            matrSize[0, 0] = sizeFactor; matrSize[0, 1] = 0; matrSize[0, 2] = 0;
            matrSize[1, 0] = 0; matrSize[1, 1] = sizeFactor; matrSize[1, 2] = 0;
            matrSize[2, 0] = k; matrSize[2, 1] = l; matrSize[2, 2] = 1;
        }

        /// <summary>
        /// Формирует матрицу поворота.
        /// </summary>
        private void InitMatrTurn(float angle)
        {
            matrTurn[0, 0] = (float)Math.Cos(Math.PI*angle/180); matrTurn[0, 1] = (float)Math.Sin(Math.PI * angle / 180); ; matrTurn[0, 2] = 0;
            matrTurn[1, 0] = (float)Math.Sin(Math.PI * angle / 180)*-1; matrTurn[1, 1] = (float)Math.Cos(Math.PI * angle / 180); matrTurn[1, 2] = 0;
            matrTurn[2, 0] = 0; matrTurn[2, 1] = 0; matrTurn[2, 2] = 1;
        }



        /// <summary>
        /// Метод инициализирует матрицу преобразования.
        /// </summary>
        /// <param name="k1">Сдвиг по X</param>
        /// <param name="l1">Сдвиг по Y</param>
        private void Init_matr_preob(int k1, int l1)
        {
            matr_sdv[0, 0] = 1; matr_sdv[0, 1] = 0; matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = 0; matr_sdv[1, 1] = 1; matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = k1; matr_sdv[2, 1] = l1; matr_sdv[2, 2] = 1;
        }

        /// <summary>
        /// Метод инициализирует оси.
        /// </summary>
        private void Init_osi()
        {
            osi[0, 0] = -200; osi[0, 1] = 0; osi[0, 2] = 1;
            osi[1, 0] = 200; osi[1, 1] = 0; osi[1, 2] = 1;
            osi[2, 0] = 0; osi[2, 1] = 200; osi[2, 2] = 1;
            osi[3, 0] = 0; osi[3, 1] = -200; osi[3, 2] = 1;
        }

        /// <summary>
        /// Метод инициализирует матрицу отражения.
        /// </summary>
        private void InitMatrRef(float a, float b, float c,float d)
        {
            matrRef[0, 0] = a; matrRef[0, 1] = b; matrRef[0, 2] = 0;
            matrRef[1, 0] = c; matrRef[1, 1] = d; matrRef[1, 2] = 0;
            matrRef[2, 0] = 0; matrRef[2, 1] = 0; matrRef[2, 2] = 1;
        }

        /// <summary>
        /// Произведение матрицы тела и матрицы преобразования.
        /// </summary>
        /// <param name="a">Матрица тела.</param>
        /// <param name="b">Матрица преобразования.</param>
        /// <returns>Преобразованная матрица.</returns>
        private int[,] Multiply_matr(int[,] a, int[,] b)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            int[,] r = new int[n, m];
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
        /// Произведение матрицы тела и матрицы преобразования.
        /// </summary>
        /// <param name="a">Матрица тела.</param>
        /// <param name="b">Матрица преобразования.</param>
        /// <returns>Преобразованная матрица.</returns>
        private float[,] Multiply_matr(int[,] a, float[,] b)
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
        /// Метод рисует фигуру.
        /// </summary>
        private void Draw_Kv()
        {
            Init_figure(); //инициализация матрицы тела
            Init_matr_preob(k, l); //инициализация матрицы преобразования
            matrSize[2, 0] = k; matrSize[2, 1] = l;
            float[,] kv1 = Multiply_matr(kv, matrRef); //перемножение матриц
            kv1 = Multiply_matr(kv1, matrTurn);
            kv1 = Multiply_matr(kv1, matrSize);
            DrawFiqure(kv1);
        }

        /// <summary>
        /// Метод рисует прямоугольник на PictureBox.
        /// </summary>
        private void CreateFigureButton_Click(object sender, EventArgs e)
        {
            //середина pictureBox
            k = pictureBox.Width / 2;
            l = pictureBox.Height / 2;
            //вывод квадратика в середине
            Draw_Kv();
        }

        /// <summary>
        /// Метод рисует координаты.
        /// </summary>
        private void Draw_osi()
        {
            Init_osi();
            Init_matr_preob(k, l);
            int[,] osi1 = Multiply_matr(osi, matr_sdv);
            Pen myPen = new Pen(Color.Red, 1);// цвет линии и ширина
            Graphics g = Graphics.FromHwnd(pictureBox.Handle);
            // рисуем ось ОХ
            g.DrawLine(myPen, osi1[0, 0], osi1[0, 1], osi1[1, 0], osi1[1,
            1]);
            // рисуем ось ОУ
            g.DrawLine(myPen, osi1[2, 0], osi1[2, 1], osi1[3, 0], osi1[3,
            1]);
            g.Dispose();
            myPen.Dispose();
        }

        /// <summary>
        /// Метод переводит координаты в центр экрана.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void СreateAxesButton_Click(object sender, EventArgs e)
        {
            k = pictureBox.Width / 2;
            l = pictureBox.Height / 2;
            Draw_osi();
        }

        /// <summary>
        /// Сдвиг квадрата вправо на 5 единиц.
        /// </summary>
        private void shiftToRightButton_Click(object sender, EventArgs e)
        {
            k += 5; //изменение соответствующего элемента матрицы сдвига
            Draw_Kv(); //вывод квадратика
        }

        /// <summary>
        /// Метод очищает поверхность.
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pictureBox.Refresh();
            _sizeFactor = 1;
            InitMatrSize(_sizeFactor);
            InitMatrRef(1, 0, 0, 1);
            InitMatrTurn(0);
        }

        /// <summary>
        /// Сдвиг влево по оси OX.
        /// </summary>
        private void ShiftToLeftButton_Click(object sender, EventArgs e)
        {
            k -= 5; //изменение соответствующего элемента матрицы сдвига
            Draw_Kv(); //вывод квадратика
        }

        /// <summary>
        /// Сдвиг вверх по оси OY.
        /// </summary>
        private void ShiftToUpButton_Click(object sender, EventArgs e)
        {
            l -= 5; //изменение соответствующего элемента матрицы сдвига
            Draw_Kv(); //вывод квадратика
        }

        /// <summary>
        /// Сдвиг вниз по оси OY.
        /// </summary>
        private void ShiftToDownButton_Click(object sender, EventArgs e)
        {
            l += 5; //изменение соответствующего элемента матрицы сдвига
            Draw_Kv(); //вывод квадратика
        }

        /// <summary>
        /// Метод выполняет поворот на 90 градусов против часовой стрекли.
        /// </summary>
        private void TurnTo90Button_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pictureBox.Refresh();
            InitMatrTurn(90);
            Init_figure(); //инициализация матрицы тела
            float[,] kv1 = Multiply_matr(kv, matrTurn); //перемножение матриц
            kv1 = Multiply_matr(kv1, matrSize);
            Draw_osi();
            DrawFiqure(kv1);
        }

        /// <summary>
        /// Метод выполняет поворот на 180 градусов против часовой стрекли.
        /// </summary>
        private void TurnTo180Button_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pictureBox.Refresh();
            InitMatrTurn(180);
            Init_figure(); //инициализация матрицы тела
            float[,] kv1 = Multiply_matr(kv, matrTurn); //перемножение матриц
            kv1 = Multiply_matr(kv1, matrSize);
            Draw_osi();
            DrawFiqure(kv1);
        }

        /// <summary>
        /// Метод выполняет поворот на 270 градусов против часовой стрекли.
        /// </summary>
        private void TurnTo270Button_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pictureBox.Refresh();
            InitMatrTurn(270);
            Init_figure(); //инициализация матрицы тела
            float[,] kv1 = Multiply_matr(kv, matrTurn); //перемножение матриц
            kv1 = Multiply_matr(kv1, matrSize);
            Draw_osi();
            DrawFiqure(kv1);
        }

        /// <summary>
        /// Рисует фигуру по матрице переданной ему.
        /// </summary>
        private void DrawFiqure(int[,] kv1)
        {
            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина
            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromHwnd(pictureBox.Handle);
            // рисуем 1 сторону квадрата
            g.DrawLine(myPen, kv1[0, 0], kv1[0, 1], kv1[1, 0], kv1[1, 1]);
            // рисуем 2 сторону квадрата
            g.DrawLine(myPen, kv1[1, 0], kv1[1, 1], kv1[2, 0], kv1[2, 1]);
            // рисуем 3 сторону квадрата
            g.DrawLine(myPen, kv1[2, 0], kv1[2, 1], kv1[3, 0], kv1[3, 1]);
            // рисуем 4 сторону квадрата
            g.DrawLine(myPen, kv1[3, 0], kv1[3, 1], kv1[0, 0], kv1[0, 1]);
            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождаем ресурсы, связанные с Pen
        }


        /// <summary>
        /// Рисует фигуру по матрице переданной ему.
        /// </summary>
        private void DrawFiqure(float[,] kv1)
        {
            Pen myPen = new Pen(Color.Blue, 2);// цвет линии и ширина
            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromHwnd(pictureBox.Handle);
            // рисуем 1 сторону квадрата
            g.DrawLine(myPen, kv1[0, 0], kv1[0, 1], kv1[1, 0], kv1[1, 1]);
            // рисуем 2 сторону квадрата
            g.DrawLine(myPen, kv1[1, 0], kv1[1, 1], kv1[2, 0], kv1[2, 1]);
            // рисуем 3 сторону квадрата
            g.DrawLine(myPen, kv1[2, 0], kv1[2, 1], kv1[3, 0], kv1[3, 1]);
            // рисуем 4 сторону квадрата
            g.DrawLine(myPen, kv1[3, 0], kv1[3, 1], kv1[0, 0], kv1[0, 1]);
            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождаем ресурсы, связанные с Pen
        }

        /// <summary>
        /// Замедляет работу потока.
        /// </summary>
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (leftSteps.Checked)
            {
                k--;
                Draw_Kv();
                Thread.Sleep(100);
            }
            else if (rightSteps.Checked)
            {
                k++;
                Draw_Kv();
                Thread.Sleep(100);
            }
            else if (upSteps.Checked)
            {
                l--;
                Draw_Kv();
                Thread.Sleep(100);
            }
            else if (downSteps.Checked)
            {
                l++;
                Draw_Kv();
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Отображение относительно оси OX.
        /// </summary>
        private void ReflectionOXButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pictureBox.Refresh();
            Init_matr_preob(k,l);
            InitMatrRef(1, 0, 0, -1);
            Init_figure(); //инициализация матрицы тела
            float[,] kv1 = Multiply_matr(kv, matrRef); //перемножение матриц
            kv1 = Multiply_matr(kv1, matrTurn);
            kv1 = Multiply_matr(kv1, matrSize);
            Draw_osi();
            DrawFiqure(kv1);
        }


        /// <summary>
        /// Отображение относительно оси OY.
        /// </summary>
        private void ReflectionOYButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pictureBox.Refresh();
            InitMatrRef(-1, 0, 0, 1);
            Init_figure(); //инициализация матрицы тела
            float[,] kv1 = Multiply_matr(kv, matrRef); //перемножение матриц
            kv1 = Multiply_matr(kv1, matrTurn);
            kv1 = Multiply_matr(kv1, matrSize);
            Draw_osi();
            DrawFiqure(kv1);
        }

        /// <summary>
        /// Отображение относительно оси y=x.
        /// </summary>
        private void reflectionYXButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pictureBox.Refresh();
            InitMatrRef(0, 1, 1, 0);
            Init_figure(); //инициализация матрицы тела
            float[,] kv1 = Multiply_matr(kv, matrRef); //перемножение матриц
            kv1 = Multiply_matr(kv1, matrTurn);
            kv1 = Multiply_matr(kv1, matrSize);
            Draw_osi();
            DrawFiqure(kv1);
        }

        /// <summary>
        /// Метод увеличивает фигуру.
        /// </summary>
        private void increaseButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pictureBox.Refresh();
            _sizeFactor*=1.5f;
            InitMatrSize(_sizeFactor);
            Init_figure(); //инициализация матрицы тела
            float[,] kv1 = Multiply_matr(kv, matrRef); //перемножение матриц
            kv1 = Multiply_matr(kv1, matrTurn);
            kv1 = Multiply_matr(kv1, matrSize);
            Draw_osi();
            DrawFiqure(kv1);
        }

        /// <summary>
        /// Метод уменьшает фигуру.
        /// </summary>
        private void decreaseButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pictureBox.Refresh();
            _sizeFactor /= 1.5f ;
            InitMatrSize(_sizeFactor);
            Init_figure(); //инициализация матрицы тела
            float[,] kv1 = Multiply_matr(kv, matrRef); //перемножение матриц
            kv1 = Multiply_matr(kv1, matrTurn);
            kv1 = Multiply_matr(kv1, matrSize);
            Draw_osi();
            DrawFiqure(kv1);
        }
        private void ClearCheckBoxes()
        {
            leftSteps.Checked = false;
            rightSteps.Checked = false;
            upSteps.Checked = false;
            downSteps.Checked = false;
        }

        /// <summary>
        /// Обработчик кнопки старт.
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;

            startButton.Text = "Стоп";
            if (isStart == true)
                timer1.Start();
            else
            {
                timer1.Stop();
                startButton.Text = "Старт";
            }
            isStart = !isStart;
        }


        /// <summary>
        /// обработка нажатия на кнопку шаг.
        /// </summary>
        private void leftSteps_CheckedChanged(object sender, EventArgs e)
        {
            ClearCheckBoxes();
            leftSteps.Checked = true;
        }

        private void rightSteps_CheckedChanged(object sender, EventArgs e)
        {
            ClearCheckBoxes();
            rightSteps.Checked = true;
        }

        private void upSteps_CheckedChanged(object sender, EventArgs e)
        {
            ClearCheckBoxes();
            upSteps.Checked = true;
        }

        private void downSteps_CheckedChanged(object sender, EventArgs e)
        {
            ClearCheckBoxes();
            downSteps.Checked = true;
        }
    }
}

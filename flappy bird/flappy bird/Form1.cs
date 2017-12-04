﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird
{
  public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int DoChenhLechGiua2OngCong = 250;

        int x_cap1, x_cap2;

        int y_ongtren1;
        int y_ongduoi1;

        int y_ongtren2;
        int y_ongduoi2;
        int x_conchim;
        int y_conchim;

        private void Form1_Load(object sender, EventArgs e)
        {
            /* CODE FULL MÀN HÌNH */
            this.FormBorderStyle = FormBorderStyle.None;
            this.Left = 0;
            this.Top = 0;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            MessageBox.Show("with = " + this.Width + " & Hight = " + this.Height);

            x_cap1 = this.Width + 300; // Cách vào 300

            y_ongtren1 = -700; //ongtren1.Heyght + y_ongtren1 = độ cao hiển thị. (1000 + -700 = 300)
            ongtren1.Size = new Size(270, 1000);
            ongtren1.Location = new Point(x_cap1, y_ongtren1);

            // đã có độ cao của ống thứ 1
            // đã có độ chênh lệch giữa 2 ống
            // ta biết: độ cao ống 1 + độ chênh lệch + độ cao ống 2 = độ cao của form
            // độ cao ống 2 = độ cao form - độ cao ống 1 - độ chênh lệch 


            y_ongduoi1 = (1000 + y_ongtren1) + DoChenhLechGiua2OngCong;
            ongduoi1.Size = new Size(270, 1000);
            ongduoi1.Location = new Point(x_cap1, y_ongduoi1);

            x_cap2 = x_cap1 + ongtren1.Width + 400;  // Môi ống cống cách nhau 400

            y_ongtren2 = -700; //ongtren1.Heyght + y_ongtren1 = độ cao hiển thị. (1000 + -700 = 300)
            ongtren2.Size = new Size(270, 1000);
            ongtren2.Location = new Point(x_cap2, y_ongtren2);


            y_ongduoi2 = (1000 + y_ongtren2) + DoChenhLechGiua2OngCong;
            ongduoi1.Size = new Size(270, 1000);
            ongduoi2.Location = new Point(x_cap2, y_ongduoi2);

            conchim.Size = new Size(127, 100);
            x_conchim = conchim.Location.X;
            y_conchim = conchim.Location.Y;

            nutplay.Size = new System.Drawing.Size(50, 50);

            timer1.Interval = 1;
            timer2.Interval = 50;


        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            x_cap1 -= 10;
            x_cap2 -= 10;


            //  y_ongtren1 = -700; //ongtren1.Heyght + y_ongtren1 = độ cao hiển thị. (1000 + -700 = 300)

            ongtren1.Location = new Point(x_cap1, y_ongtren1);

            // đã có độ cao của ống thú 1
            // đã có độ chênh lệch giữa 2 ống
            // ta biết: độ cao ống 1 + độ chênh lệch + độ cao ống 2 = độ cao của form
            // độ cao ống 2 = độ cao form - độ cao ống 1 - độ chênh lệch 


            //   y_ongduoi1 = (1000 + y_ongtren1) + DoChenhLechGiua2OngCong;

            ongduoi1.Location = new Point(x_cap1, y_ongduoi1);


            //  y_ongtren2 = -700; //ongtren1.Heyght + y_ongtren1 = độ cao hiển thị. (1000 + -700 = 300)

            ongtren2.Location = new Point(x_cap2, y_ongtren2);


            // y_ongduoi2 = (1000 + y_ongtren2) + DoChenhLechGiua2OngCong;

            ongduoi2.Location = new Point(x_cap2, y_ongduoi2);

            //kiểm tra nếu cặp ống 1 mà đi qua khỏi form thì cho nó hiện lại đằng sau cặp ống cống 2
            if (x_cap1 + ongtren1.Width <= 0)

                // hiện lạ đằng sau cặp ống cống 2
                x_cap1 = 800 + ongtren2.Width + 400; // 400 là khoảng cách giữa 2 cặp.


            ongtren1.Location = new Point(x_cap1, y_ongtren1);
            ongduoi1.Location = new Point(x_cap1, y_ongduoi1);

            //kiểm tra nếu cặp ống 2 mà đi qua khỏi form thì cho nó hiện lại đằng sau ống 1
            if (x_cap2 + ongtren2.Width <= 0)



                x_cap2 = 800 + ongtren1.Width + 400; ; // 400 là khoảng cách giữa 2 cặp.




            ongtren2.Location = new Point(x_cap2, y_ongtren2);
            ongduoi2.Location = new Point(x_cap2, y_ongduoi2);



          

        }
        int dem = 0;

        private void nutplay_Click(object sender, EventArgs e)
        {
            dem++;
            if (dem % 2 != 0)
            {
                timer1.Start();
                timer2.Start();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
            }

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                y_conchim -= 50;


            }
        }

            private void timer2_Tick(object sender, EventArgs e)
            {

            if (y_conchim + conchim.Height <= this.Height)
            {

                y_conchim += 10;
                conchim.Location = new Point(x_conchim, y_conchim);
                if (x_conchim + conchim.Width >= x_cap1 && x_conchim + conchim.Width <= x_cap1 + ongtren1.Width)
                {
                    if (y_conchim <= 1000 + y_ongtren1 || y_conchim + conchim.Height >= y_ongduoi1)
                    {
                        timer1.Stop();

                    }
                }
                if (x_conchim + conchim.Width >= x_cap2 && x_conchim + conchim.Width <= x_cap2 + ongtren2.Width)
                {
                    if (y_conchim <= 1000 + y_ongtren2 || y_conchim + conchim.Height >= y_ongduoi2)
                    {
                        timer1.Stop();
                    }
                }
            }
            else
            {
                timer2.Stop();
                timer1.Stop();
            }
        }
        }


    }

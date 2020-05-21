using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            comboBox1.Text = "โสด";
            comboBox2.Text = "ไม่มี";
            comboBox3.Text = "ไม่มี";
        }
        public double money,sum1,sum2,sum3,sum4,sum5,sumall;

        private void button6_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            panel5.Visible = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            panel4.Visible = true;
            panel5.Visible = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            numericUpDown9_ValueChanged(sender, e);
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            panel4.Visible = true;
            panel5.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            numericUpDown9_ValueChanged(sender, e);
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            sum1 = 0;
            money = Convert.ToDouble(numericUpDown1.Value) * 12;
            double บุตร60 = Convert.ToDouble(numericUpDown2.Value) * 30000;
            double บุตร61 = Convert.ToDouble(numericUpDown3.Value);
            double ครรภ์ = Convert.ToDouble(numericUpDown4.Value);
            double พิการ = Convert.ToDouble(numericUpDown5.Value) * 60000;
            double sumn = money * 0.5;

            if (sumn > 100000)
            {
                sum1 += 100000;
            }
            else
            {
                sum1 += sumn;
            }

            if (comboBox1.Text == "คู่สมรสไม่มีรายได้")
            {
                sum1 += 120000;
            }
            else
            {
                sum1 += 60000;
            }
            if (บุตร61 > 0)
            {
                if(บุตร60 == 0)
                {
                    บุตร61 = ((บุตร61 - 1) * 60000) + 30000;
                }
                else
                {
                    บุตร61 = บุตร61 * 60000;
                }
            }
            else
            {
                บุตร61 = 0;
            }
            sum1 += บุตร61;

            if (comboBox2.Text == "ไม่มี")
            {
                sum1 += 0;
            }
            else if (comboBox2.Text == "บิดาหรือมารดา")
            {
                sum1 += 30000;
            }
            else if (comboBox2.Text == "บิดาเเละมารดา")
            {
                sum1 += 60000;
            }

            if (comboBox3.Text == "ไม่มี")
            {
                sum1 += 0;
            }
            else if (comboBox3.Text == "บิดาหรือมารดา")
            {
                sum1 += 30000;
            }
            else if (comboBox3.Text == "บิดาเเละมารดา")
            {
                sum1 += 60000;
            }
            sum1 += บุตร60 + ครรภ์ + พิการ;
            textBox3.Text = sum1.ToString();
            
        }
        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            sum4 = 0;
            double สังคม = Convert.ToDouble(numericUpDown12.Value);
            double ชีวิต = Convert.ToDouble(numericUpDown13.Value);
            double สุขภาพ1 = Convert.ToDouble(numericUpDown14.Value);
            double สุขภาพ2 = Convert.ToDouble(numericUpDown15.Value);
            double คู่สมรส = Convert.ToDouble(numericUpDown16.Value);
            double กอช = Convert.ToDouble(numericUpDown17.Value);
            double สำรอง = Convert.ToDouble(numericUpDown18.Value);
            double บำนาญ = Convert.ToDouble(numericUpDown19.Value);
            double กบข = Convert.ToDouble(numericUpDown20.Value);
            double LTF = Convert.ToDouble(numericUpDown21.Value);
            double RMF = Convert.ToDouble(numericUpDown22.Value);
            
            if(สุขภาพ1 + ชีวิต > 100000) 
            {
                sum4 += 100000;
            }
            else
            {
                sum4 += สุขภาพ1 + ชีวิต;
            }

            if((money * 0.15) > 490000)
            {
                numericUpDown18.Maximum = Convert.ToInt64(490000);
            }
            else
            {
                numericUpDown18.Maximum = Convert.ToInt64(money * 0.15);
            }

            if ((money * 0.15) > 500000)
            {
                numericUpDown20.Maximum = Convert.ToInt64(500000);
            }
            else
            {
                numericUpDown20.Maximum = Convert.ToInt64(money * 0.15);
            }

            if ((money * 0.15) > 200000)
            {
                numericUpDown19.Maximum = Convert.ToInt64(200000);
            }
            else
            {
                numericUpDown19.Maximum = Convert.ToInt64(money * 0.15);
            }

            if ((money * 0.15) > 500000)
            {
                numericUpDown21.Maximum = Convert.ToInt64(500000);
            }
            else
            {
                numericUpDown21.Maximum = Convert.ToInt64(money * 0.15);
            }

            if ((money * 0.15) > 500000)
            {
                numericUpDown22.Maximum = Convert.ToInt64(500000);
            }
            else
            {
                numericUpDown22.Maximum = Convert.ToInt64(money * 0.15);
            }

            if (บำนาญ + สำรอง + กบข + RMF  > 500000)
            {
                sum4 += 500000;
            }
            else
            {
                sum4 += บำนาญ + สำรอง + กบข + RMF ;
            }
            sum4 += สังคม + สุขภาพ2 + LTF + กอช + คู่สมรส;
            textBox6.Text = sum4.ToString();
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            sum3 = 0;
            money = Convert.ToDouble(numericUpDown1.Value) * 12;
            double sum1245 = ((money - (sum1 + sum2 + sum4 + sum5)) * 0.1) / 2;
            if (sum1245 < 0) { sum1245 = 0; }
            numericUpDown10.Maximum = Convert.ToInt32(sum1245);
            double บริจาคสนับสนุน = Convert.ToDouble(numericUpDown10.Value) * 2;

            double sum12459 = (money - (sum1 + sum2 + sum4 + sum5 + บริจาคสนับสนุน)) * 0.1;
            if (sum12459 < 0) { sum12459 = 0; }
            numericUpDown9.Maximum = Convert.ToInt32(sum12459);
            double บริจาคทั่วไป = Convert.ToDouble(numericUpDown9.Value);

            double บริจาคพรรคการเมือง = Convert.ToDouble(numericUpDown11.Value);
            sum3 = บริจาคพรรคการเมือง + บริจาคทั่วไป + บริจาคสนับสนุน;
            textBox5.Text = sum3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;
            numericUpDown11.Value = 0;
            numericUpDown12.Value = 0;
            numericUpDown13.Value = 0;
            numericUpDown14.Value = 0;
            numericUpDown15.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown17.Value = 0;
            numericUpDown18.Value = 0;
            numericUpDown19.Value = 0;
            numericUpDown20.Value = 0;
            numericUpDown21.Value = 0;
            numericUpDown22.Value = 0;
            numericUpDown23.Value = 0;
            numericUpDown24.Value = 0;
            numericUpDown25.Value = 0;
            numericUpDown26.Value = 0;
            numericUpDown27.Value = 0;
            numericUpDown28.Value = 0;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox5.Text = "0";
            sum3 = 0;
            sum1 = 0;
            sum2 = 0;
            sum4 = 0;
            sum5 = 0;
            sumall = 0;
        }

        private void numericUpDown23_ValueChanged(object sender, EventArgs e)
        {
            sum5 = 0;
            double ช้อป = Convert.ToDouble(numericUpDown23.Value);
            double ศึกษา = Convert.ToDouble(numericUpDown24.Value);
            double หนังสือ = Convert.ToDouble(numericUpDown25.Value);
            double โอทอป = Convert.ToDouble(numericUpDown26.Value);
            double หลัก = Convert.ToDouble(numericUpDown27.Value);
            double รอง = Convert.ToDouble(numericUpDown28.Value);

            if(หลัก + รอง > 20000)
            {
                sum5 += 20000;
            }
            else
            {
                sum5 += หลัก + รอง;
            }
            sum5 += ช้อป + ศึกษา + หนังสือ + โอทอป ;
            textBox7.Text = sum5.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            sumall = money - (sum1 + sum2 + sum3 + sum4 + sum5);
            if (sumall < 0)
            {
                sumall = 0;
            }
            textBox1.Text = sumall.ToString();
            if (sumall >= 0 && sumall <= 150000)
            {
                sumall = 0;
            }
            else if (sumall > 150000 && sumall <= 300000)
            {
                sumall = (sumall - 150000) * 0.05;
            }
            else if (sumall > 300000 && sumall <= 500000)
            {
                sumall = ((sumall - 300000) * 0.1) + 7500;
            }
            else if (sumall > 500000 && sumall <= 750000)
            {
                sumall = ((sumall - 500000) * 0.15) + 27500;
            }
            else if (sumall > 750000 && sumall <= 1000000)
            {
                sumall = ((sumall - 750000) * 0.2) + 65000;
            }
            else if (sumall > 1000000 && sumall <= 2000000)
            {
                sumall = ((sumall - 1000000) * 0.25) + 115000;
            }
            else if (sumall > 2000000 && sumall <= 5000000)
            {
                sumall = ((sumall - 2000000) * 0.3) + 365000;
            }
            else if (sumall > 5000000)
            {
                sumall = ((sumall - 5000000) * 0.35) + 1265000;
            }
            textBox2.Text = sumall.ToString();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            sum2 = 0;
            double ดอกบ้าน = Convert.ToDouble(numericUpDown6.Value);
            double บ้าน58 = Convert.ToDouble(numericUpDown7.Value);
            double บ้าน62 = Convert.ToDouble(numericUpDown8.Value);

            if(บ้าน58 > 3000000)
            {
                sum2 += 0;
            }
            else
            {
                sum2 += บ้าน58 * 0.04;
            }

            if(บ้าน62 > 5000000)
            {
                sum2 += 0;
            }
            else
            {
                sum2 += บ้าน62 * 0.04;
            }
            sum2 += ดอกบ้าน;
            textBox4.Text = sum2.ToString();
        }

        
    }
}

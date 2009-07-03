﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using e_Cafe.Reports;
using BusinessLogic;
using GUI;
using System.IO;



namespace ReportDebugger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doPrinting dp = new doPrinting();
            dp.setReportMaker(new BlokkReport(26));
            dp.doPreview();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DEFS.createLogger();
                DEFS.ConSTR = @"Data Source=ERNIE-HOME\SQLEXPRESS;Initial Catalog=E_CAFE;Persist Security Info=True;User ID=sa;Password=x";
                DEFS.DefProgramLocation = AppDomain.CurrentDomain.BaseDirectory;
                DEFS.R_SYSPAR = new SysParList();
                DEFS.LoadNyitottNap();
            }
            catch (Exception z)
            {
                MessageBox.Show(z.InnerException.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doPrinting dp = new doPrinting();
            dp.setReportMaker(new OsszesitoReport(2009,3,20));
            dp.doPreview();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V" + 5.ToString().PadLeft(8,'0') );
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = InputText.getInt2(true).ToString(); ;
        }
    }
}
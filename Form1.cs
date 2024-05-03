﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPegarData_Click_Click(object sender, EventArgs e)
        {
            textBoxDataInicial.Text = monthCalendar.SelectionStart.ToShortDateString();
            textBoxDataFinal.Text = monthCalendar.SelectionEnd.ToShortDateString();
            textBoxDataAtual.Text = monthCalendar.TodayDate.ToShortDateString();        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxDataInicialAuto.Text = monthCalendar.SelectionStart.ToShortDateString();
            textBoxDataFinalAuto.Text = monthCalendar.SelectionEnd.ToShortDateString();
            textBoxDataAtualAuto.Text = monthCalendar.TodayDate.ToShortDateString();
        }
    }
}

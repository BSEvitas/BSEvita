﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Eingabe : Form
    {
        public Eingabe()
        {
            InitializeComponent();

            // Der Title der Seite wird auf die Global variable gesetzt
            titleLabel.Text = Default.Title;
        }

        private void btnRechnen_Click(object sender, EventArgs e)
        {
            double firstNumber;
            double secondNumber;
            try
            {
                // Die Eingaben werden Convertiert.
                firstNumber = Convert.ToDouble(firstNumberInput.Text);
                secondNumber = Convert.ToDouble(secondNumberInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte überprüfen Sie ihrer Eingabe!", "Fehler: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Die globalen variablen werden gesetzt
            Default.receivedNumberOne = firstNumber;
            Default.receivedNumberTwo = secondNumber;
            Default.dataReceived = true;

            // Das Form schließen
            this.Close();
        }

        // Hier wird überprüft ob die letzte eingebe eh eine Nummer / ein . oder ein - ist.
        private void NumberInput_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

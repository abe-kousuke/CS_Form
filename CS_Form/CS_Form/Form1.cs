﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int j = 0;
            for (int i = 0; i < 5; i++)
            {
                TestButton testButton = new TestButton(0+j, 0, 100, 100);
                Controls.Add(testButton);

                TestButton testButton2 = new TestButton(100+j, 0, 100, 100);
                Controls.Add(testButton2);
                j+=200;
            }
            
        }
    }
}

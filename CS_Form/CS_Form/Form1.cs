using System;
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
        TestLabel _testLabel;

        public Form1()
        {
            InitializeComponent();

            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton( this, i,(i % 3) * 100, (i / 3) * 100, 100, 100);
                Controls.Add(testButton);
                
            }

             _testLabel= new TestLabel("ラベルです",100,300,100,500);
            Controls.Add(_testLabel);

            //Label label = new Label();
            //label.Location = new Point(30, 400);
            //label.Text = "ラベルです";
            //label = new Label();
            
        }

        /// <summary>
        /// ラベルの文字を更新する
        /// </summary>
        /// <param name="str"></param>
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }
    }
}

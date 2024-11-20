﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    internal class TestTextBox : TextBox
    {
        public TestTextBox(string str, int x, int y, int width, int height)
        {

            //ラベル内に文字を表示させる
            Text = str;

            //ボタンの生成場所を指定
            Location = new Point(x, y);

            //ボタンの大きさを指定
            Size = new Size(width, height);
        }

        /// <summary>
        /// ラベルの文字更新関数
        /// </summary>
        /// <param name="str"></param>
        public void TextUpdate(string str)
        {
            Text = str;
        }

        public string TextReplacement(string str)
        {
            string temp = Text;

            Text = str;

            return temp;
        }

    }
}

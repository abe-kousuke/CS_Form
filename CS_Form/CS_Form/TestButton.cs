using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    internal class TestButton : Button
    {
        Form1 _form1;
        public TestButton(Form1 form1, int i ,int x, int y,int width, int height)
        {
            _form1 = form1;

            //ClickイベントにOnClick関数を登録
            Click += OnClick;

            string[] iro = new string[10] {"あか","あお","きいろ","みどり","しろ","くろ","ちゃいろ","ピンク","むらさき","きみどり"};

            //ボタン内に文字を表示させる
            Text = iro[i];

            //ボタンの生成場所を指定
            Location = new Point(x,y);

            //ボタンの大きさを指定
            Size = new Size(width,height);
        }　

        public void OnClick(object sender, EventArgs e)
        {
            _form1.LabelTextUpdate(Text);
        }
    }
}

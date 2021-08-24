using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string _turn = "Player 1";

        //private void button11_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(button00.Text))
        //    {
        //        return;
        //    }
        //    if (_turn.Equals("Player 1"))
        //    {
        //        button11.Text = "X";
        //        _turn = "Player 2";
        //    }
        //    else
        //    {
        //        button11.Text = "O";
        //        _turn = "Player 1";
        //    }
        //    turn.Text = "Turn: " + _turn;
        //}

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        //private void button00_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(button00.Text))
        //    {
        //        return;
        //    }
        //    if (_turn.Equals("Player 1")){
        //        button00.Text = "X";
        //        _turn = "Player 2";
        //    }
        //    else
        //    {
        //        button00.Text = "O";
        //        _turn = "Player 1";
        //    }
        //    turn.Text = "Turn: " + _turn;
        //}

        //private void button01_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(button01.Text))
        //    {
        //        return;
        //    }
        //    if (_turn.Equals("Player 1"))
        //    {
        //        button01.Text = "X";
        //        _turn = "Player 2";
        //    }
        //    else
        //    {
        //        button01.Text = "O";
        //        _turn = "Player 1";
        //    }
        //    turn.Text = "Turn: " + _turn;
        //}

        //private void button02_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(button00.Text))
        //    {
        //        return;
        //    }
        //    if (_turn.Equals("Player 1"))
        //    {
        //        button02.Text = "X";
        //        _turn = "Player 2";
        //    }
        //    else
        //    {
        //        button02.Text = "O";
        //        _turn = "Player 1";
        //    }
        //    turn.Text = "Turn: " + _turn;
        //}

        //private void button10_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(button00.Text))
        //    {
        //        return;
        //    }
        //    if (_turn.Equals("Player 1"))
        //    {
        //        button10.Text = "X";
        //        _turn = "Player 2";
        //    }
        //    else
        //    {
        //        button10.Text = "O";
        //        _turn = "Player 1";
        //    }
        //    turn.Text = "Turn: " + _turn;
        //}

        //private void button21_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(button00.Text))
        //    {
        //        return;
        //    }
        //    if (_turn.Equals("Player 1"))
        //    {
        //        button21.Text = "X";
        //        _turn = "Player 2";
        //    }
        //    else
        //    {
        //        button21.Text = "O";
        //        _turn = "Player 1";
        //    }
        //    turn.Text = "Turn: " + _turn;
        //}

        //private void button20_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(button00.Text))
        //    {
        //        return;
        //    }
        //    if (_turn.Equals("Player 1"))
        //    {
        //        button20.Text = "X";
        //        _turn = "Player 2";
        //    }
        //    else
        //    {
        //        button20.Text = "O";
        //        _turn = "Player 1";
        //    }
        //    turn.Text = "Turn: " + _turn;
        //}

        //private void button12_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(button00.Text))
        //    {
        //        return;
        //    }
        //    if (_turn.Equals("Player 1"))
        //    {
        //        button12.Text = "X";
        //        _turn = "Player 2";
        //    }
        //    else
        //    {
        //        button12.Text = "O";
        //        _turn = "Player 1";
        //    }
        //    turn.Text = "Turn: " + _turn;
        //}

        //private void button22_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(button00.Text))
        //    {
        //        return;
        //    }
        //    if (_turn.Equals("Player 1"))
        //    {
        //        button22.Text = "X";
        //        _turn = "Player 2";
        //    }
        //    else
        //    {
        //        button22.Text = "O";
        //        _turn = "Player 1";
        //    }
        //    turn.Text = "Turn: " + _turn;
        //}

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!string.IsNullOrEmpty(button.Text))
            {
                return;
            }
            if (_turn.Equals("Player 1"))
            {
                button.Text = "X";
                _turn = "Player 2";
            }
            else
            {
                button.Text = "O";
                _turn = "Player 1";
            }
            turn.Text = "Turn: " + _turn;
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            button00.Text = "";
            button01.Text = "";
            button02.Text = "";
            button12.Text = "";
            button12.Text = "";
            button10.Text = "";
            button22.Text = "";
            button21.Text = "";
            button20.Text = "";
            turn.Text = "Turn: Player 1";
            _turn = "Turn: Player 1";

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace _5task3
{
    public partial class FormMain : Form
    {
        IMap<int, string> a;
        public FormMain()
        {
            InitializeComponent();
            buttonAdd.Enabled = false;
            MethodsToolStripMenuItem.Enabled = false;
            utilsToolStripMenuItem.Enabled = false;
            Application.Idle += OnIdle;
            cbBase.SelectedIndex = 0;
        }

        private void OnIdle(object sender, EventArgs e)
        {
            if (tAddKey.Text != string.Empty && tAddValue.Text != string.Empty)
            {
                buttonAdd.Enabled = true;
            }
            else
            {
                buttonAdd.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MethodsToolStripMenuItem.Enabled = true;
            utilsToolStripMenuItem.Enabled = true;
            if (cbBase.SelectedIndex == 0)
            {
                 a = new ArrayMap<int, string>();
                 MessageBox.Show("Создано множество на основе массива");
            }
            else if (cbBase.SelectedIndex == 1)
            {
                 a = new LinkedMap<int, string>();
                 MessageBox.Show("Создано множество на основе связного списка");
            }
            else if (cbBase.SelectedIndex == 2)
            {
                a = new HashMap<int, string>();
                MessageBox.Show("Создано множество на основе алгоритма хеширования");
            }
            else if (cbBase.SelectedIndex == 3)
            {
                if (a != null)
                {
                    a = new UnmutableMap<int, string>(a);
                    MessageBox.Show("Создано множество на основе неизменяемого множества");
                }
                else a = new UnmutableMap<int, string>();
                MessageBox.Show("Создано множество на основе неизменяемого множества, но оно пусто");
            }

            MainPanel.Visible = true;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (tCheckKey.Text != "" && a.ContainsKey(Convert.ToInt32(tCheckKey.Text)))
                    MessageBox.Show("Такой ключ присутствует в множестве");
                else MessageBox.Show("Такой ключ отсутствует в множестве");
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
            if (tCheckValue.Text != "" && a.ContainsValue(tCheckValue.Text))
                MessageBox.Show("Такое значение присутствует в множестве");
            else MessageBox.Show("Такое значение отсутствует в множестве");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
               value =  Convert.ToInt32(tRemove.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            if (!a.isEmpty && a.ContainsKey(value))
            {
                try
                {
                    if (tRemove.Text != "")
                        a.Remove(Convert.ToInt32(tRemove.Text));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Элемент удален");
            }
            else
            {
                MessageBox.Show("Элемент не найден");
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (tIndex.Text != "")
                {
                    string value = a[Convert.ToInt32(tIndex.Text)];
                    if (value != null) MessageBox.Show(value); else MessageBox.Show("Элемента с таким ключом не существует!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Элемента с таким ключом не существует!\n"+ex.Message);
            }
        }

        bool EqualStrings<K, V>(IEntry<K, V> source) where K : IComparable where V : IComparable
        {
            if (source.Value == null || source.Key == null) return false;
            return source.Key.ToString().Equals(source.Value.ToString());
        }

        void ToDefault<K, V>(IEntry<K, V> source) where K : IComparable where V : IComparable 
        {
            source.Value = default(V);
        }



        private void utilsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                a.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ElemCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Количество элементов: " + a.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckEmptyНаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.isEmpty) MessageBox.Show("Множество пусто");
                else MessageBox.Show("Множество не пусто");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void forEachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckDelegate<int, String> d = new CheckDelegate<int, String>(EqualStrings);
            if (MapUtils.CheckForAll<int, string>(a, d)) MessageBox.Show("Все элементы множества удовлетворяют условию");
            else MessageBox.Show("Не все элементы множества удовлетворяют условию");
        }

        private void existsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckDelegate<int, String> d = new CheckDelegate<int, String>(EqualStrings);
            if (MapUtils.Exists<int, string>(a, d)) MessageBox.Show("Элемент, удовлетворяющий условию, присутствует в множестве");
            else MessageBox.Show("Элемент, удовлетворяющий условию, отсутствует в множестве");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                a.Put(Convert.ToInt32(tAddKey.Text), tAddValue.Text);
                MessageBox.Show("Ключ " + tAddKey.Text + " добавлен, значение " + tAddValue.Text + " добавлено");
                tAddKey.Text = string.Empty;
                tAddValue.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckDelegate<int, String> d = new CheckDelegate<int, String>(EqualStrings);
            IMap<int, string> b = MapUtils.FindAll<int, string>(a, d, MapUtils.LinkedMapConstructor<int, string>());
            a = b;
        }
        //foreach
        private void forEachToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActionDelegate<int, string> d = new ActionDelegate<int, string>(ToDefault);
            MapUtils.ForEach<int, string>(a, d);
        }
    }
}

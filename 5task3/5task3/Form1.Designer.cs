namespace _5task3
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOK = new System.Windows.Forms.Button();
            this.cbBase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tAddKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tAddValue = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tCheckKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tCheckValue = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tRemove = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tIndex = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MethodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forEachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ElemCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckEmptyНаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forEachToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(447, 25);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(70, 28);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbBase
            // 
            this.cbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBase.FormattingEnabled = true;
            this.cbBase.Items.AddRange(new object[] {
            "Массива",
            "Связанного списка",
            "Алгоритма хеширования",
            "Неизменяемого множества"});
            this.cbBase.Location = new System.Drawing.Point(280, 27);
            this.cbBase.Name = "cbBase";
            this.cbBase.Size = new System.Drawing.Size(150, 21);
            this.cbBase.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Создать ассоциативное множество на основе:";
            // 
            // tAddKey
            // 
            this.tAddKey.Location = new System.Drawing.Point(110, 45);
            this.tAddKey.Name = "tAddKey";
            this.tAddKey.Size = new System.Drawing.Size(115, 20);
            this.tAddKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Добавить:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(377, 46);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 22);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "OK";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tAddValue
            // 
            this.tAddValue.Location = new System.Drawing.Point(240, 45);
            this.tAddValue.Name = "tAddValue";
            this.tAddValue.Size = new System.Drawing.Size(130, 20);
            this.tAddValue.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Проверить вхождение по ключу:";
            // 
            // tCheckKey
            // 
            this.tCheckKey.Location = new System.Drawing.Point(240, 99);
            this.tCheckKey.Name = "tCheckKey";
            this.tCheckKey.Size = new System.Drawing.Size(131, 20);
            this.tCheckKey.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Проверить вхождение по значению:";
            // 
            // tCheckValue
            // 
            this.tCheckValue.Location = new System.Drawing.Point(240, 134);
            this.tCheckValue.Name = "tCheckValue";
            this.tCheckValue.Size = new System.Drawing.Size(131, 20);
            this.tCheckValue.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(377, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 28);
            this.button4.TabIndex = 11;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Удалить элемент по ключу:";
            // 
            // tRemove
            // 
            this.tRemove.Location = new System.Drawing.Point(240, 167);
            this.tRemove.Name = "tRemove";
            this.tRemove.Size = new System.Drawing.Size(131, 20);
            this.tRemove.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(377, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 28);
            this.button5.TabIndex = 14;
            this.button5.Text = "OK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Получить значение по ключу:";
            // 
            // tIndex
            // 
            this.tIndex.Location = new System.Drawing.Point(240, 207);
            this.tIndex.Name = "tIndex";
            this.tIndex.Size = new System.Drawing.Size(131, 20);
            this.tIndex.TabIndex = 20;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(377, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 28);
            this.button8.TabIndex = 22;
            this.button8.Text = "OK";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "(ключ)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "(значение)";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.tAddKey);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.buttonAdd);
            this.MainPanel.Controls.Add(this.button8);
            this.MainPanel.Controls.Add(this.tAddValue);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.tIndex);
            this.MainPanel.Controls.Add(this.button3);
            this.MainPanel.Controls.Add(this.tCheckKey);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.button4);
            this.MainPanel.Controls.Add(this.tRemove);
            this.MainPanel.Controls.Add(this.tCheckValue);
            this.MainPanel.Controls.Add(this.button5);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Location = new System.Drawing.Point(31, 62);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(486, 261);
            this.MainPanel.TabIndex = 25;
            this.MainPanel.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MethodsToolStripMenuItem,
            this.utilsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MethodsToolStripMenuItem
            // 
            this.MethodsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forEachToolStripMenuItem,
            this.existsToolStripMenuItem,
            this.findAllToolStripMenuItem,
            this.forEachToolStripMenuItem1});
            this.MethodsToolStripMenuItem.Name = "MethodsToolStripMenuItem";
            this.MethodsToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.MethodsToolStripMenuItem.Text = "Методы";
            // 
            // forEachToolStripMenuItem
            // 
            this.forEachToolStripMenuItem.Name = "forEachToolStripMenuItem";
            this.forEachToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.forEachToolStripMenuItem.Text = "CheckForAll";
            this.forEachToolStripMenuItem.Click += new System.EventHandler(this.forEachToolStripMenuItem_Click);
            // 
            // existsToolStripMenuItem
            // 
            this.existsToolStripMenuItem.Name = "existsToolStripMenuItem";
            this.existsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.existsToolStripMenuItem.Text = "Exists";
            this.existsToolStripMenuItem.Click += new System.EventHandler(this.existsToolStripMenuItem_Click);
            // 
            // utilsToolStripMenuItem
            // 
            this.utilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearToolStripMenuItem,
            this.ElemCountToolStripMenuItem,
            this.CheckEmptyНаToolStripMenuItem});
            this.utilsToolStripMenuItem.Name = "utilsToolStripMenuItem";
            this.utilsToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.utilsToolStripMenuItem.Text = "Утилиты";
            this.utilsToolStripMenuItem.Click += new System.EventHandler(this.utilsToolStripMenuItem_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.ClearToolStripMenuItem.Text = "Очистить";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // ElemCountToolStripMenuItem
            // 
            this.ElemCountToolStripMenuItem.Name = "ElemCountToolStripMenuItem";
            this.ElemCountToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.ElemCountToolStripMenuItem.Text = "Узнать кол-во элементов";
            this.ElemCountToolStripMenuItem.Click += new System.EventHandler(this.ElemCountToolStripMenuItem_Click);
            // 
            // CheckEmptyНаToolStripMenuItem
            // 
            this.CheckEmptyНаToolStripMenuItem.Name = "CheckEmptyНаToolStripMenuItem";
            this.CheckEmptyНаToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.CheckEmptyНаToolStripMenuItem.Text = "Проверить на пустоту";
            this.CheckEmptyНаToolStripMenuItem.Click += new System.EventHandler(this.CheckEmptyНаToolStripMenuItem_Click);
            // 
            // findAllToolStripMenuItem
            // 
            this.findAllToolStripMenuItem.Name = "findAllToolStripMenuItem";
            this.findAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findAllToolStripMenuItem.Text = "FindAll";
            this.findAllToolStripMenuItem.Click += new System.EventHandler(this.findAllToolStripMenuItem_Click);
            // 
            // forEachToolStripMenuItem1
            // 
            this.forEachToolStripMenuItem1.Name = "forEachToolStripMenuItem1";
            this.forEachToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.forEachToolStripMenuItem1.Text = "ForEach";
            this.forEachToolStripMenuItem1.Click += new System.EventHandler(this.forEachToolStripMenuItem1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(544, 334);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBase);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест библиотеки для работы с ассоциативным множеством";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox cbBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tAddKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox tAddValue;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tCheckKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tCheckValue;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tRemove;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tIndex;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MethodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ElemCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckEmptyНаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forEachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forEachToolStripMenuItem1;
    }
}


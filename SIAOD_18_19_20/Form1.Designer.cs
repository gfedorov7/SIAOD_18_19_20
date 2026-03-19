namespace SIAOD_18_19_20;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        addNew = new System.Windows.Forms.Button();
        clearQueue = new System.Windows.Forms.Button();
        getMax = new System.Windows.Forms.Button();
        createQueue = new System.Windows.Forms.Button();
        newNum = new System.Windows.Forms.NumericUpDown();
        changePriority = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        numericUpDown2 = new System.Windows.Forms.NumericUpDown();
        label2 = new System.Windows.Forms.Label();
        numericUpDown3 = new System.Windows.Forms.NumericUpDown();
        label3 = new System.Windows.Forms.Label();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        label4 = new System.Windows.Forms.Label();
        dataGridView2 = new System.Windows.Forms.DataGridView();
        dataGridView3 = new System.Windows.Forms.DataGridView();
        label5 = new System.Windows.Forms.Label();
        exit = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)newNum).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
        SuspendLayout();
        // 
        // addNew
        // 
        addNew.Location = new System.Drawing.Point(12, 47);
        addNew.Name = "addNew";
        addNew.Size = new System.Drawing.Size(251, 23);
        addNew.TabIndex = 0;
        addNew.Text = "Вставить новый";
        addNew.UseVisualStyleBackColor = true;
        addNew.Click += addNew_Click;
        // 
        // clearQueue
        // 
        clearQueue.Location = new System.Drawing.Point(269, 12);
        clearQueue.Name = "clearQueue";
        clearQueue.Size = new System.Drawing.Size(267, 26);
        clearQueue.TabIndex = 1;
        clearQueue.Text = "Очистить очередь";
        clearQueue.UseVisualStyleBackColor = true;
        clearQueue.Click += clearQueue_Click;
        // 
        // getMax
        // 
        getMax.Location = new System.Drawing.Point(542, 12);
        getMax.Name = "getMax";
        getMax.Size = new System.Drawing.Size(251, 26);
        getMax.TabIndex = 2;
        getMax.Text = "Извлечь наибольший";
        getMax.UseVisualStyleBackColor = true;
        getMax.Click += getMax_Click;
        // 
        // createQueue
        // 
        createQueue.Location = new System.Drawing.Point(12, 12);
        createQueue.Name = "createQueue";
        createQueue.Size = new System.Drawing.Size(251, 26);
        createQueue.TabIndex = 3;
        createQueue.Text = "Создать очередь";
        createQueue.UseVisualStyleBackColor = true;
        createQueue.Click += createQueue_Click;
        // 
        // newNum
        // 
        newNum.Location = new System.Drawing.Point(269, 47);
        newNum.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
        newNum.Name = "newNum";
        newNum.Size = new System.Drawing.Size(63, 27);
        newNum.TabIndex = 4;
        newNum.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // changePriority
        // 
        changePriority.Location = new System.Drawing.Point(338, 46);
        changePriority.Name = "changePriority";
        changePriority.Size = new System.Drawing.Size(198, 24);
        changePriority.TabIndex = 5;
        changePriority.Text = "Изменить приоритет";
        changePriority.UseVisualStyleBackColor = true;
        changePriority.Click += changePriority_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(542, 46);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(46, 24);
        label1.TabIndex = 6;
        label1.Text = "c (idx)";
        // 
        // numericUpDown2
        // 
        numericUpDown2.Location = new System.Drawing.Point(594, 46);
        numericUpDown2.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new System.Drawing.Size(58, 27);
        numericUpDown2.TabIndex = 7;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(658, 46);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(66, 23);
        label2.TabIndex = 8;
        label2.Text = "на (value)";
        // 
        // numericUpDown3
        // 
        numericUpDown3.Increment = new decimal(new int[] { 10, 0, 0, 0 });
        numericUpDown3.Location = new System.Drawing.Point(730, 46);
        numericUpDown3.Name = "numericUpDown3";
        numericUpDown3.Size = new System.Drawing.Size(58, 27);
        numericUpDown3.TabIndex = 9;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(16, 82);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(776, 34);
        label3.TabIndex = 10;
        label3.Text = "Представление в виде массива";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // dataGridView1
        // 
        dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
        dataGridView1.ColumnHeadersHeight = 20;
        dataGridView1.Location = new System.Drawing.Point(16, 119);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(752, 32);
        dataGridView1.TabIndex = 11;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(16, 165);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(776, 34);
        label4.TabIndex = 12;
        label4.Text = "Представление в виде дерева";
        label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // dataGridView2
        // 
        dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
        dataGridView2.ColumnHeadersHeight = 20;
        dataGridView2.Location = new System.Drawing.Point(16, 193);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.RowHeadersWidth = 51;
        dataGridView2.Size = new System.Drawing.Size(752, 122);
        dataGridView2.TabIndex = 13;
        // 
        // dataGridView3
        // 
        dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
        dataGridView3.ColumnHeadersHeight = 20;
        dataGridView3.Location = new System.Drawing.Point(16, 355);
        dataGridView3.Name = "dataGridView3";
        dataGridView3.RowHeadersWidth = 51;
        dataGridView3.Size = new System.Drawing.Size(752, 32);
        dataGridView3.TabIndex = 14;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(16, 318);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(776, 34);
        label5.TabIndex = 15;
        label5.Text = "Результат выборки";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // exit
        // 
        exit.Location = new System.Drawing.Point(308, 404);
        exit.Name = "exit";
        exit.Size = new System.Drawing.Size(198, 24);
        exit.TabIndex = 16;
        exit.Text = "Выход";
        exit.UseVisualStyleBackColor = true;
        exit.Click += exit_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(exit);
        Controls.Add(label5);
        Controls.Add(dataGridView3);
        Controls.Add(dataGridView2);
        Controls.Add(label4);
        Controls.Add(dataGridView1);
        Controls.Add(label3);
        Controls.Add(numericUpDown3);
        Controls.Add(label2);
        Controls.Add(numericUpDown2);
        Controls.Add(label1);
        Controls.Add(changePriority);
        Controls.Add(newNum);
        Controls.Add(createQueue);
        Controls.Add(getMax);
        Controls.Add(clearQueue);
        Controls.Add(addNew);
        Location = new System.Drawing.Point(15, 15);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Text = "Федоров 24вп1";
        ((System.ComponentModel.ISupportInitialize)newNum).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dataGridView3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button exit;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DataGridView dataGridView2;

    private System.Windows.Forms.Button addNew;
    private System.Windows.Forms.Button clearQueue;
    private System.Windows.Forms.Button getMax;
    private System.Windows.Forms.Button createQueue;
    private System.Windows.Forms.NumericUpDown newNum;
    private System.Windows.Forms.Button changePriority;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUpDown3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
}
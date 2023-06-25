namespace Листинг_10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.treeDirectory = new System.Windows.Forms.TreeView();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = " 10.1. Получение списка логических дисков";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(881, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(325, 433);
            this.listBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = " 10.2. Получение типа диска и его свойств";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "10.3. Список папок";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "10.4. Список папок по маске";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 39);
            this.button5.TabIndex = 5;
            this.button5.Text = " 10.5. Проверка существования папки";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 219);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(204, 30);
            this.button6.TabIndex = 6;
            this.button6.Text = "10.6. Переименование папки";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 255);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(204, 30);
            this.button7.TabIndex = 7;
            this.button7.Text = "10.7. Удаление пустой папки";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 291);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(204, 30);
            this.button8.TabIndex = 8;
            this.button8.Text = "10.8. Выбор папки";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 327);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(204, 39);
            this.button9.TabIndex = 9;
            this.button9.Text = "10.9. Получение путей к специальным папкам";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 372);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(204, 48);
            this.button10.TabIndex = 10;
            this.button10.Text = "10.10. Получение свойств папки";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(222, 12);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(204, 30);
            this.button11.TabIndex = 11;
            this.button11.Text = " 10.11. Получение размеров папки";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(222, 48);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(204, 39);
            this.button12.TabIndex = 12;
            this.button12.Text = "10.12. Создание древовидной структуры папок";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(222, 93);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(204, 39);
            this.button13.TabIndex = 13;
            this.button13.Text = " 10.13. Получение списка файлов в папке";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(222, 138);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(204, 39);
            this.button14.TabIndex = 14;
            this.button14.Text = "10.14. Получение списка папок и файлов";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(222, 183);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(204, 39);
            this.button15.TabIndex = 15;
            this.button15.Text = "10.15. Получение списка файлов по маске";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(222, 228);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(204, 39);
            this.button16.TabIndex = 16;
            this.button16.Text = "10.16. Проверка существования файла";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(222, 273);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(204, 39);
            this.button17.TabIndex = 17;
            this.button17.Text = "10.17. Получение имени файла из полного пути";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(222, 318);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(204, 30);
            this.button18.TabIndex = 18;
            this.button18.Text = "10.18. Получение расширения файла";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(222, 354);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(204, 30);
            this.button19.TabIndex = 19;
            this.button19.Text = "10.19. Установка атрибутов файла";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(222, 390);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(204, 30);
            this.button20.TabIndex = 20;
            this.button20.Text = "10.20. Получение свойств файла";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // treeDirectory
            // 
            this.treeDirectory.Location = new System.Drawing.Point(510, 12);
            this.treeDirectory.Name = "treeDirectory";
            this.treeDirectory.Size = new System.Drawing.Size(365, 433);
            this.treeDirectory.TabIndex = 21;
            this.treeDirectory.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeDirectory_BeforeExpand);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(12, 456);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(204, 39);
            this.button21.TabIndex = 22;
            this.button21.Text = "10.21. Извлечение информации о файле";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(12, 501);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(204, 30);
            this.button22.TabIndex = 23;
            this.button22.Text = "10.22. Создание временного файла";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(12, 537);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(204, 39);
            this.button23.TabIndex = 24;
            this.button23.Text = "10.23. Создание уникального имени для файла ";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(12, 582);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(204, 39);
            this.button24.TabIndex = 25;
            this.button24.Text = "10.24. Создание уникального текстового файла";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(12, 627);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(204, 30);
            this.button25.TabIndex = 26;
            this.button25.Text = "10.25. Ограничение доступа к файлу";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(12, 663);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(204, 48);
            this.button26.TabIndex = 27;
            this.button26.Text = "10.26. Второй способ ограничения доступа";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(222, 456);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(204, 30);
            this.button27.TabIndex = 28;
            this.button27.Text = "10.27. Работа с бинарными файлами";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(222, 492);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(204, 39);
            this.button28.TabIndex = 29;
            this.button28.Text = "10.28. Чтение и запись текстовых файлов";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(222, 537);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(204, 39);
            this.button29.TabIndex = 30;
            this.button29.Text = "10.29. Добавление текста в существующий файл";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(222, 582);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(204, 39);
            this.button30.TabIndex = 31;
            this.button30.Text = "10.30. Построчное чтение текстового файла";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(222, 627);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(204, 39);
            this.button31.TabIndex = 32;
            this.button31.Text = "10.31. Загрузка текстового файла в список";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(222, 672);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(204, 39);
            this.button32.TabIndex = 33;
            this.button32.Text = "10.32. Чтение данных из текстового файла (старый способ)";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(510, 456);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(204, 39);
            this.button33.TabIndex = 34;
            this.button33.Text = "10.33. Чтение данных из текстового файла (новый способ)";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(510, 501);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(204, 39);
            this.button34.TabIndex = 35;
            this.button34.Text = "10.34. Получение короткого и длинного имени файла";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(510, 546);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(204, 30);
            this.button35.TabIndex = 36;
            this.button35.Text = "10.35. Удаление файла в корзину";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(510, 582);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(204, 39);
            this.button36.TabIndex = 37;
            this.button36.Text = "10.36. Удаление файла через управляемый код";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(720, 528);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(204, 30);
            this.button37.TabIndex = 38;
            this.button37.Text = "10.27. Работа с бинарными файлами";
            this.button37.UseVisualStyleBackColor = true;
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(720, 492);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(204, 30);
            this.button38.TabIndex = 39;
            this.button38.Text = "10.27. Работа с бинарными файлами";
            this.button38.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(720, 456);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(204, 30);
            this.button39.TabIndex = 40;
            this.button39.Text = "10.27. Работа с бинарными файлами";
            this.button39.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 734);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.treeDirectory);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TreeView treeDirectory;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
    }
}


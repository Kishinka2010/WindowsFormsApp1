
namespace WindowsFormsApp1
{
    partial class DataForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управляющийТранспортнымСредствомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пунктДоставкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршрутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.транспортноеСтредствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходВОконоРегестрацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходВОкноВходаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.обПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.обПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1063, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьДанныеToolStripMenuItem,
            this.редактироватьДанныеToolStripMenuItem,
            this.поискToolStripMenuItem1});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // обновитьДанныеToolStripMenuItem
            // 
            this.обновитьДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентToolStripMenuItem,
            this.управляющийТранспортнымСредствомToolStripMenuItem,
            this.операторToolStripMenuItem,
            this.заказToolStripMenuItem,
            this.пунктДоставкиToolStripMenuItem,
            this.товарToolStripMenuItem,
            this.маршрутToolStripMenuItem,
            this.отправительToolStripMenuItem,
            this.транспортноеСтредствоToolStripMenuItem});
            this.обновитьДанныеToolStripMenuItem.Name = "обновитьДанныеToolStripMenuItem";
            this.обновитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.обновитьДанныеToolStripMenuItem.Text = "Обновить данные ";
            this.обновитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.обновитьДанныеToolStripMenuItem_Click);
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(377, 26);
            this.клиентToolStripMenuItem.Text = "Клиент";
            this.клиентToolStripMenuItem.Click += new System.EventHandler(this.клиентToolStripMenuItem_Click_1);
            // 
            // управляющийТранспортнымСредствомToolStripMenuItem
            // 
            this.управляющийТранспортнымСредствомToolStripMenuItem.Name = "управляющийТранспортнымСредствомToolStripMenuItem";
            this.управляющийТранспортнымСредствомToolStripMenuItem.Size = new System.Drawing.Size(377, 26);
            this.управляющийТранспортнымСредствомToolStripMenuItem.Text = "Управляющий транспортным средством";
            this.управляющийТранспортнымСредствомToolStripMenuItem.Click += new System.EventHandler(this.управляющийТранспортнымСредствомToolStripMenuItem_Click_1);
            // 
            // операторToolStripMenuItem
            // 
            this.операторToolStripMenuItem.Name = "операторToolStripMenuItem";
            this.операторToolStripMenuItem.Size = new System.Drawing.Size(377, 26);
            this.операторToolStripMenuItem.Text = "Оператор";
            this.операторToolStripMenuItem.Click += new System.EventHandler(this.операторToolStripMenuItem_Click_1);
            // 
            // заказToolStripMenuItem
            // 
            this.заказToolStripMenuItem.Name = "заказToolStripMenuItem";
            this.заказToolStripMenuItem.Size = new System.Drawing.Size(377, 26);
            this.заказToolStripMenuItem.Text = "Заказ";
            this.заказToolStripMenuItem.Click += new System.EventHandler(this.заказToolStripMenuItem_Click_1);
            // 
            // пунктДоставкиToolStripMenuItem
            // 
            this.пунктДоставкиToolStripMenuItem.Name = "пунктДоставкиToolStripMenuItem";
            this.пунктДоставкиToolStripMenuItem.Size = new System.Drawing.Size(377, 26);
            this.пунктДоставкиToolStripMenuItem.Text = "Пункт доставки";
            this.пунктДоставкиToolStripMenuItem.Click += new System.EventHandler(this.пунктДоставкиToolStripMenuItem_Click_1);
            // 
            // товарToolStripMenuItem
            // 
            this.товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            this.товарToolStripMenuItem.Size = new System.Drawing.Size(377, 26);
            this.товарToolStripMenuItem.Text = "Товар";
            this.товарToolStripMenuItem.Click += new System.EventHandler(this.товарToolStripMenuItem_Click);
            // 
            // маршрутToolStripMenuItem
            // 
            this.маршрутToolStripMenuItem.Name = "маршрутToolStripMenuItem";
            this.маршрутToolStripMenuItem.Size = new System.Drawing.Size(377, 26);
            this.маршрутToolStripMenuItem.Text = "Маршрут";
            this.маршрутToolStripMenuItem.Click += new System.EventHandler(this.маршрутToolStripMenuItem_Click);
            // 
            // отправительToolStripMenuItem
            // 
            this.отправительToolStripMenuItem.Name = "отправительToolStripMenuItem";
            this.отправительToolStripMenuItem.Size = new System.Drawing.Size(377, 26);
            this.отправительToolStripMenuItem.Text = "Отправитель";
            this.отправительToolStripMenuItem.Click += new System.EventHandler(this.отправительToolStripMenuItem_Click);
            // 
            // транспортноеСтредствоToolStripMenuItem
            // 
            this.транспортноеСтредствоToolStripMenuItem.Name = "транспортноеСтредствоToolStripMenuItem";
            this.транспортноеСтредствоToolStripMenuItem.Size = new System.Drawing.Size(377, 26);
            this.транспортноеСтредствоToolStripMenuItem.Text = "Транспортное стредство";
            this.транспортноеСтредствоToolStripMenuItem.Click += new System.EventHandler(this.транспортноеСтредствоToolStripMenuItem_Click);
            // 
            // редактироватьДанныеToolStripMenuItem
            // 
            this.редактироватьДанныеToolStripMenuItem.Name = "редактироватьДанныеToolStripMenuItem";
            this.редактироватьДанныеToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.редактироватьДанныеToolStripMenuItem.Text = "Редактировать данные";
            this.редактироватьДанныеToolStripMenuItem.Click += new System.EventHandler(this.редактироватьДанныеToolStripMenuItem_Click_1);
            // 
            // поискToolStripMenuItem1
            // 
            this.поискToolStripMenuItem1.Name = "поискToolStripMenuItem1";
            this.поискToolStripMenuItem1.Size = new System.Drawing.Size(251, 26);
            this.поискToolStripMenuItem1.Text = "Поиск";
            this.поискToolStripMenuItem1.Click += new System.EventHandler(this.поискToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходИзПрограммыToolStripMenuItem,
            this.выходВОконоРегестрацииToolStripMenuItem,
            this.выходВОкноВходаToolStripMenuItem});
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // выходИзПрограммыToolStripMenuItem
            // 
            this.выходИзПрограммыToolStripMenuItem.Name = "выходИзПрограммыToolStripMenuItem";
            this.выходИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.выходИзПрограммыToolStripMenuItem.Text = "Выход из программы";
            this.выходИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.выходИзПрограммыToolStripMenuItem_Click);
            // 
            // выходВОконоРегестрацииToolStripMenuItem
            // 
            this.выходВОконоРегестрацииToolStripMenuItem.Name = "выходВОконоРегестрацииToolStripMenuItem";
            this.выходВОконоРегестрацииToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.выходВОконоРегестрацииToolStripMenuItem.Text = "Выход в окно регистрации";
            this.выходВОконоРегестрацииToolStripMenuItem.Click += new System.EventHandler(this.выходВОконоРегестрацииToolStripMenuItem_Click);
            // 
            // выходВОкноВходаToolStripMenuItem
            // 
            this.выходВОкноВходаToolStripMenuItem.Name = "выходВОкноВходаToolStripMenuItem";
            this.выходВОкноВходаToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.выходВОкноВходаToolStripMenuItem.Text = "Выход в окно входа";
            this.выходВОкноВходаToolStripMenuItem.Click += new System.EventHandler(this.выходВОкноВходаToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Данные:";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(16, 97);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(1034, 433);
            this.dataGrid.TabIndex = 2;
            // 
            // обПрограммеToolStripMenuItem
            // 
            this.обПрограммеToolStripMenuItem.Name = "обПрограммеToolStripMenuItem";
            this.обПрограммеToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.обПрограммеToolStripMenuItem.Text = "Об программе";
            this.обПрограммеToolStripMenuItem.Click += new System.EventHandler(this.обПрограммеToolStripMenuItem_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 551);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1081, 598);
            this.MinimumSize = new System.Drawing.Size(1081, 598);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Shown += new System.EventHandler(this.DataForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходВОконоРегестрацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходВОкноВходаToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ToolStripMenuItem транспортноеСтредствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправительToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маршрутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управляющийТранспортнымСредствомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пунктДоставкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обПрограммеToolStripMenuItem;
    }
}
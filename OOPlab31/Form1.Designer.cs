namespace OOPlab31
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            buttonRefresh = new Button();
            buttonExport = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            infoToolStripMenuItem = new ToolStripMenuItem();
            killToolStripMenuItem = new ToolStripMenuItem();
            threadsToolStripMenuItem = new ToolStripMenuItem();
            modulesToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(560, 394);
            listBox1.TabIndex = 0;
            listBox1.ContextMenuStrip = contextMenuStrip1;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(590, 12);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(180, 30);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Оновити список";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(590, 48);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(180, 30);
            buttonExport.TabIndex = 2;
            buttonExport.Text = "Експорт у файл";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] {infoToolStripMenuItem, killToolStripMenuItem, threadsToolStripMenuItem, modulesToolStripMenuItem});
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 114);
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(180, 22);
            infoToolStripMenuItem.Text = "Інформація";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // killToolStripMenuItem
            // 
            killToolStripMenuItem.Name = "killToolStripMenuItem";
            killToolStripMenuItem.Size = new Size(180, 22);
            killToolStripMenuItem.Text = "Зупинити процес";
            killToolStripMenuItem.Click += killToolStripMenuItem_Click;
            // 
            // threadsToolStripMenuItem
            // 
            threadsToolStripMenuItem.Name = "threadsToolStripMenuItem";
            threadsToolStripMenuItem.Size = new Size(180, 22);
            threadsToolStripMenuItem.Text = "Потоки";
            threadsToolStripMenuItem.Click += threadsToolStripMenuItem_Click;
            // 
            // modulesToolStripMenuItem
            // 
            modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            modulesToolStripMenuItem.Size = new Size(180, 22);
            modulesToolStripMenuItem.Text = "Модулі";
            modulesToolStripMenuItem.Click += modulesToolStripMenuItem_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Текстові файли|*.txt|Усі файли|*.*";
            saveFileDialog1.Title = "Експорт списку процесів";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 421);
            Controls.Add(buttonExport);
            Controls.Add(buttonRefresh);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Менеджер процесів";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button buttonRefresh;
        private Button buttonExport;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem killToolStripMenuItem;
        private ToolStripMenuItem threadsToolStripMenuItem;
        private ToolStripMenuItem modulesToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
    }
}

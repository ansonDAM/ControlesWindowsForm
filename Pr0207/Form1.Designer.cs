﻿namespace Pr0207
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasarLosAlumnosSeleccionadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasarTodosLosAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quitarLosAlumnosSeleccionadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarTodosLosAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saliraltf4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasarLosAlumnosSeleccionadosToolStripMenuItem,
            this.pasarTodosLosAlumnosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(247, 48);
            // 
            // pasarLosAlumnosSeleccionadosToolStripMenuItem
            // 
            this.pasarLosAlumnosSeleccionadosToolStripMenuItem.Name = "pasarLosAlumnosSeleccionadosToolStripMenuItem";
            this.pasarLosAlumnosSeleccionadosToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.pasarLosAlumnosSeleccionadosToolStripMenuItem.Text = "Pasar los alumnos seleccionados";
            this.pasarLosAlumnosSeleccionadosToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // pasarTodosLosAlumnosToolStripMenuItem
            // 
            this.pasarTodosLosAlumnosToolStripMenuItem.Name = "pasarTodosLosAlumnosToolStripMenuItem";
            this.pasarTodosLosAlumnosToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.pasarTodosLosAlumnosToolStripMenuItem.Text = "Pasar todos los alumnos";
            this.pasarTodosLosAlumnosToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(27, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(308, 379);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.ContextMenuStrip = this.contextMenuStrip2;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(441, 39);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(328, 379);
            this.listBox2.TabIndex = 2;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitarLosAlumnosSeleccionadosToolStripMenuItem,
            this.quitarTodosLosAlumnosToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(252, 48);
            // 
            // quitarLosAlumnosSeleccionadosToolStripMenuItem
            // 
            this.quitarLosAlumnosSeleccionadosToolStripMenuItem.Name = "quitarLosAlumnosSeleccionadosToolStripMenuItem";
            this.quitarLosAlumnosSeleccionadosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.quitarLosAlumnosSeleccionadosToolStripMenuItem.Text = "Quitar los alumnos seleccionados";
            this.quitarLosAlumnosSeleccionadosToolStripMenuItem.Click += new System.EventHandler(this.button4_Click);
            // 
            // quitarTodosLosAlumnosToolStripMenuItem
            // 
            this.quitarTodosLosAlumnosToolStripMenuItem.Name = "quitarTodosLosAlumnosToolStripMenuItem";
            this.quitarTodosLosAlumnosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.quitarTodosLosAlumnosToolStripMenuItem.Text = "Quitar todos los alumnos";
            this.quitarTodosLosAlumnosToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alumnos candidatos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alumnos seleccionados:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(351, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(351, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saliraltf4ToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(181, 48);
            // 
            // saliraltf4ToolStripMenuItem
            // 
            this.saliraltf4ToolStripMenuItem.Name = "saliraltf4ToolStripMenuItem";
            this.saliraltf4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.saliraltf4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saliraltf4ToolStripMenuItem.Text = "Salir";
            this.saliraltf4ToolStripMenuItem.Click += new System.EventHandler(this.saliraltf4ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip3;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem pasarLosAlumnosSeleccionadosToolStripMenuItem;
        private ToolStripMenuItem pasarTodosLosAlumnosToolStripMenuItem;
        private ToolStripMenuItem quitarLosAlumnosSeleccionadosToolStripMenuItem;
        private ToolStripMenuItem quitarTodosLosAlumnosToolStripMenuItem;
        private ToolStripMenuItem saliraltf4ToolStripMenuItem;
    }
}
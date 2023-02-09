namespace KanbanMVP
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.lblNew = new System.Windows.Forms.Label();
            this.lstTodo = new System.Windows.Forms.ListBox();
            this.lblTodo = new System.Windows.Forms.Label();
            this.lstDoing = new System.Windows.Forms.ListBox();
            this.lblDoing = new System.Windows.Forms.Label();
            this.btnDoing = new System.Windows.Forms.Button();
            this.lblSelectedTodo = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblSelectedDoing = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSelectedDoing);
            this.panel1.Controls.Add(this.lblDone);
            this.panel1.Controls.Add(this.lstDone);
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Controls.Add(this.lblSelectedTodo);
            this.panel1.Controls.Add(this.btnDoing);
            this.panel1.Controls.Add(this.lblDoing);
            this.panel1.Controls.Add(this.lstDoing);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtNew);
            this.panel1.Controls.Add(this.lblNew);
            this.panel1.Controls.Add(this.lstTodo);
            this.panel1.Controls.Add(this.lblTodo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 448);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(241, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNew
            // 
            this.txtNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNew.Location = new System.Drawing.Point(146, 8);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(170, 21);
            this.txtNew.TabIndex = 3;
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.Location = new System.Drawing.Point(12, 9);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(128, 20);
            this.lblNew.TabIndex = 2;
            this.lblNew.Text = "Create new task:";
            // 
            // lstTodo
            // 
            this.lstTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTodo.FormattingEnabled = true;
            this.lstTodo.ItemHeight = 15;
            this.lstTodo.Location = new System.Drawing.Point(43, 113);
            this.lstTodo.Name = "lstTodo";
            this.lstTodo.Size = new System.Drawing.Size(200, 289);
            this.lstTodo.TabIndex = 1;
            this.lstTodo.SelectedIndexChanged += new System.EventHandler(this.lstTodo_SelectedIndexChanged);
            this.lstTodo.DoubleClick += new System.EventHandler(this.lstTodo_DoubleClick);
            // 
            // lblTodo
            // 
            this.lblTodo.AutoSize = true;
            this.lblTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodo.Location = new System.Drawing.Point(105, 90);
            this.lblTodo.Name = "lblTodo";
            this.lblTodo.Size = new System.Drawing.Size(54, 20);
            this.lblTodo.TabIndex = 0;
            this.lblTodo.Text = "To-do:";
            // 
            // lstDoing
            // 
            this.lstDoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDoing.FormattingEnabled = true;
            this.lstDoing.ItemHeight = 15;
            this.lstDoing.Location = new System.Drawing.Point(285, 113);
            this.lstDoing.Name = "lstDoing";
            this.lstDoing.Size = new System.Drawing.Size(200, 289);
            this.lstDoing.TabIndex = 5;
            this.lstDoing.DoubleClick += new System.EventHandler(this.lstDoing_DoubleClick);
            // 
            // lblDoing
            // 
            this.lblDoing.AutoSize = true;
            this.lblDoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoing.Location = new System.Drawing.Point(342, 90);
            this.lblDoing.Name = "lblDoing";
            this.lblDoing.Size = new System.Drawing.Size(94, 20);
            this.lblDoing.TabIndex = 6;
            this.lblDoing.Text = "In Progress:";
            // 
            // btnDoing
            // 
            this.btnDoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoing.Location = new System.Drawing.Point(249, 236);
            this.btnDoing.Name = "btnDoing";
            this.btnDoing.Size = new System.Drawing.Size(30, 30);
            this.btnDoing.TabIndex = 7;
            this.btnDoing.Text = "=>";
            this.btnDoing.UseVisualStyleBackColor = true;
            this.btnDoing.Click += new System.EventHandler(this.btnDoing_Click);
            // 
            // lblSelectedTodo
            // 
            this.lblSelectedTodo.AutoSize = true;
            this.lblSelectedTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTodo.Location = new System.Drawing.Point(40, 405);
            this.lblSelectedTodo.Name = "lblSelectedTodo";
            this.lblSelectedTodo.Size = new System.Drawing.Size(36, 15);
            this.lblSelectedTodo.TabIndex = 8;
            this.lblSelectedTodo.Text = "Task:";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(491, 236);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(30, 30);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "=>";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lstDone
            // 
            this.lstDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDone.FormattingEnabled = true;
            this.lstDone.ItemHeight = 15;
            this.lstDone.Location = new System.Drawing.Point(527, 112);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(200, 289);
            this.lstDone.TabIndex = 10;
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.Location = new System.Drawing.Point(593, 90);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(52, 20);
            this.lblDone.TabIndex = 11;
            this.lblDone.Text = "Done:";
            // 
            // lblSelectedDoing
            // 
            this.lblSelectedDoing.AutoSize = true;
            this.lblSelectedDoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDoing.Location = new System.Drawing.Point(282, 405);
            this.lblSelectedDoing.Name = "lblSelectedDoing";
            this.lblSelectedDoing.Size = new System.Drawing.Size(36, 15);
            this.lblSelectedDoing.TabIndex = 12;
            this.lblSelectedDoing.Text = "Task:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 448);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Kanban";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.ListBox lstTodo;
        private System.Windows.Forms.Label lblTodo;
        private System.Windows.Forms.Button btnDoing;
        private System.Windows.Forms.Label lblDoing;
        private System.Windows.Forms.ListBox lstDoing;
        private System.Windows.Forms.Label lblSelectedTodo;
        private System.Windows.Forms.Label lblSelectedDoing;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.ListBox lstDone;
        private System.Windows.Forms.Button btnDone;
    }
}


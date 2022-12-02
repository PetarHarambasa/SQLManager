namespace SQLManager
{
    partial class SQLManager
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
            this.btnExecute = new System.Windows.Forms.Button();
            this.tbQueryText = new System.Windows.Forms.TextBox();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lbQuerryStatus = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(665, 80);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(123, 72);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // tbQueryText
            // 
            this.tbQueryText.Location = new System.Drawing.Point(12, 80);
            this.tbQueryText.Multiline = true;
            this.tbQueryText.Name = "tbQueryText";
            this.tbQueryText.Size = new System.Drawing.Size(647, 301);
            this.tbQueryText.TabIndex = 1;
            // 
            // cbDatabases
            // 
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(12, 36);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(195, 21);
            this.cbDatabases.TabIndex = 2;
            this.cbDatabases.SelectedIndexChanged += new System.EventHandler(this.cbDatabases_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select database:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Messages";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(353, 438);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(306, 125);
            this.tbMessage.TabIndex = 7;
            // 
            // lbQuerryStatus
            // 
            this.lbQuerryStatus.AutoSize = true;
            this.lbQuerryStatus.Location = new System.Drawing.Point(12, 580);
            this.lbQuerryStatus.Name = "lbQuerryStatus";
            this.lbQuerryStatus.Size = new System.Drawing.Size(0, 13);
            this.lbQuerryStatus.TabIndex = 9;
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(12, 438);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(295, 125);
            this.dgvResult.TabIndex = 10;
            // 
            // SQLManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.lbQuerryStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.tbQueryText);
            this.Controls.Add(this.btnExecute);
            this.Name = "SQLManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SQLManager_FormClosed);
            this.Load += new System.EventHandler(this.SQLManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox tbQueryText;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label lbQuerryStatus;
        private System.Windows.Forms.DataGridView dgvResult;
    }
}
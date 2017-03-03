namespace CycleTimeAlarm
{
    partial class TIMER
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cycleTime_l = new System.Windows.Forms.Label();
            this.cycleTime_n = new System.Windows.Forms.NumericUpDown();
            this.act_b = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.history_b = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cycleTime_n)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cycleTime_l, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cycleTime_n, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.act_b, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.history_b, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cycleTime_l
            // 
            this.cycleTime_l.AutoSize = true;
            this.cycleTime_l.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cycleTime_l.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cycleTime_l.Location = new System.Drawing.Point(3, 0);
            this.cycleTime_l.Name = "cycleTime_l";
            this.cycleTime_l.Size = new System.Drawing.Size(133, 35);
            this.cycleTime_l.TabIndex = 0;
            this.cycleTime_l.Text = "Cycle Time";
            this.cycleTime_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cycleTime_n
            // 
            this.cycleTime_n.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cycleTime_n.Location = new System.Drawing.Point(142, 3);
            this.cycleTime_n.Name = "cycleTime_n";
            this.cycleTime_n.Size = new System.Drawing.Size(133, 29);
            this.cycleTime_n.TabIndex = 1;
            // 
            // act_b
            // 
            this.act_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.act_b.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.act_b.Location = new System.Drawing.Point(142, 38);
            this.act_b.Name = "act_b";
            this.act_b.Size = new System.Drawing.Size(133, 38);
            this.act_b.TabIndex = 2;
            this.act_b.Text = "Start";
            this.act_b.UseVisualStyleBackColor = true;
            this.act_b.Click += new System.EventHandler(this.act_b_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // history_b
            // 
            this.history_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history_b.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.history_b.Location = new System.Drawing.Point(3, 38);
            this.history_b.Name = "history_b";
            this.history_b.Size = new System.Drawing.Size(133, 38);
            this.history_b.TabIndex = 3;
            this.history_b.Text = "History";
            this.history_b.UseVisualStyleBackColor = true;
            this.history_b.Click += new System.EventHandler(this.history_b_Click);
            // 
            // TIMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 79);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TIMER";
            this.Text = "C-Timer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cycleTime_n)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label cycleTime_l;
        private System.Windows.Forms.NumericUpDown cycleTime_n;
        private System.Windows.Forms.Button act_b;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button history_b;
    }
}


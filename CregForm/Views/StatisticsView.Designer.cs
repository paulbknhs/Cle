namespace CregForm.Views
{
    partial class StatisticsView
    {
                                private System.ComponentModel.IContainer components = null;

                                        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

                                        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridAge = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridSum = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSum)).BeginInit();
            this.SuspendLayout();
                                                this.dataGridAge.AllowUserToAddRows = false;
            this.dataGridAge.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridAge.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAge.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAge.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridAge.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAge.ColumnHeadersHeight = 36;
            this.dataGridAge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAge.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAge.Location = new System.Drawing.Point(51, 57);
            this.dataGridAge.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridAge.Name = "dataGridAge";
            this.dataGridAge.ReadOnly = true;
            this.dataGridAge.RowHeadersVisible = false;
            this.dataGridAge.RowTemplate.Height = 25;
            this.dataGridAge.ShowCellErrors = false;
            this.dataGridAge.ShowCellToolTips = false;
            this.dataGridAge.ShowEditingIcon = false;
            this.dataGridAge.ShowRowErrors = false;
            this.dataGridAge.Size = new System.Drawing.Size(384, 545);
            this.dataGridAge.TabIndex = 1;
                                                this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Altersstatistik";
                                                this.dataGridSum.AllowUserToAddRows = false;
            this.dataGridSum.AllowUserToDeleteRows = false;
            this.dataGridSum.AllowUserToResizeRows = false;
            this.dataGridSum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSum.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridSum.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSum.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSum.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSum.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridSum.Location = new System.Drawing.Point(51, 602);
            this.dataGridSum.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridSum.MultiSelect = false;
            this.dataGridSum.Name = "dataGridSum";
            this.dataGridSum.ReadOnly = true;
            this.dataGridSum.RowHeadersVisible = false;
            this.dataGridSum.RowTemplate.Height = 25;
            this.dataGridSum.ShowCellErrors = false;
            this.dataGridSum.ShowCellToolTips = false;
            this.dataGridSum.ShowEditingIcon = false;
            this.dataGridSum.ShowRowErrors = false;
            this.dataGridSum.Size = new System.Drawing.Size(384, 35);
            this.dataGridSum.TabIndex = 1;
                                                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridSum);
            this.Controls.Add(this.dataGridAge);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "StatisticsView";
            this.Size = new System.Drawing.Size(1080, 690);
            this.Tag = "View";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridAge;
        private Label label1;
        private DataGridView dataGridSum;
    }
}

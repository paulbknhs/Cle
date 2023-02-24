namespace CregForm.Views
{
    partial class ExportView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridAge = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAge)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAge
            // 
            this.dataGridAge.AllowUserToAddRows = false;
            this.dataGridAge.AllowUserToDeleteRows = false;
            this.dataGridAge.AllowUserToOrderColumns = true;
            this.dataGridAge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridAge.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAge.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAge.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAge.Location = new System.Drawing.Point(10, 119);
            this.dataGridAge.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridAge.Name = "dataGridAge";
            this.dataGridAge.ReadOnly = true;
            this.dataGridAge.RowHeadersVisible = false;
            this.dataGridAge.RowTemplate.Height = 25;
            this.dataGridAge.Size = new System.Drawing.Size(700, 561);
            this.dataGridAge.TabIndex = 1;
            // 
            // ExportView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dataGridAge);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ExportView";
            this.Size = new System.Drawing.Size(1080, 690);
            this.Tag = "View";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridAge;
    }
}

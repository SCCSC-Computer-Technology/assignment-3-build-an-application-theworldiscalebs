namespace CThompsonCPT206Lab3
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitedStatesDatabaseDataSet = new CThompsonCPT206Lab3.UnitedStatesDatabaseDataSet();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.statesTableAdapter = new CThompsonCPT206Lab3.UnitedStatesDatabaseDataSetTableAdapters.StatesTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitedStatesDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Black;
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(71, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(204, 26);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "United States Database";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // stateComboBox
            // 
            this.stateComboBox.BackColor = System.Drawing.Color.Black;
            this.stateComboBox.DataSource = this.statesBindingSource;
            this.stateComboBox.DisplayMember = "name";
            this.stateComboBox.ForeColor = System.Drawing.Color.White;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(105, 63);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 21);
            this.stateComboBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.stateComboBox, "select state here!");
            this.stateComboBox.ValueMember = "name";
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.unitedStatesDatabaseDataSet;
            // 
            // unitedStatesDatabaseDataSet
            // 
            this.unitedStatesDatabaseDataSet.DataSetName = "UnitedStatesDatabaseDataSet";
            this.unitedStatesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(64, 123);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "&Search";
            this.toolTip1.SetToolTip(this.SearchBtn, "searches through the database and displays specfic state details");
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(213, 123);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "&Close";
            this.toolTip1.SetToolTip(this.CloseBtn, "exits the program");
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(336, 171);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "MainForm";
            this.Text = "United States Database ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitedStatesDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button CloseBtn;
        private UnitedStatesDatabaseDataSet unitedStatesDatabaseDataSet;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private UnitedStatesDatabaseDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


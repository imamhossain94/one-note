namespace One_Note
{
    partial class OneNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneNote));
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.New_btn = new System.Windows.Forms.Button();
            this.Home_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.DateTimePicker();
            this.datebox = new System.Windows.Forms.DateTimePicker();
            this.NewPanel = new System.Windows.Forms.Panel();
            this.Save_btn = new System.Windows.Forms.Button();
            this.DeletePanel = new System.Windows.Forms.Panel();
            this.delConfirmBtn = new System.Windows.Forms.Button();
            this.deleteTitle = new System.Windows.Forms.TextBox();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.pictureBo = new System.Windows.Forms.PictureBox();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.one_NoteDataSet = new One_Note.One_NoteDataSet();
            this.oneTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oneTabTableAdapter = new One_Note.One_NoteDataSetTableAdapters.OneTabTableAdapter();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.NewPanel.SuspendLayout();
            this.DeletePanel.SuspendLayout();
            this.StartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.one_NoteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneTabBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBox.Location = new System.Drawing.Point(40, 72);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(4);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(364, 36);
            this.TitleBox.TabIndex = 0;
            this.TitleBox.Text = "Title..";
            // 
            // MessageBox
            // 
            this.MessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MessageBox.BackColor = System.Drawing.Color.White;
            this.MessageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageBox.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBox.Location = new System.Drawing.Point(40, 116);
            this.MessageBox.Margin = new System.Windows.Forms.Padding(4);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(364, 245);
            this.MessageBox.TabIndex = 2;
            this.MessageBox.Text = "Type Notee..";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.timedateDataGridViewTextBoxColumn,
            this.lastModifiedDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.oneTabBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(481, 61);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 25;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(730, 409);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_RowHeaderMouseClick);
            // 
            // New_btn
            // 
            this.New_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.New_btn.BackColor = System.Drawing.SystemColors.Window;
            this.New_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_btn.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.New_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.New_btn.Location = new System.Drawing.Point(40, 367);
            this.New_btn.Name = "New_btn";
            this.New_btn.Size = new System.Drawing.Size(364, 39);
            this.New_btn.TabIndex = 5;
            this.New_btn.Text = "New";
            this.New_btn.UseVisualStyleBackColor = false;
            this.New_btn.Click += new System.EventHandler(this.New_btn_Click);
            // 
            // Home_btn
            // 
            this.Home_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Home_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_btn.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.Home_btn.ForeColor = System.Drawing.Color.DarkBlue;
            this.Home_btn.Location = new System.Drawing.Point(18, 486);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(137, 39);
            this.Home_btn.TabIndex = 7;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = false;
            this.Home_btn.Click += new System.EventHandler(this.OneNote_Load);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.Delete_btn.ForeColor = System.Drawing.Color.Red;
            this.Delete_btn.Location = new System.Drawing.Point(321, 486);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(140, 39);
            this.Delete_btn.TabIndex = 8;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Update_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_btn.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.Update_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.Update_btn.Location = new System.Drawing.Point(40, 368);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(364, 39);
            this.Update_btn.TabIndex = 9;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(481, 17);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(730, 36);
            this.SearchBox.TabIndex = 12;
            this.SearchBox.Text = "Search.";
            this.SearchBox.Click += new System.EventHandler(this.SearchBox_Click);
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // timeBox
            // 
            this.timeBox.CalendarFont = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.timeBox.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.timeBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeBox.Location = new System.Drawing.Point(40, 29);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(180, 36);
            this.timeBox.TabIndex = 15;
            // 
            // datebox
            // 
            this.datebox.CalendarFont = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.datebox.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.datebox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datebox.Location = new System.Drawing.Point(224, 29);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(180, 36);
            this.datebox.TabIndex = 14;
            // 
            // NewPanel
            // 
            this.NewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPanel.Controls.Add(this.timeBox);
            this.NewPanel.Controls.Add(this.datebox);
            this.NewPanel.Controls.Add(this.TitleBox);
            this.NewPanel.Controls.Add(this.MessageBox);
            this.NewPanel.Controls.Add(this.Save_btn);
            this.NewPanel.Controls.Add(this.Update_btn);
            this.NewPanel.Location = new System.Drawing.Point(18, 17);
            this.NewPanel.Name = "NewPanel";
            this.NewPanel.Size = new System.Drawing.Size(443, 453);
            this.NewPanel.TabIndex = 16;
            // 
            // Save_btn
            // 
            this.Save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Save_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_btn.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.Save_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.Save_btn.Location = new System.Drawing.Point(40, 368);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(364, 39);
            this.Save_btn.TabIndex = 6;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // DeletePanel
            // 
            this.DeletePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeletePanel.Controls.Add(this.delConfirmBtn);
            this.DeletePanel.Controls.Add(this.deleteTitle);
            this.DeletePanel.Location = new System.Drawing.Point(18, 17);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.Size = new System.Drawing.Size(443, 271);
            this.DeletePanel.TabIndex = 17;
            // 
            // delConfirmBtn
            // 
            this.delConfirmBtn.BackColor = System.Drawing.SystemColors.Window;
            this.delConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delConfirmBtn.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.delConfirmBtn.ForeColor = System.Drawing.Color.Crimson;
            this.delConfirmBtn.Location = new System.Drawing.Point(40, 144);
            this.delConfirmBtn.Name = "delConfirmBtn";
            this.delConfirmBtn.Size = new System.Drawing.Size(364, 39);
            this.delConfirmBtn.TabIndex = 8;
            this.delConfirmBtn.Text = "Confirm";
            this.delConfirmBtn.UseVisualStyleBackColor = false;
            this.delConfirmBtn.Click += new System.EventHandler(this.DelConfirmBtn_Click);
            // 
            // deleteTitle
            // 
            this.deleteTitle.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTitle.Location = new System.Drawing.Point(40, 72);
            this.deleteTitle.Margin = new System.Windows.Forms.Padding(4);
            this.deleteTitle.Name = "deleteTitle";
            this.deleteTitle.Size = new System.Drawing.Size(364, 36);
            this.deleteTitle.TabIndex = 1;
            this.deleteTitle.Text = "Click on a row header to delete.";
            // 
            // StartPanel
            // 
            this.StartPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartPanel.Controls.Add(this.pictureBo);
            this.StartPanel.Controls.Add(this.New_btn);
            this.StartPanel.ForeColor = System.Drawing.Color.Chartreuse;
            this.StartPanel.Location = new System.Drawing.Point(18, 17);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(443, 453);
            this.StartPanel.TabIndex = 18;
            // 
            // pictureBo
            // 
            this.pictureBo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBo.BackColor = System.Drawing.Color.White;
            this.pictureBo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBo.BackgroundImage")));
            this.pictureBo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBo.Location = new System.Drawing.Point(40, 29);
            this.pictureBo.Name = "pictureBo";
            this.pictureBo.Size = new System.Drawing.Size(364, 316);
            this.pictureBo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBo.TabIndex = 6;
            this.pictureBo.TabStop = false;
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Refresh_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Refresh_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh_btn.BackgroundImage")));
            this.Refresh_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_btn.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.Refresh_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Refresh_btn.Location = new System.Drawing.Point(1174, 20);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(30, 30);
            this.Refresh_btn.TabIndex = 19;
            this.Refresh_btn.UseVisualStyleBackColor = false;
            this.Refresh_btn.Click += new System.EventHandler(this.OneNote_Load);
            // 
            // one_NoteDataSet
            // 
            this.one_NoteDataSet.DataSetName = "One_NoteDataSet";
            this.one_NoteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oneTabBindingSource
            // 
            this.oneTabBindingSource.DataMember = "OneTab";
            this.oneTabBindingSource.DataSource = this.one_NoteDataSet;
            // 
            // oneTabTableAdapter
            // 
            this.oneTabTableAdapter.ClearBeforeFill = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            // 
            // timedateDataGridViewTextBoxColumn
            // 
            this.timedateDataGridViewTextBoxColumn.DataPropertyName = "Time_date";
            this.timedateDataGridViewTextBoxColumn.HeaderText = "Time_date";
            this.timedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timedateDataGridViewTextBoxColumn.Name = "timedateDataGridViewTextBoxColumn";
            // 
            // lastModifiedDataGridViewTextBoxColumn
            // 
            this.lastModifiedDataGridViewTextBoxColumn.DataPropertyName = "Last_Modified";
            this.lastModifiedDataGridViewTextBoxColumn.HeaderText = "Last_Modified";
            this.lastModifiedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastModifiedDataGridViewTextBoxColumn.Name = "lastModifiedDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Edit.BackColor = System.Drawing.SystemColors.Window;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.Edit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Edit.Location = new System.Drawing.Point(168, 486);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(140, 39);
            this.Edit.TabIndex = 20;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(481, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(730, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Database";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // OneNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1224, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.NewPanel);
            this.Controls.Add(this.DeletePanel);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1242, 609);
            this.Name = "OneNote";
            this.Text = "One Note";
            this.Load += new System.EventHandler(this.OneNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.NewPanel.ResumeLayout(false);
            this.NewPanel.PerformLayout();
            this.DeletePanel.ResumeLayout(false);
            this.DeletePanel.PerformLayout();
            this.StartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.one_NoteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneTabBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button New_btn;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DateTimePicker timeBox;
        private System.Windows.Forms.DateTimePicker datebox;
        private System.Windows.Forms.Panel NewPanel;
        private System.Windows.Forms.Panel DeletePanel;
        private System.Windows.Forms.Button delConfirmBtn;
        private System.Windows.Forms.TextBox deleteTitle;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.PictureBox pictureBo;
        private System.Windows.Forms.Button Refresh_btn;
        private System.Windows.Forms.Button Save_btn;
        private One_NoteDataSet one_NoteDataSet;
        private System.Windows.Forms.BindingSource oneTabBindingSource;
        private One_NoteDataSetTableAdapters.OneTabTableAdapter oneTabTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button button1;
    }
}


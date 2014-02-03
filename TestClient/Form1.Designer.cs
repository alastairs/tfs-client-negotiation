namespace TestClient
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tfsServerToConnectTo = new System.Windows.Forms.ComboBox();
            this.tfsServerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.workspaceName = new System.Windows.Forms.TextBox();
            this.busyGif = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tfsServerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busyGif)).BeginInit();
            this.SuspendLayout();
            // 
            // tfsServerToConnectTo
            // 
            this.tfsServerToConnectTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tfsServerToConnectTo.DataSource = this.tfsServerBindingSource;
            this.tfsServerToConnectTo.DisplayMember = "Name";
            this.tfsServerToConnectTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tfsServerToConnectTo.FormattingEnabled = true;
            this.tfsServerToConnectTo.Location = new System.Drawing.Point(148, 18);
            this.tfsServerToConnectTo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tfsServerToConnectTo.Name = "tfsServerToConnectTo";
            this.tfsServerToConnectTo.Size = new System.Drawing.Size(125, 21);
            this.tfsServerToConnectTo.TabIndex = 1;
            this.tfsServerToConnectTo.ValueMember = "Url";
            // 
            // tfsServerBindingSource
            // 
            this.tfsServerBindingSource.DataSource = typeof(TestClient.TfsServer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TFS Server for connection:";
            // 
            // connect
            // 
            this.connect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connect.Location = new System.Drawing.Point(11, 84);
            this.connect.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(150, 32);
            this.connect.TabIndex = 4;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Workspace name:";
            // 
            // workspaceName
            // 
            this.workspaceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workspaceName.Location = new System.Drawing.Point(105, 55);
            this.workspaceName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.workspaceName.Name = "workspaceName";
            this.workspaceName.Size = new System.Drawing.Size(168, 21);
            this.workspaceName.TabIndex = 3;
            // 
            // busyGif
            // 
            this.busyGif.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.busyGif.Image = ((System.Drawing.Image)(resources.GetObject("busyGif.Image")));
            this.busyGif.Location = new System.Drawing.Point(0, 123);
            this.busyGif.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.busyGif.Name = "busyGif";
            this.busyGif.Size = new System.Drawing.Size(284, 17);
            this.busyGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.busyGif.TabIndex = 5;
            this.busyGif.TabStop = false;
            this.busyGif.Visible = false;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close.Location = new System.Drawing.Point(165, 84);
            this.close.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(109, 32);
            this.close.TabIndex = 5;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close;
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.close);
            this.Controls.Add(this.busyGif);
            this.Controls.Add(this.workspaceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tfsServerToConnectTo);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Test TFS Client";
            ((System.ComponentModel.ISupportInitialize)(this.tfsServerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busyGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tfsServerToConnectTo;
        private System.Windows.Forms.BindingSource tfsServerBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox workspaceName;
        private System.Windows.Forms.PictureBox busyGif;
        private System.Windows.Forms.Button close;

    }
}


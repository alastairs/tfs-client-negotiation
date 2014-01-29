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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.workspaceName = new System.Windows.Forms.TextBox();
            this.busyGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tfsServerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busyGif)).BeginInit();
            this.SuspendLayout();
            // 
            // tfsServerToConnectTo
            // 
            this.tfsServerToConnectTo.DataSource = this.tfsServerBindingSource;
            this.tfsServerToConnectTo.DisplayMember = "Name";
            this.tfsServerToConnectTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tfsServerToConnectTo.FormattingEnabled = true;
            this.tfsServerToConnectTo.Location = new System.Drawing.Point(153, 12);
            this.tfsServerToConnectTo.Name = "tfsServerToConnectTo";
            this.tfsServerToConnectTo.Size = new System.Drawing.Size(121, 21);
            this.tfsServerToConnectTo.TabIndex = 0;
            this.tfsServerToConnectTo.ValueMember = "Url";
            // 
            // tfsServerBindingSource
            // 
            this.tfsServerBindingSource.DataSource = typeof(TestClient.TfsServer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TFS Server for connection:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Workspace name:";
            // 
            // workspaceName
            // 
            this.workspaceName.Location = new System.Drawing.Point(112, 39);
            this.workspaceName.Name = "workspaceName";
            this.workspaceName.Size = new System.Drawing.Size(162, 20);
            this.workspaceName.TabIndex = 4;
            // 
            // busyGif
            // 
            this.busyGif.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.busyGif.Image = ((System.Drawing.Image)(resources.GetObject("busyGif.Image")));
            this.busyGif.Location = new System.Drawing.Point(0, 100);
            this.busyGif.Name = "busyGif";
            this.busyGif.Size = new System.Drawing.Size(284, 27);
            this.busyGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.busyGif.TabIndex = 5;
            this.busyGif.TabStop = false;
            this.busyGif.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 127);
            this.Controls.Add(this.busyGif);
            this.Controls.Add(this.workspaceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tfsServerToConnectTo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tfsServerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busyGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tfsServerToConnectTo;
        private System.Windows.Forms.BindingSource tfsServerBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox workspaceName;
        private System.Windows.Forms.PictureBox busyGif;

    }
}


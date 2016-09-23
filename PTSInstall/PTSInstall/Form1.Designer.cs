namespace PTSInstall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.createPTSFolders_Button = new System.Windows.Forms.Button();
            this.installGtkSharpButton = new System.Windows.Forms.Button();
            this.installDotNetFrameworkButton = new System.Windows.Forms.Button();
            this.installPTSAppButton = new System.Windows.Forms.Button();
            this.step1label = new System.Windows.Forms.Label();
            this.step2label = new System.Windows.Forms.Label();
            this.step3label = new System.Windows.Forms.Label();
            this.step4label = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(59, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(323, 33);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "PTS Installation Steps";
            // 
            // createPTSFolders_Button
            // 
            this.createPTSFolders_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPTSFolders_Button.Location = new System.Drawing.Point(189, 89);
            this.createPTSFolders_Button.Name = "createPTSFolders_Button";
            this.createPTSFolders_Button.Size = new System.Drawing.Size(302, 29);
            this.createPTSFolders_Button.TabIndex = 1;
            this.createPTSFolders_Button.Text = "Create PTS Installation Folders";
            this.createPTSFolders_Button.UseVisualStyleBackColor = true;
            this.createPTSFolders_Button.Click += new System.EventHandler(this.createPTSFolders_Button_Click);
            // 
            // installGtkSharpButton
            // 
            this.installGtkSharpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installGtkSharpButton.Location = new System.Drawing.Point(189, 181);
            this.installGtkSharpButton.Name = "installGtkSharpButton";
            this.installGtkSharpButton.Size = new System.Drawing.Size(302, 29);
            this.installGtkSharpButton.TabIndex = 2;
            this.installGtkSharpButton.Text = "Install GtkSharp Package";
            this.installGtkSharpButton.UseVisualStyleBackColor = true;
            this.installGtkSharpButton.Click += new System.EventHandler(this.installGtkSharpButton_Click);
            // 
            // installDotNetFrameworkButton
            // 
            this.installDotNetFrameworkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installDotNetFrameworkButton.Location = new System.Drawing.Point(189, 137);
            this.installDotNetFrameworkButton.Name = "installDotNetFrameworkButton";
            this.installDotNetFrameworkButton.Size = new System.Drawing.Size(302, 29);
            this.installDotNetFrameworkButton.TabIndex = 3;
            this.installDotNetFrameworkButton.Text = "Install MS .NET Framework";
            this.installDotNetFrameworkButton.UseVisualStyleBackColor = true;
            this.installDotNetFrameworkButton.Click += new System.EventHandler(this.installDotNetFrameworkButton_Click);
            // 
            // installPTSAppButton
            // 
            this.installPTSAppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installPTSAppButton.Location = new System.Drawing.Point(189, 226);
            this.installPTSAppButton.Name = "installPTSAppButton";
            this.installPTSAppButton.Size = new System.Drawing.Size(302, 29);
            this.installPTSAppButton.TabIndex = 4;
            this.installPTSAppButton.Text = "Install PTS Application Files";
            this.installPTSAppButton.UseVisualStyleBackColor = true;
            this.installPTSAppButton.Click += new System.EventHandler(this.installPTSAppButton_Click);
            // 
            // step1label
            // 
            this.step1label.AutoSize = true;
            this.step1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step1label.Location = new System.Drawing.Point(60, 89);
            this.step1label.Name = "step1label";
            this.step1label.Size = new System.Drawing.Size(102, 29);
            this.step1label.TabIndex = 5;
            this.step1label.Text = "STEP1:";
            // 
            // step2label
            // 
            this.step2label.AutoSize = true;
            this.step2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step2label.Location = new System.Drawing.Point(60, 134);
            this.step2label.Name = "step2label";
            this.step2label.Size = new System.Drawing.Size(102, 29);
            this.step2label.TabIndex = 6;
            this.step2label.Text = "STEP2:";
            // 
            // step3label
            // 
            this.step3label.AutoSize = true;
            this.step3label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step3label.Location = new System.Drawing.Point(60, 181);
            this.step3label.Name = "step3label";
            this.step3label.Size = new System.Drawing.Size(102, 29);
            this.step3label.TabIndex = 7;
            this.step3label.Text = "STEP3:";
            // 
            // step4label
            // 
            this.step4label.AutoSize = true;
            this.step4label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step4label.Location = new System.Drawing.Point(60, 226);
            this.step4label.Name = "step4label";
            this.step4label.Size = new System.Drawing.Size(102, 29);
            this.step4label.TabIndex = 8;
            this.step4label.Text = "STEP4:";
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(394, 308);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(97, 35);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "CLOSE";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 376);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.step4label);
            this.Controls.Add(this.step3label);
            this.Controls.Add(this.step2label);
            this.Controls.Add(this.step1label);
            this.Controls.Add(this.installPTSAppButton);
            this.Controls.Add(this.installDotNetFrameworkButton);
            this.Controls.Add(this.installGtkSharpButton);
            this.Controls.Add(this.createPTSFolders_Button);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PTS Installation App - Version 1.0.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button createPTSFolders_Button;
        private System.Windows.Forms.Button installGtkSharpButton;
        private System.Windows.Forms.Button installDotNetFrameworkButton;
        private System.Windows.Forms.Button installPTSAppButton;
        private System.Windows.Forms.Label step1label;
        private System.Windows.Forms.Label step2label;
        private System.Windows.Forms.Label step3label;
        private System.Windows.Forms.Label step4label;
        private System.Windows.Forms.Button closeButton;
    }
}


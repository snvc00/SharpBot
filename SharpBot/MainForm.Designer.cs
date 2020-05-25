namespace SharpBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PictureBox_Bot = new System.Windows.Forms.PictureBox();
            this.PictureBox_BotDialog = new System.Windows.Forms.PictureBox();
            this.Button_Append1 = new System.Windows.Forms.Button();
            this.Button_Append0 = new System.Windows.Forms.Button();
            this.Button_Append2 = new System.Windows.Forms.Button();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.Label_BotStatusTitle = new System.Windows.Forms.Label();
            this.PictureBox_BotStatus = new System.Windows.Forms.PictureBox();
            this.Label_BotStatus = new System.Windows.Forms.Label();
            this.LinkLabel_RecomendationText = new System.Windows.Forms.LinkLabel();
            this.PictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.TextBox_BotDialog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_BotDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_BotStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_Bot
            // 
            this.PictureBox_Bot.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_Bot.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Bot.Image")));
            this.PictureBox_Bot.Location = new System.Drawing.Point(255, 205);
            this.PictureBox_Bot.Name = "PictureBox_Bot";
            this.PictureBox_Bot.Size = new System.Drawing.Size(273, 377);
            this.PictureBox_Bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Bot.TabIndex = 0;
            this.PictureBox_Bot.TabStop = false;
            // 
            // PictureBox_BotDialog
            // 
            this.PictureBox_BotDialog.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_BotDialog.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_BotDialog.Image")));
            this.PictureBox_BotDialog.Location = new System.Drawing.Point(454, 20);
            this.PictureBox_BotDialog.Name = "PictureBox_BotDialog";
            this.PictureBox_BotDialog.Size = new System.Drawing.Size(295, 276);
            this.PictureBox_BotDialog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_BotDialog.TabIndex = 1;
            this.PictureBox_BotDialog.TabStop = false;
            // 
            // Button_Append1
            // 
            this.Button_Append1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            this.Button_Append1.FlatAppearance.BorderSize = 0;
            this.Button_Append1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Append1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Append1.ForeColor = System.Drawing.Color.White;
            this.Button_Append1.Location = new System.Drawing.Point(20, 363);
            this.Button_Append1.Name = "Button_Append1";
            this.Button_Append1.Size = new System.Drawing.Size(218, 68);
            this.Button_Append1.TabIndex = 3;
            this.Button_Append1.Text = "Educación";
            this.Button_Append1.UseVisualStyleBackColor = false;
            this.Button_Append1.Click += new System.EventHandler(this.Button_Append1_Click);
            // 
            // Button_Append0
            // 
            this.Button_Append0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            this.Button_Append0.FlatAppearance.BorderSize = 0;
            this.Button_Append0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Append0.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Append0.ForeColor = System.Drawing.Color.White;
            this.Button_Append0.Location = new System.Drawing.Point(20, 279);
            this.Button_Append0.Name = "Button_Append0";
            this.Button_Append0.Size = new System.Drawing.Size(218, 68);
            this.Button_Append0.TabIndex = 4;
            this.Button_Append0.Text = "Entretenimiento";
            this.Button_Append0.UseVisualStyleBackColor = false;
            this.Button_Append0.Click += new System.EventHandler(this.Button_Append0_Click);
            // 
            // Button_Append2
            // 
            this.Button_Append2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            this.Button_Append2.FlatAppearance.BorderSize = 0;
            this.Button_Append2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Append2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Append2.ForeColor = System.Drawing.Color.White;
            this.Button_Append2.Location = new System.Drawing.Point(20, 447);
            this.Button_Append2.Name = "Button_Append2";
            this.Button_Append2.Size = new System.Drawing.Size(218, 68);
            this.Button_Append2.TabIndex = 5;
            this.Button_Append2.Text = "Otro interés";
            this.Button_Append2.UseVisualStyleBackColor = false;
            this.Button_Append2.Click += new System.EventHandler(this.Button_Append2_Click);
            // 
            // Button_Reset
            // 
            this.Button_Reset.FlatAppearance.BorderSize = 0;
            this.Button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Reset.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Reset.Image = ((System.Drawing.Image)(resources.GetObject("Button_Reset.Image")));
            this.Button_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Reset.Location = new System.Drawing.Point(583, 321);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Padding = new System.Windows.Forms.Padding(5, 0, 20, 0);
            this.Button_Reset.Size = new System.Drawing.Size(84, 66);
            this.Button_Reset.TabIndex = 6;
            this.Button_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // Label_BotStatusTitle
            // 
            this.Label_BotStatusTitle.AutoSize = true;
            this.Label_BotStatusTitle.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BotStatusTitle.Location = new System.Drawing.Point(557, 435);
            this.Label_BotStatusTitle.Name = "Label_BotStatusTitle";
            this.Label_BotStatusTitle.Size = new System.Drawing.Size(134, 24);
            this.Label_BotStatusTitle.TabIndex = 7;
            this.Label_BotStatusTitle.Text = "Estado del Bot";
            this.Label_BotStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox_BotStatus
            // 
            this.PictureBox_BotStatus.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_BotStatus.Image")));
            this.PictureBox_BotStatus.Location = new System.Drawing.Point(583, 495);
            this.PictureBox_BotStatus.Name = "PictureBox_BotStatus";
            this.PictureBox_BotStatus.Size = new System.Drawing.Size(64, 64);
            this.PictureBox_BotStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox_BotStatus.TabIndex = 8;
            this.PictureBox_BotStatus.TabStop = false;
            // 
            // Label_BotStatus
            // 
            this.Label_BotStatus.AutoSize = true;
            this.Label_BotStatus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BotStatus.Location = new System.Drawing.Point(568, 459);
            this.Label_BotStatus.Name = "Label_BotStatus";
            this.Label_BotStatus.Size = new System.Drawing.Size(110, 24);
            this.Label_BotStatus.TabIndex = 9;
            this.Label_BotStatus.Text = "Trabajando";
            // 
            // LinkLabel_RecomendationText
            // 
            this.LinkLabel_RecomendationText.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            this.LinkLabel_RecomendationText.AutoSize = true;
            this.LinkLabel_RecomendationText.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(199)))), ((int)(((byte)(211)))));
            this.LinkLabel_RecomendationText.Location = new System.Drawing.Point(150, 46);
            this.LinkLabel_RecomendationText.Name = "LinkLabel_RecomendationText";
            this.LinkLabel_RecomendationText.Size = new System.Drawing.Size(153, 24);
            this.LinkLabel_RecomendationText.TabIndex = 10;
            this.LinkLabel_RecomendationText.TabStop = true;
            this.LinkLabel_RecomendationText.Text = "Recomendacion";
            this.LinkLabel_RecomendationText.Visible = false;
            this.LinkLabel_RecomendationText.VisitedLinkColor = System.Drawing.Color.Cyan;
            this.LinkLabel_RecomendationText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_RecomendationText_LinkClicked);
            // 
            // PictureBox_Logo
            // 
            this.PictureBox_Logo.Location = new System.Drawing.Point(74, 73);
            this.PictureBox_Logo.Name = "PictureBox_Logo";
            this.PictureBox_Logo.Size = new System.Drawing.Size(298, 118);
            this.PictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Logo.TabIndex = 11;
            this.PictureBox_Logo.TabStop = false;
            this.PictureBox_Logo.Visible = false;
            this.PictureBox_Logo.Click += new System.EventHandler(this.PictureBox_Logo_Click);
            // 
            // TextBox_BotDialog
            // 
            this.TextBox_BotDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(88)))));
            this.TextBox_BotDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_BotDialog.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_BotDialog.ForeColor = System.Drawing.Color.White;
            this.TextBox_BotDialog.Location = new System.Drawing.Point(508, 67);
            this.TextBox_BotDialog.Multiline = true;
            this.TextBox_BotDialog.Name = "TextBox_BotDialog";
            this.TextBox_BotDialog.ReadOnly = true;
            this.TextBox_BotDialog.Size = new System.Drawing.Size(185, 163);
            this.TextBox_BotDialog.TabIndex = 12;
            this.TextBox_BotDialog.Text = "¡Hola! Soy SharpBot, dejame ayudarte a elegir contenido para que aproveches al má" +
    "ximo tu navegación por internet. ¡Comencemos! ¿Qué clase de contenido prefieres?" +
    "";
            this.TextBox_BotDialog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 630);
            this.Controls.Add(this.TextBox_BotDialog);
            this.Controls.Add(this.PictureBox_Logo);
            this.Controls.Add(this.LinkLabel_RecomendationText);
            this.Controls.Add(this.Label_BotStatus);
            this.Controls.Add(this.PictureBox_BotStatus);
            this.Controls.Add(this.Label_BotStatusTitle);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Button_Append2);
            this.Controls.Add(this.Button_Append0);
            this.Controls.Add(this.Button_Append1);
            this.Controls.Add(this.PictureBox_BotDialog);
            this.Controls.Add(this.PictureBox_Bot);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpBot: Recomendaciones de contenido";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_BotDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_BotStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Bot;
        private System.Windows.Forms.PictureBox PictureBox_BotDialog;
        private System.Windows.Forms.Button Button_Append1;
        private System.Windows.Forms.Button Button_Append0;
        private System.Windows.Forms.Button Button_Append2;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Label Label_BotStatusTitle;
        private System.Windows.Forms.PictureBox PictureBox_BotStatus;
        private System.Windows.Forms.Label Label_BotStatus;
        private System.Windows.Forms.LinkLabel LinkLabel_RecomendationText;
        private System.Windows.Forms.PictureBox PictureBox_Logo;
        private System.Windows.Forms.TextBox TextBox_BotDialog;
    }
}


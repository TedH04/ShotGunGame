namespace ShotGunGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.txtPlayerMove = new System.Windows.Forms.TextBox();
            this.txtPlayerBullets = new System.Windows.Forms.TextBox();
            this.txtComputerBullets = new System.Windows.Forms.TextBox();
            this.txtComputerMove = new System.Windows.Forms.TextBox();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShoot
            // 
            this.btnShoot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShoot.Location = new System.Drawing.Point(309, 518);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(132, 62);
            this.btnShoot.TabIndex = 0;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBlock.Location = new System.Drawing.Point(514, 518);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(132, 62);
            this.btnBlock.TabIndex = 1;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReload.Location = new System.Drawing.Point(725, 518);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(132, 62);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnShotgun
            // 
            this.btnShotgun.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShotgun.Location = new System.Drawing.Point(514, 612);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(132, 62);
            this.btnShotgun.TabIndex = 3;
            this.btnShotgun.Text = "Shotgun";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            // 
            // txtPlayerMove
            // 
            this.txtPlayerMove.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlayerMove.Location = new System.Drawing.Point(83, 147);
            this.txtPlayerMove.Name = "txtPlayerMove";
            this.txtPlayerMove.Size = new System.Drawing.Size(224, 33);
            this.txtPlayerMove.TabIndex = 4;
            // 
            // txtPlayerBullets
            // 
            this.txtPlayerBullets.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlayerBullets.Location = new System.Drawing.Point(83, 236);
            this.txtPlayerBullets.Name = "txtPlayerBullets";
            this.txtPlayerBullets.Size = new System.Drawing.Size(224, 33);
            this.txtPlayerBullets.TabIndex = 5;
            // 
            // txtComputerBullets
            // 
            this.txtComputerBullets.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComputerBullets.Location = new System.Drawing.Point(843, 236);
            this.txtComputerBullets.Name = "txtComputerBullets";
            this.txtComputerBullets.Size = new System.Drawing.Size(224, 33);
            this.txtComputerBullets.TabIndex = 7;
            // 
            // txtComputerMove
            // 
            this.txtComputerMove.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComputerMove.Location = new System.Drawing.Point(843, 147);
            this.txtComputerMove.Name = "txtComputerMove";
            this.txtComputerMove.Size = new System.Drawing.Size(224, 33);
            this.txtComputerMove.TabIndex = 6;
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerOne.Location = new System.Drawing.Point(83, 72);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(138, 37);
            this.lblPlayerOne.TabIndex = 8;
            this.lblPlayerOne.Text = "PlayerOne";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComputer.Location = new System.Drawing.Point(929, 72);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(136, 37);
            this.lblComputer.TabIndex = 9;
            this.lblComputer.Text = "Computer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 712);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblPlayerOne);
            this.Controls.Add(this.txtComputerBullets);
            this.Controls.Add(this.txtComputerMove);
            this.Controls.Add(this.txtPlayerBullets);
            this.Controls.Add(this.txtPlayerMove);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnShoot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnShoot;
        private Button btnBlock;
        private Button btnReload;
        private Button btnShotgun;
        private TextBox txtPlayerMove;
        private TextBox txtPlayerBullets;
        private TextBox txtComputerBullets;
        private TextBox txtComputerMove;
        private Label lblPlayerOne;
        private Label lblComputer;
    }
}
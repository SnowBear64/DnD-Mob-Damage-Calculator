namespace MobDamageCalculator
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAttackRoll = new System.Windows.Forms.TextBox();
			this.txtAC = new System.Windows.Forms.TextBox();
			this.txtNumCreatures = new System.Windows.Forms.TextBox();
			this.txtMinNeededToHit = new System.Windows.Forms.TextBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCreaturesThatHit = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtD4 = new System.Windows.Forms.TextBox();
			this.txtD12 = new System.Windows.Forms.TextBox();
			this.txtD10 = new System.Windows.Forms.TextBox();
			this.txtD8 = new System.Windows.Forms.TextBox();
			this.txtD6 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtTotalDamage = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtAverageDamage = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtAttackMod = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Creature\'s Attack Bonus:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Target\'s AC:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Number of Creatures:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(25, 108);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(107, 31);
			this.label4.TabIndex = 3;
			this.label4.Text = "Minimun Creatures Needed to Hit Once:";
			// 
			// txtAttackRoll
			// 
			this.txtAttackRoll.Location = new System.Drawing.Point(153, 18);
			this.txtAttackRoll.Name = "txtAttackRoll";
			this.txtAttackRoll.Size = new System.Drawing.Size(100, 20);
			this.txtAttackRoll.TabIndex = 1;
			this.txtAttackRoll.Text = "0";
			// 
			// txtAC
			// 
			this.txtAC.Location = new System.Drawing.Point(153, 48);
			this.txtAC.Name = "txtAC";
			this.txtAC.Size = new System.Drawing.Size(100, 20);
			this.txtAC.TabIndex = 2;
			this.txtAC.Text = "0";
			// 
			// txtNumCreatures
			// 
			this.txtNumCreatures.Location = new System.Drawing.Point(153, 78);
			this.txtNumCreatures.Name = "txtNumCreatures";
			this.txtNumCreatures.Size = new System.Drawing.Size(100, 20);
			this.txtNumCreatures.TabIndex = 3;
			this.txtNumCreatures.Text = "0";
			// 
			// txtMinNeededToHit
			// 
			this.txtMinNeededToHit.Location = new System.Drawing.Point(153, 108);
			this.txtMinNeededToHit.Name = "txtMinNeededToHit";
			this.txtMinNeededToHit.ReadOnly = true;
			this.txtMinNeededToHit.Size = new System.Drawing.Size(100, 20);
			this.txtMinNeededToHit.TabIndex = 4;
			this.txtMinNeededToHit.Text = "0";
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(106, 315);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 15;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(202, 315);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 16;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(12, 315);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 14;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 151);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Creatures That Hit:";
			// 
			// txtCreaturesThatHit
			// 
			this.txtCreaturesThatHit.Location = new System.Drawing.Point(153, 148);
			this.txtCreaturesThatHit.Name = "txtCreaturesThatHit";
			this.txtCreaturesThatHit.ReadOnly = true;
			this.txtCreaturesThatHit.Size = new System.Drawing.Size(100, 20);
			this.txtCreaturesThatHit.TabIndex = 5;
			this.txtCreaturesThatHit.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 239);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(19, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "d4";
			// 
			// txtD4
			// 
			this.txtD4.Location = new System.Drawing.Point(12, 216);
			this.txtD4.Name = "txtD4";
			this.txtD4.Size = new System.Drawing.Size(21, 20);
			this.txtD4.TabIndex = 7;
			this.txtD4.Text = "0";
			// 
			// txtD12
			// 
			this.txtD12.Location = new System.Drawing.Point(256, 216);
			this.txtD12.Name = "txtD12";
			this.txtD12.Size = new System.Drawing.Size(21, 20);
			this.txtD12.TabIndex = 11;
			this.txtD12.Text = "0";
			// 
			// txtD10
			// 
			this.txtD10.Location = new System.Drawing.Point(192, 216);
			this.txtD10.Name = "txtD10";
			this.txtD10.Size = new System.Drawing.Size(21, 20);
			this.txtD10.TabIndex = 10;
			this.txtD10.Text = "0";
			// 
			// txtD8
			// 
			this.txtD8.Location = new System.Drawing.Point(128, 216);
			this.txtD8.Name = "txtD8";
			this.txtD8.Size = new System.Drawing.Size(21, 20);
			this.txtD8.TabIndex = 9;
			this.txtD8.Text = "0";
			// 
			// txtD6
			// 
			this.txtD6.Location = new System.Drawing.Point(67, 216);
			this.txtD6.Name = "txtD6";
			this.txtD6.Size = new System.Drawing.Size(21, 20);
			this.txtD6.TabIndex = 8;
			this.txtD6.Text = "0";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(68, 239);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(19, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "d6";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(130, 239);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(19, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "d8";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(189, 239);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(25, 13);
			this.label9.TabIndex = 21;
			this.label9.Text = "d10";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(252, 239);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(25, 13);
			this.label10.TabIndex = 22;
			this.label10.Text = "d12";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(9, 274);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(78, 30);
			this.label11.TabIndex = 23;
			this.label11.Text = "Total Damage:";
			// 
			// txtTotalDamage
			// 
			this.txtTotalDamage.Location = new System.Drawing.Point(87, 271);
			this.txtTotalDamage.Name = "txtTotalDamage";
			this.txtTotalDamage.ReadOnly = true;
			this.txtTotalDamage.Size = new System.Drawing.Size(32, 20);
			this.txtTotalDamage.TabIndex = 12;
			this.txtTotalDamage.Text = "0";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(125, 274);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(103, 24);
			this.label12.TabIndex = 25;
			this.label12.Text = "Average Damage:";
			// 
			// txtAverageDamage
			// 
			this.txtAverageDamage.Location = new System.Drawing.Point(219, 271);
			this.txtAverageDamage.Name = "txtAverageDamage";
			this.txtAverageDamage.ReadOnly = true;
			this.txtAverageDamage.Size = new System.Drawing.Size(32, 20);
			this.txtAverageDamage.TabIndex = 13;
			this.txtAverageDamage.Text = "0";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(133, 189);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(90, 13);
			this.label13.TabIndex = 27;
			this.label13.Text = "Damage Modifier:";
			// 
			// txtAttackMod
			// 
			this.txtAttackMod.Location = new System.Drawing.Point(219, 186);
			this.txtAttackMod.Name = "txtAttackMod";
			this.txtAttackMod.Size = new System.Drawing.Size(40, 20);
			this.txtAttackMod.TabIndex = 6;
			this.txtAttackMod.Text = "0";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(12, 189);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(105, 13);
			this.label14.TabIndex = 29;
			this.label14.Text = "Damage Calculation:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 359);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtAttackMod);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtAverageDamage);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtTotalDamage);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtD6);
			this.Controls.Add(this.txtD8);
			this.Controls.Add(this.txtD10);
			this.Controls.Add(this.txtD12);
			this.Controls.Add(this.txtD4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtCreaturesThatHit);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.txtMinNeededToHit);
			this.Controls.Add(this.txtNumCreatures);
			this.Controls.Add(this.txtAC);
			this.Controls.Add(this.txtAttackRoll);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mob Damage Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAttackRoll;
        private System.Windows.Forms.TextBox txtAC;
        private System.Windows.Forms.TextBox txtNumCreatures;
        private System.Windows.Forms.TextBox txtMinNeededToHit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCreaturesThatHit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtD4;
        private System.Windows.Forms.TextBox txtD12;
        private System.Windows.Forms.TextBox txtD10;
        private System.Windows.Forms.TextBox txtD8;
        private System.Windows.Forms.TextBox txtD6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalDamage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAverageDamage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAttackMod;
        private System.Windows.Forms.Label label14;
    }
}


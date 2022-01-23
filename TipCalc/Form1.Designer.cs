namespace TipCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.totalperperson = new System.Windows.Forms.Label();
            this.tipperpersonlabel = new System.Windows.Forms.Label();
            this.total_per_person_label = new System.Windows.Forms.Label();
            this.tip_per_person_label = new System.Windows.Forms.Label();
            this.no_of_people_label = new System.Windows.Forms.Label();
            this.tiplabel = new System.Windows.Forms.Label();
            this.numberofpeople = new System.Windows.Forms.TextBox();
            this.decrementppl = new System.Windows.Forms.Button();
            this.incrementppl = new System.Windows.Forms.Button();
            this.decrementpercent = new System.Windows.Forms.Button();
            this.tippercent = new System.Windows.Forms.TextBox();
            this.incrementpercent = new System.Windows.Forms.Button();
            this.decrement = new System.Windows.Forms.Button();
            this.billamount = new System.Windows.Forms.TextBox();
            this.increment = new System.Windows.Forms.Button();
            this.Bill = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.clear);
            this.panel2.Controls.Add(this.calculate);
            this.panel2.Controls.Add(this.totalperperson);
            this.panel2.Controls.Add(this.tipperpersonlabel);
            this.panel2.Controls.Add(this.total_per_person_label);
            this.panel2.Controls.Add(this.tip_per_person_label);
            this.panel2.Controls.Add(this.no_of_people_label);
            this.panel2.Controls.Add(this.tiplabel);
            this.panel2.Controls.Add(this.numberofpeople);
            this.panel2.Controls.Add(this.decrementppl);
            this.panel2.Controls.Add(this.incrementppl);
            this.panel2.Controls.Add(this.decrementpercent);
            this.panel2.Controls.Add(this.tippercent);
            this.panel2.Controls.Add(this.incrementpercent);
            this.panel2.Controls.Add(this.decrement);
            this.panel2.Controls.Add(this.billamount);
            this.panel2.Controls.Add(this.increment);
            this.panel2.Controls.Add(this.Bill);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1257, 540);
            this.panel2.TabIndex = 1;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(422, 325);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(267, 61);
            this.clear.TabIndex = 19;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(74, 325);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(252, 61);
            this.calculate.TabIndex = 18;
            this.calculate.Text = "CALCULATE";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click_1);
            // 
            // totalperperson
            // 
            this.totalperperson.AutoSize = true;
            this.totalperperson.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalperperson.Location = new System.Drawing.Point(831, 151);
            this.totalperperson.Name = "totalperperson";
            this.totalperperson.Size = new System.Drawing.Size(98, 29);
            this.totalperperson.TabIndex = 17;
            this.totalperperson.Text = "$ 0.00";
            // 
            // tipperpersonlabel
            // 
            this.tipperpersonlabel.AutoSize = true;
            this.tipperpersonlabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipperpersonlabel.Location = new System.Drawing.Point(831, 76);
            this.tipperpersonlabel.Name = "tipperpersonlabel";
            this.tipperpersonlabel.Size = new System.Drawing.Size(98, 29);
            this.tipperpersonlabel.TabIndex = 16;
            this.tipperpersonlabel.Text = "$ 0.00";
            // 
            // total_per_person_label
            // 
            this.total_per_person_label.AutoSize = true;
            this.total_per_person_label.Location = new System.Drawing.Point(599, 162);
            this.total_per_person_label.Name = "total_per_person_label";
            this.total_per_person_label.Size = new System.Drawing.Size(188, 18);
            this.total_per_person_label.TabIndex = 15;
            this.total_per_person_label.Text = "TOTAL PER PERSON";
            // 
            // tip_per_person_label
            // 
            this.tip_per_person_label.AutoSize = true;
            this.tip_per_person_label.Location = new System.Drawing.Point(627, 78);
            this.tip_per_person_label.Name = "tip_per_person_label";
            this.tip_per_person_label.Size = new System.Drawing.Size(160, 18);
            this.tip_per_person_label.TabIndex = 12;
            this.tip_per_person_label.Text = "TIP PER PERSON";
            // 
            // no_of_people_label
            // 
            this.no_of_people_label.AutoSize = true;
            this.no_of_people_label.Location = new System.Drawing.Point(74, 203);
            this.no_of_people_label.Name = "no_of_people_label";
            this.no_of_people_label.Size = new System.Drawing.Size(145, 18);
            this.no_of_people_label.TabIndex = 11;
            this.no_of_people_label.Text = "NO. OF PEOPLE";
            // 
            // tiplabel
            // 
            this.tiplabel.AutoSize = true;
            this.tiplabel.Location = new System.Drawing.Point(71, 132);
            this.tiplabel.Name = "tiplabel";
            this.tiplabel.Size = new System.Drawing.Size(65, 18);
            this.tiplabel.TabIndex = 10;
            this.tiplabel.Text = "TIP %";
            // 
            // numberofpeople
            // 
            this.numberofpeople.Location = new System.Drawing.Point(198, 235);
            this.numberofpeople.Name = "numberofpeople";
            this.numberofpeople.PlaceholderText = "1";
            this.numberofpeople.Size = new System.Drawing.Size(214, 27);
            this.numberofpeople.TabIndex = 9;
            this.numberofpeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberofpeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberofpeople_KeyPress);
            // 
            // decrementppl
            // 
            this.decrementppl.Location = new System.Drawing.Point(418, 233);
            this.decrementppl.Name = "decrementppl";
            this.decrementppl.Size = new System.Drawing.Size(125, 29);
            this.decrementppl.TabIndex = 8;
            this.decrementppl.Text = "-";
            this.decrementppl.UseVisualStyleBackColor = true;
            this.decrementppl.Click += new System.EventHandler(this.decrementppl_Click);
            // 
            // incrementppl
            // 
            this.incrementppl.Location = new System.Drawing.Point(74, 233);
            this.incrementppl.Name = "incrementppl";
            this.incrementppl.Size = new System.Drawing.Size(118, 27);
            this.incrementppl.TabIndex = 7;
            this.incrementppl.Text = "+";
            this.incrementppl.UseVisualStyleBackColor = true;
            this.incrementppl.Click += new System.EventHandler(this.incrementppl_Click);
            // 
            // decrementpercent
            // 
            this.decrementpercent.Location = new System.Drawing.Point(422, 162);
            this.decrementpercent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.decrementpercent.Name = "decrementpercent";
            this.decrementpercent.Size = new System.Drawing.Size(121, 27);
            this.decrementpercent.TabIndex = 6;
            this.decrementpercent.Text = "-";
            this.decrementpercent.UseVisualStyleBackColor = true;
            this.decrementpercent.Click += new System.EventHandler(this.decrementpercent_Click);
            // 
            // tippercent
            // 
            this.tippercent.Location = new System.Drawing.Point(198, 162);
            this.tippercent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tippercent.Name = "tippercent";
            this.tippercent.PlaceholderText = "0%";
            this.tippercent.Size = new System.Drawing.Size(214, 27);
            this.tippercent.TabIndex = 5;
            this.tippercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tippercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tippercent_KeyPress);
            // 
            // incrementpercent
            // 
            this.incrementpercent.Location = new System.Drawing.Point(74, 162);
            this.incrementpercent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.incrementpercent.Name = "incrementpercent";
            this.incrementpercent.Size = new System.Drawing.Size(118, 27);
            this.incrementpercent.TabIndex = 4;
            this.incrementpercent.Text = "+";
            this.incrementpercent.UseVisualStyleBackColor = true;
            this.incrementpercent.Click += new System.EventHandler(this.incrementpercent_Click);
            // 
            // decrement
            // 
            this.decrement.Location = new System.Drawing.Point(422, 78);
            this.decrement.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.decrement.Name = "decrement";
            this.decrement.Size = new System.Drawing.Size(121, 32);
            this.decrement.TabIndex = 3;
            this.decrement.Text = "-";
            this.decrement.UseVisualStyleBackColor = true;
            this.decrement.Click += new System.EventHandler(this.decrement_Click);
            // 
            // billamount
            // 
            this.billamount.Location = new System.Drawing.Point(202, 78);
            this.billamount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.billamount.Name = "billamount";
            this.billamount.PlaceholderText = "$ 0.00";
            this.billamount.Size = new System.Drawing.Size(210, 27);
            this.billamount.TabIndex = 2;
            this.billamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.billamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.billamount_KeyPress);
            // 
            // increment
            // 
            this.increment.Location = new System.Drawing.Point(74, 78);
            this.increment.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(118, 32);
            this.increment.TabIndex = 1;
            this.increment.Text = "+";
            this.increment.UseVisualStyleBackColor = true;
            this.increment.Click += new System.EventHandler(this.increment_Click);
            // 
            // Bill
            // 
            this.Bill.AutoSize = true;
            this.Bill.Location = new System.Drawing.Point(74, 31);
            this.Bill.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(48, 18);
            this.Bill.TabIndex = 0;
            this.Bill.Text = "BILL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 540);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIP CALCULATOR";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel2;
        private Label Bill;
        private Button decrementpercent;
        private TextBox tippercent;
        private Button incrementpercent;
        private Button decrement;
        private TextBox billamount;
        private Button increment;
        private TextBox numberofpeople;
        private Button decrementppl;
        private Button incrementppl;
        private Label total_per_person_label;
        private Label tip_per_person_label;
        private Label no_of_people_label;
        private Label tiplabel;
        private Label totalperperson;
        private Label tipperpersonlabel;
        private Button clear;
        private Button calculate;
    }
}
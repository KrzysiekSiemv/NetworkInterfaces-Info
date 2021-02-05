
namespace NetworkInterface_Info
{
    partial class traceroute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(traceroute));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearText = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.destination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.dontShowHostnames = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maxHops = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxHops)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maxHops);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dontShowHostnames);
            this.panel1.Controls.Add(this.clearText);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.destination);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 91);
            this.panel1.TabIndex = 2;
            // 
            // clearText
            // 
            this.clearText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clearText.Location = new System.Drawing.Point(364, 51);
            this.clearText.Name = "clearText";
            this.clearText.Size = new System.Drawing.Size(168, 23);
            this.clearText.TabIndex = 9;
            this.clearText.Text = "Wyczyść";
            this.clearText.UseVisualStyleBackColor = true;
            this.clearText.Click += new System.EventHandler(this.clearText_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(364, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Śledź!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.startTracing);
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(174, 14);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(114, 20);
            this.destination.TabIndex = 1;
            this.destination.Text = "onet.pl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cel (domena lub adres IP):";
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.White;
            this.outputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputText.Location = new System.Drawing.Point(0, 91);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.outputText.Size = new System.Drawing.Size(544, 360);
            this.outputText.TabIndex = 3;
            this.outputText.Text = "";
            // 
            // dontShowHostnames
            // 
            this.dontShowHostnames.AutoSize = true;
            this.dontShowHostnames.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dontShowHostnames.Location = new System.Drawing.Point(36, 40);
            this.dontShowHostnames.Name = "dontShowHostnames";
            this.dontShowHostnames.Size = new System.Drawing.Size(152, 17);
            this.dontShowHostnames.TabIndex = 10;
            this.dontShowHostnames.Text = "Nie pokazuj nazwy hostów";
            this.dontShowHostnames.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Maksymalna liczba przeskoków:";
            // 
            // maxHops
            // 
            this.maxHops.Location = new System.Drawing.Point(174, 63);
            this.maxHops.Name = "maxHops";
            this.maxHops.Size = new System.Drawing.Size(89, 20);
            this.maxHops.TabIndex = 12;
            this.maxHops.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // traceroute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 451);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 490);
            this.Name = "traceroute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trace Route - NetworkInterfaces.Info";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxHops)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox destination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.CheckBox dontShowHostnames;
        private System.Windows.Forms.NumericUpDown maxHops;
        private System.Windows.Forms.Label label2;
    }
}
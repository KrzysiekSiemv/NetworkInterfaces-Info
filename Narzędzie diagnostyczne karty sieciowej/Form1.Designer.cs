
namespace Narzędzie_diagnostyczne_karty_sieciowej
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zarzadzanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generujPlikTekstowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odświeżInformacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wkrótceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stworzonePrzezKrzysiekSiemvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(596, 366);
            this.textBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zarzadzanieToolStripMenuItem,
            this.czcionkaToolStripMenuItem,
            this.opcjeToolStripMenuItem,
            this.stworzonePrzezKrzysiekSiemvToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zarzadzanieToolStripMenuItem
            // 
            this.zarzadzanieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generujPlikTekstowyToolStripMenuItem,
            this.odświeżInformacjeToolStripMenuItem});
            this.zarzadzanieToolStripMenuItem.Name = "zarzadzanieToolStripMenuItem";
            this.zarzadzanieToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.zarzadzanieToolStripMenuItem.Text = "Zarządzanie";
            // 
            // generujPlikTekstowyToolStripMenuItem
            // 
            this.generujPlikTekstowyToolStripMenuItem.Name = "generujPlikTekstowyToolStripMenuItem";
            this.generujPlikTekstowyToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.generujPlikTekstowyToolStripMenuItem.Text = "Generuj plik tekstowy";
            this.generujPlikTekstowyToolStripMenuItem.Click += new System.EventHandler(this.generate);
            // 
            // odświeżInformacjeToolStripMenuItem
            // 
            this.odświeżInformacjeToolStripMenuItem.Name = "odświeżInformacjeToolStripMenuItem";
            this.odświeżInformacjeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.odświeżInformacjeToolStripMenuItem.Text = "Odśwież informacje";
            this.odświeżInformacjeToolStripMenuItem.Click += new System.EventHandler(this.refresh);
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.czcionkaToolStripMenuItem.Text = "Czcionka";
            this.czcionkaToolStripMenuItem.Click += new System.EventHandler(this.changeFont);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wkrótceToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // wkrótceToolStripMenuItem
            // 
            this.wkrótceToolStripMenuItem.Enabled = false;
            this.wkrótceToolStripMenuItem.Name = "wkrótceToolStripMenuItem";
            this.wkrótceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wkrótceToolStripMenuItem.Text = "Wkrótce";
            // 
            // stworzonePrzezKrzysiekSiemvToolStripMenuItem
            // 
            this.stworzonePrzezKrzysiekSiemvToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.stworzonePrzezKrzysiekSiemvToolStripMenuItem.Name = "stworzonePrzezKrzysiekSiemvToolStripMenuItem";
            this.stworzonePrzezKrzysiekSiemvToolStripMenuItem.Size = new System.Drawing.Size(181, 20);
            this.stworzonePrzezKrzysiekSiemvToolStripMenuItem.Text = "Stworzone przez KrzysiekSiemv";
            this.stworzonePrzezKrzysiekSiemvToolStripMenuItem.Click += new System.EventHandler(this.stworzonePrzezKrzysiekSiemvToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 390);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NetworkInterfaces Diagnostic";
            this.Load += new System.EventHandler(this.onLoad);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zarzadzanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generujPlikTekstowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odświeżInformacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wkrótceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stworzonePrzezKrzysiekSiemvToolStripMenuItem;
    }
}


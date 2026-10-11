
namespace GulSatisi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpGulMelumatlari;
        private System.Windows.Forms.Label lblGulNovu;
        private System.Windows.Forms.Label lblSay;
        private System.Windows.Forms.Label lblQiymet;
        private System.Windows.Forms.Label lblToplamBasliq;
        private System.Windows.Forms.Label lblToplamGelir;
        private System.Windows.Forms.TextBox txtGulNovu;
        private System.Windows.Forms.TextBox txtSay;
        private System.Windows.Forms.TextBox txtQiymet;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnCixis;
        private System.Windows.Forms.PictureBox picFlower;
        private System.Windows.Forms.PictureBox picDibcek;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            grpGulMelumatlari = new GroupBox();
            lblGulNovu = new Label();
            txtGulNovu = new TextBox();
            lblSay = new Label();
            txtSay = new TextBox();
            lblQiymet = new Label();
            txtQiymet = new TextBox();
            picFlower = new PictureBox();
            btnSatis = new Button();
            lblToplamBasliq = new Label();
            lblToplamGelir = new Label();
            btnCixis = new Button();
            picDibcek = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpGulMelumatlari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFlower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDibcek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(804, 290);
            dataGridView1.TabIndex = 0;
            // 
            // grpGulMelumatlari
            // 
            grpGulMelumatlari.Controls.Add(lblGulNovu);
            grpGulMelumatlari.Controls.Add(txtGulNovu);
            grpGulMelumatlari.Controls.Add(lblSay);
            grpGulMelumatlari.Controls.Add(txtSay);
            grpGulMelumatlari.Controls.Add(lblQiymet);
            grpGulMelumatlari.Controls.Add(txtQiymet);
            grpGulMelumatlari.Controls.Add(picFlower);
            grpGulMelumatlari.Controls.Add(btnSatis);
            grpGulMelumatlari.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpGulMelumatlari.ForeColor = Color.White;
            grpGulMelumatlari.Location = new Point(12, 315);
            grpGulMelumatlari.Name = "grpGulMelumatlari";
            grpGulMelumatlari.Size = new Size(415, 240);
            grpGulMelumatlari.TabIndex = 1;
            grpGulMelumatlari.TabStop = false;
            grpGulMelumatlari.Text = "Gül məlumatları";
            // 
            // lblGulNovu
            // 
            lblGulNovu.ForeColor = Color.White;
            lblGulNovu.Location = new Point(28, 35);
            lblGulNovu.Name = "lblGulNovu";
            lblGulNovu.Size = new Size(130, 25);
            lblGulNovu.TabIndex = 0;
            lblGulNovu.Text = "Gül növü";
            // 
            // txtGulNovu
            // 
            txtGulNovu.Font = new Font("Segoe UI", 11F);
            txtGulNovu.Location = new Point(28, 65);
            txtGulNovu.Name = "txtGulNovu";
            txtGulNovu.Size = new Size(195, 32);
            txtGulNovu.TabIndex = 1;
            // 
            // lblSay
            // 
            lblSay.ForeColor = Color.White;
            lblSay.Location = new Point(28, 115);
            lblSay.Name = "lblSay";
            lblSay.Size = new Size(80, 25);
            lblSay.TabIndex = 2;
            lblSay.Text = "Say";
            // 
            // txtSay
            // 
            txtSay.Font = new Font("Segoe UI", 11F);
            txtSay.Location = new Point(28, 145);
            txtSay.Name = "txtSay";
            txtSay.Size = new Size(80, 32);
            txtSay.TabIndex = 3;
            // 
            // lblQiymet
            // 
            lblQiymet.ForeColor = Color.White;
            lblQiymet.Location = new Point(145, 115);
            lblQiymet.Name = "lblQiymet";
            lblQiymet.Size = new Size(80, 25);
            lblQiymet.TabIndex = 4;
            lblQiymet.Text = "Qiymət";
            // 
            // txtQiymet
            // 
            txtQiymet.Font = new Font("Segoe UI", 11F);
            txtQiymet.Location = new Point(145, 145);
            txtQiymet.Name = "txtQiymet";
            txtQiymet.Size = new Size(80, 32);
            txtQiymet.TabIndex = 5;
            // 
            // picFlower
            // 
            picFlower.BackColor = Color.Transparent;
            picFlower.Image = Properties.Resources.flover;
            picFlower.Location = new Point(255, 25);
            picFlower.Name = "picFlower";
            picFlower.Size = new Size(120, 100);
            picFlower.SizeMode = PictureBoxSizeMode.Zoom;
            picFlower.TabIndex = 6;
            picFlower.TabStop = false;
            // 
            // btnSatis
            // 
            btnSatis.BackColor = Color.DarkRed;
            btnSatis.FlatStyle = FlatStyle.Flat;
            btnSatis.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSatis.ForeColor = Color.White;
            btnSatis.Location = new Point(250, 140);
            btnSatis.Name = "btnSatis";
            btnSatis.Size = new Size(125, 52);
            btnSatis.TabIndex = 7;
            btnSatis.Text = "Satış et";
            btnSatis.UseVisualStyleBackColor = false;
            btnSatis.Click += BtnSatis_Click;
            // 
            // lblToplamBasliq
            // 
            lblToplamBasliq.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblToplamBasliq.ForeColor = Color.White;
            lblToplamBasliq.Location = new Point(480, 320);
            lblToplamBasliq.Name = "lblToplamBasliq";
            lblToplamBasliq.Size = new Size(160, 32);
            lblToplamBasliq.TabIndex = 2;
            lblToplamBasliq.Text = "Toplam gəlir:";
            // 
            // lblToplamGelir
            // 
            lblToplamGelir.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblToplamGelir.ForeColor = Color.White;
            lblToplamGelir.Location = new Point(645, 320);
            lblToplamGelir.Name = "lblToplamGelir";
            lblToplamGelir.Size = new Size(140, 32);
            lblToplamGelir.TabIndex = 3;
            lblToplamGelir.Text = "0.00";
            // 
            // btnCixis
            // 
            btnCixis.BackColor = Color.Orange;
            btnCixis.FlatStyle = FlatStyle.Flat;
            btnCixis.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCixis.ForeColor = Color.Black;
            btnCixis.Location = new Point(635, 520);
            btnCixis.Name = "btnCixis";
            btnCixis.Size = new Size(110, 45);
            btnCixis.TabIndex = 5;
            btnCixis.Text = "Çıxış";
            btnCixis.UseVisualStyleBackColor = false;
            btnCixis.Click += BtnCixis_Click;
            // 
            // picDibcek
            // 
            picDibcek.BackColor = Color.Transparent;
            picDibcek.Image = Properties.Resources.dibçək;
            picDibcek.Location = new Point(610, 365);
            picDibcek.Name = "picDibcek";
            picDibcek.Size = new Size(165, 150);
            picDibcek.SizeMode = PictureBoxSizeMode.Zoom;
            picDibcek.TabIndex = 4;
            picDibcek.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Gül növü (gül adı)";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Satış sayı";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Qiyməti";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Yekun qiyməti";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(820, 600);
            Controls.Add(dataGridView1);
            Controls.Add(grpGulMelumatlari);
            Controls.Add(lblToplamBasliq);
            Controls.Add(lblToplamGelir);
            Controls.Add(picDibcek);
            Controls.Add(btnCixis);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gül satışı";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpGulMelumatlari.ResumeLayout(false);
            grpGulMelumatlari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFlower).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDibcek).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

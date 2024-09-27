namespace FORMSAPI
{
    partial class FrmMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            panel1 = new Panel();
            btnHome = new Button();
            imageList1 = new ImageList(components);
            button5 = new Button();
            button1 = new Button();
            btnSair = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnCliente = new Button();
            panelLogo = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(panelLogo);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 455);
            panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.Highlight;
            btnHome.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnHome.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btnHome.FlatAppearance.MouseOverBackColor = Color.White;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = SystemColors.InactiveBorder;
            btnHome.ImageIndex = 0;
            btnHome.ImageList = imageList1;
            btnHome.Location = new Point(3, 79);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(130, 54);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home_3010995.png");
            imageList1.Images.SetKeyName(1, "—Pngtree—database setup icon flat style_5174668.png");
            imageList1.Images.SetKeyName(2, "icone-de-configuracao-vector-isolado-em-fundo-transparente-design-de-logotipo-de-configuracao-700-141374498.jpg");
            imageList1.Images.SetKeyName(3, "tecnico-em-desenvolvimento-de-sistemas-logo-258DFB6B6F-seeklogo.com.png");
            imageList1.Images.SetKeyName(4, "emergency-exit_4009127.png");
            imageList1.Images.SetKeyName(5, "satisfied-customer_2039048.png");
            imageList1.Images.SetKeyName(6, "—Pngtree—database setup icon flat style_5174668.png");
            imageList1.Images.SetKeyName(7, "—Pngtree—warehouse workers check quantity and_7579801.png");
            imageList1.Images.SetKeyName(8, "pedido.png");
            imageList1.Images.SetKeyName(9, "fornecedor.png");
            imageList1.Images.SetKeyName(10, "carrinho-de-compras (1).png");
            imageList1.Images.SetKeyName(11, "comerciante.png");
            imageList1.Images.SetKeyName(12, "engrenagens.png");
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Highlight;
            button5.FlatAppearance.BorderColor = SystemColors.Highlight;
            button5.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            button5.FlatAppearance.MouseOverBackColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.InactiveBorder;
            button5.ImageIndex = 8;
            button5.ImageList = imageList1;
            button5.Location = new Point(0, 291);
            button5.Name = "button5";
            button5.Size = new Size(130, 42);
            button5.TabIndex = 8;
            button5.Text = "Pedidos";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderColor = SystemColors.Highlight;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.HighlightText;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 12;
            button1.ImageList = imageList1;
            button1.Location = new Point(0, 373);
            button1.Name = "button1";
            button1.Size = new Size(138, 40);
            button1.TabIndex = 7;
            button1.Text = " Configurações";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.Highlight;
            btnSair.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnSair.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btnSair.FlatAppearance.MouseOverBackColor = Color.White;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.ForeColor = SystemColors.InactiveBorder;
            btnSair.ImageIndex = 9;
            btnSair.ImageList = imageList1;
            btnSair.Location = new Point(-3, 410);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(130, 42);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.MiddleLeft;
            btnSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.FlatAppearance.BorderColor = SystemColors.Highlight;
            button4.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            button4.FlatAppearance.MouseOverBackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.InactiveBorder;
            button4.ImageIndex = 11;
            button4.ImageList = imageList1;
            button4.Location = new Point(0, 254);
            button4.Name = "button4";
            button4.Size = new Size(130, 42);
            button4.TabIndex = 5;
            button4.Text = "Vendedores";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.FlatAppearance.BorderColor = SystemColors.Highlight;
            button3.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            button3.FlatAppearance.MouseOverBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.InactiveBorder;
            button3.ImageIndex = 9;
            button3.ImageList = imageList1;
            button3.Location = new Point(0, 215);
            button3.Name = "button3";
            button3.Size = new Size(130, 42);
            button3.TabIndex = 4;
            button3.Text = "Fornecedores";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatAppearance.BorderColor = SystemColors.Highlight;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.InactiveBorder;
            button2.ImageIndex = 10;
            button2.ImageList = imageList1;
            button2.Location = new Point(3, 175);
            button2.Name = "button2";
            button2.Size = new Size(130, 42);
            button2.TabIndex = 3;
            button2.Text = "Produtos";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = SystemColors.Highlight;
            btnCliente.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnCliente.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btnCliente.FlatAppearance.MouseOverBackColor = Color.White;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.ForeColor = SystemColors.InactiveBorder;
            btnCliente.ImageIndex = 10;
            btnCliente.ImageList = imageList1;
            btnCliente.Location = new Point(0, 127);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(130, 42);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Clientes";
            btnCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.SkyBlue;
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(141, 73);
            panelLogo.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(138, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(645, 452);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(113, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(303, 312);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmMenu";
            Text = "Menu Pedidos";
            panel1.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelLogo;
        private Button btnHome;
        private Button btnSair;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnCliente;
        private Button button1;
        private Panel panel2;
        private Button button5;
        private PictureBox pictureBox2;
        private ImageList imageList1;
        private PictureBox pictureBox1;
    }
}
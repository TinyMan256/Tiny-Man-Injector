
using System.Windows.Forms;

namespace Tiny_Injector
{
    partial class injector
    {
      
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(injector));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.comboId = new System.Windows.Forms.ComboBox();
            this.bInject = new System.Windows.Forms.Button();
            this.bSearchDll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textDll = new System.Windows.Forms.TextBox();
            this.picProcess = new System.Windows.Forms.PictureBox();
            this.comboProcess = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeProcess = new System.Windows.Forms.Button();
            this.minimizeProcess = new System.Windows.Forms.Button();
            this.bOptions = new System.Windows.Forms.Button();
            this.bSaveSelection = new System.Windows.Forms.Button();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.boxInjectOnStartup = new System.Windows.Forms.Button();
            this.boxCloseOnInject = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeProcess1 = new System.Windows.Forms.Button();
            this.minimizeProcess1 = new System.Windows.Forms.Button();
            this.bMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.l_closeOnInject = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcess)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMenu);
            this.tabControl.Controls.Add(this.tabOptions);
            this.tabControl.Location = new System.Drawing.Point(-30, -30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(400, 400);
            this.tabControl.TabIndex = 2;
            // 
            // tabMenu
            // 
            this.tabMenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.tabMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabMenu.BackgroundImage")));
            this.tabMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabMenu.Controls.Add(this.label4);
            this.tabMenu.Controls.Add(this.comboId);
            this.tabMenu.Controls.Add(this.bInject);
            this.tabMenu.Controls.Add(this.bSearchDll);
            this.tabMenu.Controls.Add(this.label3);
            this.tabMenu.Controls.Add(this.textDll);
            this.tabMenu.Controls.Add(this.picProcess);
            this.tabMenu.Controls.Add(this.comboProcess);
            this.tabMenu.Controls.Add(this.label2);
            this.tabMenu.Controls.Add(this.comboMethod);
            this.tabMenu.Controls.Add(this.label1);
            this.tabMenu.Controls.Add(this.panel1);
            this.tabMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(10);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(392, 374);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "1";
            this.tabMenu.Click += new System.EventHandler(this.tabMenu_Click);
            this.tabMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Black Ops One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(138, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Process Id:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboId
            // 
            this.comboId.BackColor = System.Drawing.Color.Lime;
            this.comboId.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboId.Font = new System.Drawing.Font("Black Ops One", 10F);
            this.comboId.ForeColor = System.Drawing.Color.Black;
            this.comboId.FormattingEnabled = true;
            this.comboId.Location = new System.Drawing.Point(148, 122);
            this.comboId.Name = "comboId";
            this.comboId.Size = new System.Drawing.Size(105, 24);
            this.comboId.TabIndex = 15;
            this.comboId.DropDown += new System.EventHandler(this.ComboId_DropDown);
            // 
            // bInject
            // 
            this.bInject.BackColor = System.Drawing.Color.Black;
            this.bInject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bInject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInject.Font = new System.Drawing.Font("Black Ops One", 30F);
            this.bInject.ForeColor = System.Drawing.Color.Lime;
            this.bInject.Image = ((System.Drawing.Image)(resources.GetObject("bInject.Image")));
            this.bInject.Location = new System.Drawing.Point(17, 291);
            this.bInject.Name = "bInject";
            this.bInject.Size = new System.Drawing.Size(369, 77);
            this.bInject.TabIndex = 13;
            this.bInject.Text = "inject";
            this.bInject.UseVisualStyleBackColor = true;
            this.bInject.Click += new System.EventHandler(this.bInject_Click);
            // 
            // bSearchDll
            // 
            this.bSearchDll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSearchDll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSearchDll.Location = new System.Drawing.Point(219, 241);
            this.bSearchDll.Name = "bSearchDll";
            this.bSearchDll.Size = new System.Drawing.Size(65, 23);
            this.bSearchDll.TabIndex = 12;
            this.bSearchDll.Text = "Browse";
            this.bSearchDll.UseVisualStyleBackColor = true;
            this.bSearchDll.Click += new System.EventHandler(this.bSearchDll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Black Ops One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(115, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "DLL Path:";
            // 
            // textDll
            // 
            this.textDll.BackColor = System.Drawing.Color.Lime;
            this.textDll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDll.Font = new System.Drawing.Font("Black Ops One", 10F);
            this.textDll.ForeColor = System.Drawing.Color.Black;
            this.textDll.Location = new System.Drawing.Point(119, 265);
            this.textDll.Name = "textDll";
            this.textDll.Size = new System.Drawing.Size(165, 24);
            this.textDll.TabIndex = 10;
            // 
            // picProcess
            // 
            this.picProcess.BackColor = System.Drawing.Color.Transparent;
            this.picProcess.Image = global::Tiny_Injector.Properties.Resources.Wrong;
            this.picProcess.Location = new System.Drawing.Point(345, 60);
            this.picProcess.Name = "picProcess";
            this.picProcess.Size = new System.Drawing.Size(19, 23);
            this.picProcess.TabIndex = 9;
            this.picProcess.TabStop = false;
            this.picProcess.Click += new System.EventHandler(this.picProcess_Click);
            // 
            // comboProcess
            // 
            this.comboProcess.BackColor = System.Drawing.Color.Lime;
            this.comboProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboProcess.Font = new System.Drawing.Font("Black Ops One", 8F);
            this.comboProcess.ForeColor = System.Drawing.Color.Black;
            this.comboProcess.FormattingEnabled = true;
            this.comboProcess.ItemHeight = 14;
            this.comboProcess.Location = new System.Drawing.Point(211, 61);
            this.comboProcess.Name = "comboProcess";
            this.comboProcess.Size = new System.Drawing.Size(128, 22);
            this.comboProcess.TabIndex = 7;
            this.comboProcess.DropDown += new System.EventHandler(this.ComboProcess_DropDown);
            this.comboProcess.SelectedIndexChanged += new System.EventHandler(this.comboProcess_SelectedIndexChanged);
            this.comboProcess.TextChanged += new System.EventHandler(this.ComboProcess_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Black Ops One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(105, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Injection Method:";
            // 
            // comboMethod
            // 
            this.comboMethod.BackColor = System.Drawing.Color.Lime;
            this.comboMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMethod.Font = new System.Drawing.Font("Black Ops One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMethod.FormattingEnabled = true;
            this.comboMethod.Location = new System.Drawing.Point(119, 193);
            this.comboMethod.Name = "comboMethod";
            this.comboMethod.Size = new System.Drawing.Size(165, 22);
            this.comboMethod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Black Ops One", 12.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Process:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.closeProcess);
            this.panel1.Controls.Add(this.minimizeProcess);
            this.panel1.Controls.Add(this.bOptions);
            this.panel1.Controls.Add(this.bSaveSelection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 56);
            this.panel1.TabIndex = 16;
            // 
            // closeProcess
            // 
            this.closeProcess.BackColor = System.Drawing.Color.Black;
            this.closeProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeProcess.FlatAppearance.BorderSize = 0;
            this.closeProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeProcess.Font = new System.Drawing.Font("Black Ops One", 25.9F);
            this.closeProcess.ForeColor = System.Drawing.Color.Red;
            this.closeProcess.Location = new System.Drawing.Point(321, 5);
            this.closeProcess.Name = "closeProcess";
            this.closeProcess.Size = new System.Drawing.Size(51, 49);
            this.closeProcess.TabIndex = 7;
            this.closeProcess.Text = "x";
            this.closeProcess.UseVisualStyleBackColor = false;
            this.closeProcess.Click += new System.EventHandler(this.closeProcess_Click);
            // 
            // minimizeProcess
            // 
            this.minimizeProcess.BackColor = System.Drawing.Color.Black;
            this.minimizeProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeProcess.FlatAppearance.BorderSize = 0;
            this.minimizeProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizeProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeProcess.Font = new System.Drawing.Font("Black Ops One", 20.25F);
            this.minimizeProcess.ForeColor = System.Drawing.Color.White;
            this.minimizeProcess.Location = new System.Drawing.Point(264, 2);
            this.minimizeProcess.Name = "minimizeProcess";
            this.minimizeProcess.Size = new System.Drawing.Size(51, 38);
            this.minimizeProcess.TabIndex = 6;
            this.minimizeProcess.Text = "_";
            this.minimizeProcess.UseVisualStyleBackColor = false;
            this.minimizeProcess.Click += new System.EventHandler(this.minimizeProcess_Click);
            // 
            // bOptions
            // 
            this.bOptions.BackColor = System.Drawing.Color.Black;
            this.bOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOptions.FlatAppearance.BorderSize = 0;
            this.bOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOptions.Font = new System.Drawing.Font("Black Ops One", 15.25F);
            this.bOptions.ForeColor = System.Drawing.Color.Lime;
            this.bOptions.Location = new System.Drawing.Point(23, 5);
            this.bOptions.Name = "bOptions";
            this.bOptions.Size = new System.Drawing.Size(109, 53);
            this.bOptions.TabIndex = 5;
            this.bOptions.Text = "Options";
            this.bOptions.UseVisualStyleBackColor = false;
            this.bOptions.Click += new System.EventHandler(this.bOptions_Click);
            // 
            // bSaveSelection
            // 
            this.bSaveSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSaveSelection.FlatAppearance.BorderSize = 0;
            this.bSaveSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveSelection.Font = new System.Drawing.Font("Black Ops One", 15F);
            this.bSaveSelection.ForeColor = System.Drawing.Color.Lime;
            this.bSaveSelection.Location = new System.Drawing.Point(138, 7);
            this.bSaveSelection.Name = "bSaveSelection";
            this.bSaveSelection.Size = new System.Drawing.Size(120, 49);
            this.bSaveSelection.TabIndex = 4;
            this.bSaveSelection.Text = "Save";
            this.bSaveSelection.UseVisualStyleBackColor = true;
            this.bSaveSelection.Click += new System.EventHandler(this.bSaveSelection_Click);
            // 
            // tabOptions
            // 
            this.tabOptions.BackColor = System.Drawing.Color.White;
            this.tabOptions.BackgroundImage = global::Tiny_Injector.Properties.Resources.options_background;
            this.tabOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabOptions.Controls.Add(this.boxInjectOnStartup);
            this.tabOptions.Controls.Add(this.boxCloseOnInject);
            this.tabOptions.Controls.Add(this.label6);
            this.tabOptions.Controls.Add(this.bSave);
            this.tabOptions.Controls.Add(this.panel2);
            this.tabOptions.Controls.Add(this.button2);
            this.tabOptions.Controls.Add(this.button1);
            this.tabOptions.Controls.Add(this.l_closeOnInject);
            this.tabOptions.Font = new System.Drawing.Font("Black Ops One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(392, 374);
            this.tabOptions.TabIndex = 1;
            this.tabOptions.Text = "2";
            this.tabOptions.Click += new System.EventHandler(this.tabOptions_Click);
            this.tabOptions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // boxInjectOnStartup
            // 
            this.boxInjectOnStartup.BackColor = System.Drawing.Color.Black;
            this.boxInjectOnStartup.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.boxInjectOnStartup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxInjectOnStartup.ForeColor = System.Drawing.Color.White;
            this.boxInjectOnStartup.Location = new System.Drawing.Point(287, 176);
            this.boxInjectOnStartup.Name = "boxInjectOnStartup";
            this.boxInjectOnStartup.Size = new System.Drawing.Size(32, 30);
            this.boxInjectOnStartup.TabIndex = 24;
            this.boxInjectOnStartup.UseVisualStyleBackColor = false;
            this.boxInjectOnStartup.Click += new System.EventHandler(this.boxInjectOnStartup_Click);
            // 
            // boxCloseOnInject
            // 
            this.boxCloseOnInject.BackColor = System.Drawing.Color.Black;
            this.boxCloseOnInject.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.boxCloseOnInject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxCloseOnInject.ForeColor = System.Drawing.Color.White;
            this.boxCloseOnInject.Location = new System.Drawing.Point(292, 94);
            this.boxCloseOnInject.Name = "boxCloseOnInject";
            this.boxCloseOnInject.Size = new System.Drawing.Size(27, 28);
            this.boxCloseOnInject.TabIndex = 23;
            this.boxCloseOnInject.UseVisualStyleBackColor = false;
            this.boxCloseOnInject.Click += new System.EventHandler(this.boxCloseOnInject_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Black Ops One", 16F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(37, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 27);
            this.label6.TabIndex = 22;
            this.label6.Text = "Auto Inject";
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.Transparent;
            this.bSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Black Ops One", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.ForeColor = System.Drawing.Color.White;
            this.bSave.Image = ((System.Drawing.Image)(resources.GetObject("bSave.Image")));
            this.bSave.Location = new System.Drawing.Point(17, 291);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(369, 77);
            this.bSave.TabIndex = 18;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.closeProcess1);
            this.panel2.Controls.Add(this.minimizeProcess1);
            this.panel2.Controls.Add(this.bMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 56);
            this.panel2.TabIndex = 17;
            // 
            // closeProcess1
            // 
            this.closeProcess1.BackColor = System.Drawing.Color.White;
            this.closeProcess1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeProcess1.FlatAppearance.BorderSize = 0;
            this.closeProcess1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeProcess1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeProcess1.Font = new System.Drawing.Font("Black Ops One", 25.9F);
            this.closeProcess1.ForeColor = System.Drawing.Color.Red;
            this.closeProcess1.Location = new System.Drawing.Point(321, 5);
            this.closeProcess1.Name = "closeProcess1";
            this.closeProcess1.Size = new System.Drawing.Size(51, 49);
            this.closeProcess1.TabIndex = 7;
            this.closeProcess1.Text = "x";
            this.closeProcess1.UseVisualStyleBackColor = false;
            this.closeProcess1.Click += new System.EventHandler(this.closeProcess_Click);
            // 
            // minimizeProcess1
            // 
            this.minimizeProcess1.BackColor = System.Drawing.Color.White;
            this.minimizeProcess1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeProcess1.FlatAppearance.BorderSize = 0;
            this.minimizeProcess1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizeProcess1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeProcess1.Font = new System.Drawing.Font("Black Ops One", 20.25F);
            this.minimizeProcess1.ForeColor = System.Drawing.Color.Black;
            this.minimizeProcess1.Location = new System.Drawing.Point(264, 2);
            this.minimizeProcess1.Name = "minimizeProcess1";
            this.minimizeProcess1.Size = new System.Drawing.Size(51, 52);
            this.minimizeProcess1.TabIndex = 6;
            this.minimizeProcess1.Text = "_";
            this.minimizeProcess1.UseVisualStyleBackColor = false;
            this.minimizeProcess1.Click += new System.EventHandler(this.minimizeProcess_Click);
            // 
            // bMenu
            // 
            this.bMenu.BackColor = System.Drawing.Color.White;
            this.bMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMenu.FlatAppearance.BorderSize = 0;
            this.bMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMenu.Font = new System.Drawing.Font("Black Ops One", 15.25F);
            this.bMenu.ForeColor = System.Drawing.Color.Black;
            this.bMenu.Location = new System.Drawing.Point(23, 5);
            this.bMenu.Name = "bMenu";
            this.bMenu.Size = new System.Drawing.Size(109, 50);
            this.bMenu.TabIndex = 5;
            this.bMenu.Text = "Back";
            this.bMenu.UseVisualStyleBackColor = false;
            this.bMenu.Click += new System.EventHandler(this.bMenu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            // 
            // l_closeOnInject
            // 
            this.l_closeOnInject.AutoSize = true;
            this.l_closeOnInject.Font = new System.Drawing.Font("Black Ops One", 16F);
            this.l_closeOnInject.ForeColor = System.Drawing.Color.Black;
            this.l_closeOnInject.Location = new System.Drawing.Point(38, 92);
            this.l_closeOnInject.Name = "l_closeOnInject";
            this.l_closeOnInject.Size = new System.Drawing.Size(195, 27);
            this.l_closeOnInject.TabIndex = 10;
            this.l_closeOnInject.Text = "Close on inject:";
            // 
            // injector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "injector";
            this.Text = "Tiny Man Injector";
            this.Load += new System.EventHandler(this.injector_Load);
            this.tabControl.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcess)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.tabOptions.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.Button bOptions;
        private System.Windows.Forms.Button bSaveSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.ComboBox comboProcess;
        private System.Windows.Forms.PictureBox picProcess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDll;
        private System.Windows.Forms.Button bSearchDll;
        private System.Windows.Forms.Button bInject;
        private System.Windows.Forms.ComboBox comboId;
        private System.Windows.Forms.Label l_closeOnInject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeProcess;
        private System.Windows.Forms.Button minimizeProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeProcess1;
        private System.Windows.Forms.Button minimizeProcess1;
        private System.Windows.Forms.Button bMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bSave;
        private Label label6;
        private Button boxCloseOnInject;
        private Button boxInjectOnStartup;
    }
}


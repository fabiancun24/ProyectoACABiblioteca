using System.Drawing;
using System.Windows.Forms;

namespace ProyectoACAbiblioteca
{
    partial class frmLIBROS
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
            pnlTITULO = new Panel();
            lblTITULO = new Label();
            pnlBUSQUEDA = new Panel();
            btnCONSULTA = new Button();
            textBUSQUEDA = new TextBox();
            lblCONSULTA = new Label();
            pnlDATOS = new Panel();
            txtEXISTENCIA = new TextBox();
            txtREPORTE = new TextBox();
            txtDEVOLUCION = new TextBox();
            txtPRESTAMO = new TextBox();
            txtUSUARIO = new TextBox();
            cboEDITORIALES = new ComboBox();
            cboAUTORES = new ComboBox();
            cboLIBROS = new ComboBox();
            txtISBN = new TextBox();
            lblEXISTENCIA = new Label();
            lblREPORTE = new Label();
            lblDEVOLUCION = new Label();
            lblPRESTAMO = new Label();
            lblUSUARIO = new Label();
            lblEDITORIAL = new Label();
            lblAUTOR = new Label();
            lblLIBRO = new Label();
            lblISBN = new Label();
            pnlBOTONES = new Panel();
            btnCANCELAR = new Button();
            btnELIMINAR = new Button();
            btnEDITAR = new Button();
            btnGUARDAR = new Button();
            btnNUEVO = new Button();
            DGVLIBROS = new DataGridView();
            pnlTITULO.SuspendLayout();
            pnlBUSQUEDA.SuspendLayout();
            pnlDATOS.SuspendLayout();
            pnlBOTONES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVLIBROS).BeginInit();
            SuspendLayout();
            // 
            // pnlTITULO
            // 
            pnlTITULO.BackColor = Color.GreenYellow;
            pnlTITULO.Controls.Add(lblTITULO);
            pnlTITULO.Dock = DockStyle.Top;
            pnlTITULO.Location = new Point(0, 0);
            pnlTITULO.Name = "pnlTITULO";
            pnlTITULO.Size = new Size(1370, 79);
            pnlTITULO.TabIndex = 0;
            // 
            // lblTITULO
            // 
            lblTITULO.AutoSize = true;
            lblTITULO.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic);
            lblTITULO.ForeColor = Color.MidnightBlue;
            lblTITULO.Location = new Point(392, 9);
            lblTITULO.Name = "lblTITULO";
            lblTITULO.Size = new Size(575, 54);
            lblTITULO.TabIndex = 0;
            lblTITULO.Text = "GESTION DE CONSULTA";
            lblTITULO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBUSQUEDA
            // 
            pnlBUSQUEDA.BackColor = Color.White;
            pnlBUSQUEDA.Controls.Add(btnCONSULTA);
            pnlBUSQUEDA.Controls.Add(textBUSQUEDA);
            pnlBUSQUEDA.Controls.Add(lblCONSULTA);
            pnlBUSQUEDA.Dock = DockStyle.Top;
            pnlBUSQUEDA.Location = new Point(0, 79);
            pnlBUSQUEDA.Name = "pnlBUSQUEDA";
            pnlBUSQUEDA.Size = new Size(1370, 50);
            pnlBUSQUEDA.TabIndex = 1;
            // 
            // btnCONSULTA
            // 
            btnCONSULTA.Location = new Point(790, 6);
            btnCONSULTA.Name = "btnCONSULTA";
            btnCONSULTA.Size = new Size(75, 23);
            btnCONSULTA.TabIndex = 2;
            btnCONSULTA.Text = "CONSULTA";
            btnCONSULTA.UseVisualStyleBackColor = true;
            // 
            // textBUSQUEDA
            // 
            textBUSQUEDA.Location = new Point(565, 6);
            textBUSQUEDA.Name = "textBUSQUEDA";
            textBUSQUEDA.Size = new Size(175, 23);
            textBUSQUEDA.TabIndex = 1;
            // 
            // lblCONSULTA
            // 
            lblCONSULTA.AutoSize = true;
            lblCONSULTA.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblCONSULTA.Location = new Point(460, 10);
            lblCONSULTA.Name = "lblCONSULTA";
            lblCONSULTA.Size = new Size(51, 19);
            lblCONSULTA.TabIndex = 0;
            lblCONSULTA.Text = "ISBM";
            // 
            // pnlDATOS
            // 
            pnlDATOS.BackColor = SystemColors.ButtonHighlight;
            pnlDATOS.Controls.Add(txtEXISTENCIA);
            pnlDATOS.Controls.Add(txtREPORTE);
            pnlDATOS.Controls.Add(txtDEVOLUCION);
            pnlDATOS.Controls.Add(txtPRESTAMO);
            pnlDATOS.Controls.Add(txtUSUARIO);
            pnlDATOS.Controls.Add(cboEDITORIALES);
            pnlDATOS.Controls.Add(cboAUTORES);
            pnlDATOS.Controls.Add(cboLIBROS);
            pnlDATOS.Controls.Add(txtISBN);
            pnlDATOS.Controls.Add(lblEXISTENCIA);
            pnlDATOS.Controls.Add(lblREPORTE);
            pnlDATOS.Controls.Add(lblDEVOLUCION);
            pnlDATOS.Controls.Add(lblPRESTAMO);
            pnlDATOS.Controls.Add(lblUSUARIO);
            pnlDATOS.Controls.Add(lblEDITORIAL);
            pnlDATOS.Controls.Add(lblAUTOR);
            pnlDATOS.Controls.Add(lblLIBRO);
            pnlDATOS.Controls.Add(lblISBN);
            pnlDATOS.Dock = DockStyle.Top;
            pnlDATOS.Location = new Point(0, 129);
            pnlDATOS.Name = "pnlDATOS";
            pnlDATOS.Size = new Size(1370, 340);
            pnlDATOS.TabIndex = 2;
            // 
            // txtEXISTENCIA
            // 
            txtEXISTENCIA.Location = new Point(608, 289);
            txtEXISTENCIA.Name = "txtEXISTENCIA";
            txtEXISTENCIA.Size = new Size(175, 23);
            txtEXISTENCIA.TabIndex = 17;
            // 
            // txtREPORTE
            // 
            txtREPORTE.Location = new Point(608, 254);
            txtREPORTE.Name = "txtREPORTE";
            txtREPORTE.Size = new Size(175, 23);
            txtREPORTE.TabIndex = 16;
            // 
            // txtDEVOLUCION
            // 
            txtDEVOLUCION.Location = new Point(608, 219);
            txtDEVOLUCION.Name = "txtDEVOLUCION";
            txtDEVOLUCION.Size = new Size(175, 23);
            txtDEVOLUCION.TabIndex = 15;
            // 
            // txtPRESTAMO
            // 
            txtPRESTAMO.Location = new Point(608, 184);
            txtPRESTAMO.Name = "txtPRESTAMO";
            txtPRESTAMO.Size = new Size(175, 23);
            txtPRESTAMO.TabIndex = 14;
            // 
            // txtUSUARIO
            // 
            txtUSUARIO.Location = new Point(608, 149);
            txtUSUARIO.Name = "txtUSUARIO";
            txtUSUARIO.Size = new Size(175, 23);
            txtUSUARIO.TabIndex = 13;
            // 
            // cboEDITORIALES
            // 
            cboEDITORIALES.FormattingEnabled = true;
            cboEDITORIALES.Location = new Point(608, 114);
            cboEDITORIALES.Name = "cboEDITORIALES";
            cboEDITORIALES.Size = new Size(175, 23);
            cboEDITORIALES.TabIndex = 12;
            // 
            // cboAUTORES
            // 
            cboAUTORES.FormattingEnabled = true;
            cboAUTORES.Location = new Point(608, 79);
            cboAUTORES.Name = "cboAUTORES";
            cboAUTORES.Size = new Size(175, 23);
            cboAUTORES.TabIndex = 11;
            // 
            // cboLIBROS
            // 
            cboLIBROS.FormattingEnabled = true;
            cboLIBROS.Location = new Point(608, 44);
            cboLIBROS.Name = "cboLIBROS";
            cboLIBROS.Size = new Size(175, 23);
            cboLIBROS.TabIndex = 10;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(608, 9);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(175, 23);
            txtISBN.TabIndex = 9;
            // 
            // lblEXISTENCIA
            // 
            lblEXISTENCIA.AutoSize = true;
            lblEXISTENCIA.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblEXISTENCIA.Location = new Point(463, 291);
            lblEXISTENCIA.Name = "lblEXISTENCIA";
            lblEXISTENCIA.Size = new Size(132, 19);
            lblEXISTENCIA.TabIndex = 8;
            lblEXISTENCIA.Text = "ENEXISTENCIA:";
            // 
            // lblREPORTE
            // 
            lblREPORTE.AutoSize = true;
            lblREPORTE.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblREPORTE.Location = new Point(463, 256);
            lblREPORTE.Name = "lblREPORTE";
            lblREPORTE.Size = new Size(97, 19);
            lblREPORTE.TabIndex = 7;
            lblREPORTE.Text = "REPORTES:";
            // 
            // lblDEVOLUCION
            // 
            lblDEVOLUCION.AutoSize = true;
            lblDEVOLUCION.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblDEVOLUCION.Location = new Point(463, 221);
            lblDEVOLUCION.Name = "lblDEVOLUCION";
            lblDEVOLUCION.Size = new Size(140, 19);
            lblDEVOLUCION.TabIndex = 6;
            lblDEVOLUCION.Text = "DEVOLUCIONES:";
            // 
            // lblPRESTAMO
            // 
            lblPRESTAMO.AutoSize = true;
            lblPRESTAMO.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblPRESTAMO.Location = new Point(463, 186);
            lblPRESTAMO.Name = "lblPRESTAMO";
            lblPRESTAMO.Size = new Size(111, 19);
            lblPRESTAMO.TabIndex = 5;
            lblPRESTAMO.Text = "PRESTAMOS:";
            // 
            // lblUSUARIO
            // 
            lblUSUARIO.AutoSize = true;
            lblUSUARIO.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblUSUARIO.Location = new Point(463, 151);
            lblUSUARIO.Name = "lblUSUARIO";
            lblUSUARIO.Size = new Size(104, 19);
            lblUSUARIO.TabIndex = 4;
            lblUSUARIO.Text = "USUSARIOS:";
            // 
            // lblEDITORIAL
            // 
            lblEDITORIAL.AutoSize = true;
            lblEDITORIAL.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblEDITORIAL.Location = new Point(463, 116);
            lblEDITORIAL.Name = "lblEDITORIAL";
            lblEDITORIAL.Size = new Size(122, 19);
            lblEDITORIAL.TabIndex = 3;
            lblEDITORIAL.Text = "EDITORIALES:";
            // 
            // lblAUTOR
            // 
            lblAUTOR.AutoSize = true;
            lblAUTOR.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblAUTOR.Location = new Point(463, 81);
            lblAUTOR.Name = "lblAUTOR";
            lblAUTOR.Size = new Size(89, 19);
            lblAUTOR.TabIndex = 2;
            lblAUTOR.Text = "AUTORES:";
            // 
            // lblLIBRO
            // 
            lblLIBRO.AutoSize = true;
            lblLIBRO.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblLIBRO.Location = new Point(463, 46);
            lblLIBRO.Name = "lblLIBRO";
            lblLIBRO.Size = new Size(74, 19);
            lblLIBRO.TabIndex = 1;
            lblLIBRO.Text = "LIBROS:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblISBN.Location = new Point(463, 11);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(56, 19);
            lblISBN.TabIndex = 0;
            lblISBN.Text = "ISBM:";
            // 
            // pnlBOTONES
            // 
            pnlBOTONES.BackColor = Color.Beige;
            pnlBOTONES.Controls.Add(btnCANCELAR);
            pnlBOTONES.Controls.Add(btnELIMINAR);
            pnlBOTONES.Controls.Add(btnEDITAR);
            pnlBOTONES.Controls.Add(btnGUARDAR);
            pnlBOTONES.Controls.Add(btnNUEVO);
            pnlBOTONES.Location = new Point(315, 475);
            pnlBOTONES.Name = "pnlBOTONES";
            pnlBOTONES.Size = new Size(700, 50);
            pnlBOTONES.TabIndex = 3;
            // 
            // btnCANCELAR
            // 
            btnCANCELAR.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCANCELAR.Location = new Point(584, 12);
            btnCANCELAR.Name = "btnCANCELAR";
            btnCANCELAR.Size = new Size(90, 28);
            btnCANCELAR.TabIndex = 4;
            btnCANCELAR.Text = "CANCELAR";
            btnCANCELAR.UseVisualStyleBackColor = true;
            // 
            // btnELIMINAR
            // 
            btnELIMINAR.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnELIMINAR.Location = new Point(450, 12);
            btnELIMINAR.Name = "btnELIMINAR";
            btnELIMINAR.Size = new Size(90, 28);
            btnELIMINAR.TabIndex = 3;
            btnELIMINAR.Text = "ELIMINAR";
            btnELIMINAR.UseVisualStyleBackColor = true;
            // 
            // btnEDITAR
            // 
            btnEDITAR.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEDITAR.Location = new Point(316, 12);
            btnEDITAR.Name = "btnEDITAR";
            btnEDITAR.Size = new Size(90, 28);
            btnEDITAR.TabIndex = 2;
            btnEDITAR.Text = "EDITAR";
            btnEDITAR.UseVisualStyleBackColor = true;
            // 
            // btnGUARDAR
            // 
            btnGUARDAR.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGUARDAR.Location = new Point(180, 12);
            btnGUARDAR.Name = "btnGUARDAR";
            btnGUARDAR.Size = new Size(90, 28);
            btnGUARDAR.TabIndex = 1;
            btnGUARDAR.Text = "GUARDAR";
            btnGUARDAR.UseVisualStyleBackColor = true;
            // 
            // btnNUEVO
            // 
            btnNUEVO.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNUEVO.Location = new Point(34, 12);
            btnNUEVO.Name = "btnNUEVO";
            btnNUEVO.Size = new Size(90, 28);
            btnNUEVO.TabIndex = 0;
            btnNUEVO.Text = "NUEVO";
            btnNUEVO.UseVisualStyleBackColor = true;
            // 
            // DGVLIBROS
            // 
            DGVLIBROS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVLIBROS.Location = new Point(256, 531);
            DGVLIBROS.Name = "DGVLIBROS";
            DGVLIBROS.Size = new Size(800, 600);
            DGVLIBROS.TabIndex = 4;
            DGVLIBROS.VirtualMode = true;
            // 
            // frmLIBROS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 721);
            Controls.Add(DGVLIBROS);
            Controls.Add(pnlBOTONES);
            Controls.Add(pnlDATOS);
            Controls.Add(pnlBUSQUEDA);
            Controls.Add(pnlTITULO);
            Name = "frmLIBROS";
            Text = "frmLIBROS";
            pnlTITULO.ResumeLayout(false);
            pnlTITULO.PerformLayout();
            pnlBUSQUEDA.ResumeLayout(false);
            pnlBUSQUEDA.PerformLayout();
            pnlDATOS.ResumeLayout(false);
            pnlDATOS.PerformLayout();
            pnlBOTONES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVLIBROS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTITULO;
        private Panel pnlBUSQUEDA;
        private Label lblTITULO;
        private Button btnCONSULTA;
        private TextBox textBUSQUEDA;
        private Label lblCONSULTA;
        private Panel pnlDATOS;
        private Label lblISBN;
        private Label lblLIBRO;
        private Label lblAUTOR;
        private Label lblEDITORIAL;
        private Label lblUSUARIO;
        private Label lblPRESTAMO;
        private Label lblDEVOLUCION;
        private Label lblREPORTE;
        private Label lblEXISTENCIA;
        private TextBox txtISBN;
        private ComboBox cboLIBROS;
        private ComboBox cboAUTORES;
        private ComboBox cboEDITORIALES;
        private TextBox txtUSUARIO;
        private TextBox txtPRESTAMO;
        private TextBox txtDEVOLUCION;
        private TextBox txtREPORTE;
        private TextBox txtEXISTENCIA;
        private Panel pnlBOTONES;
        private Button btnNUEVO;
        private Button btnGUARDAR;
        private Button btnEDITAR;
        private Button btnELIMINAR;
        private Button btnCANCELAR;
        private DataGridView DGVLIBROS;
    }
}
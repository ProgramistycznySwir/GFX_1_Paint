namespace GFX_1_Paint
{
    partial class Main
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.saveImage = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(14, 14);
            this.canvas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1236, 577);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // btnLine
            // 
            this.btnLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLine.Location = new System.Drawing.Point(109, 597);
            this.btnLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(88, 27);
            this.btnLine.TabIndex = 1;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEllipse.Location = new System.Drawing.Point(300, 597);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(88, 27);
            this.btnEllipse.TabIndex = 2;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRect
            // 
            this.btnRect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRect.Location = new System.Drawing.Point(396, 597);
            this.btnRect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(88, 27);
            this.btnRect.TabIndex = 3;
            this.btnRect.Text = "Rectangle";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColorPicker.Location = new System.Drawing.Point(16, 642);
            this.btnColorPicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(120, 27);
            this.btnColorPicker.TabIndex = 4;
            this.btnColorPicker.Text = "Color";
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.colorPanel.Location = new System.Drawing.Point(160, 642);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(29, 29);
            this.colorPanel.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1133, 597);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 27);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear image";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(207, 648);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Size";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbSize
            // 
            this.tbSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSize.Location = new System.Drawing.Point(242, 645);
            this.tbSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(25, 23);
            this.tbSize.TabIndex = 9;
            this.tbSize.TextChanged += new System.EventHandler(this.tbSize_TextChanged);
            // 
            // saveImage
            // 
            this.saveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveImage.BackColor = System.Drawing.Color.White;
            this.saveImage.Location = new System.Drawing.Point(1008, 597);
            this.saveImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(117, 27);
            this.saveImage.TabIndex = 10;
            this.saveImage.Text = "Save image";
            this.saveImage.UseVisualStyleBackColor = false;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTriangle.Location = new System.Drawing.Point(205, 597);
            this.btnTriangle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(88, 27);
            this.btnTriangle.TabIndex = 11;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPencil.Location = new System.Drawing.Point(13, 597);
            this.btnPencil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(88, 27);
            this.btnPencil.TabIndex = 12;
            this.btnPencil.Text = "Pencil";
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnPencil);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.btnColorPicker);
            this.Controls.Add(this.btnRect);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.canvas);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColorPicker;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSize;
        private Button saveImage;
        private Button btnTriangle;
        private Button btnPencil;
    }
}
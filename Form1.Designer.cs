namespace GraphicsPainter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbGraphic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGraphicType = new System.Windows.Forms.ComboBox();
            this.btnDrawGraphic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGraphic
            // 
            this.pbGraphic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGraphic.Location = new System.Drawing.Point(12, 12);
            this.pbGraphic.Name = "pbGraphic";
            this.pbGraphic.Size = new System.Drawing.Size(555, 572);
            this.pbGraphic.TabIndex = 0;
            this.pbGraphic.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбирите функцию:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbGraphicType
            // 
            this.cbGraphicType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGraphicType.FormattingEnabled = true;
            this.cbGraphicType.Location = new System.Drawing.Point(212, 602);
            this.cbGraphicType.Name = "cbGraphicType";
            this.cbGraphicType.Size = new System.Drawing.Size(195, 28);
            this.cbGraphicType.TabIndex = 2;
            // 
            // btnDrawGraphic
            // 
            this.btnDrawGraphic.Location = new System.Drawing.Point(445, 602);
            this.btnDrawGraphic.Name = "btnDrawGraphic";
            this.btnDrawGraphic.Size = new System.Drawing.Size(122, 28);
            this.btnDrawGraphic.TabIndex = 3;
            this.btnDrawGraphic.Text = "График";
            this.btnDrawGraphic.UseVisualStyleBackColor = true;
            this.btnDrawGraphic.Click += new System.EventHandler(this.btnDrawGraphic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 641);
            this.Controls.Add(this.btnDrawGraphic);
            this.Controls.Add(this.cbGraphicType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGraphic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Построитель графиков";
            ((System.ComponentModel.ISupportInitialize)(this.pbGraphic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGraphic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGraphicType;
        private System.Windows.Forms.Button btnDrawGraphic;
    }
}


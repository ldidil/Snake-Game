using System;

namespace SnakeGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.endText = new System.Windows.Forms.Label();
            this.ScoreText = new System.Windows.Forms.Label();
            this.scorePoint = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.boardCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boardCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // endText
            // 
            this.endText.AutoSize = true;
            this.endText.BackColor = System.Drawing.Color.Transparent;
            this.endText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endText.Location = new System.Drawing.Point(234, 238);
            this.endText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endText.Name = "endText";
            this.endText.Size = new System.Drawing.Size(143, 36);
            this.endText.TabIndex = 1;
            this.endText.Text = "endGame";
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreText.Location = new System.Drawing.Point(628, 41);
            this.ScoreText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(101, 36);
            this.ScoreText.TabIndex = 2;
            this.ScoreText.Text = "Score:";
            // 
            // scorePoint
            // 
            this.scorePoint.AutoSize = true;
            this.scorePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scorePoint.Location = new System.Drawing.Point(826, 41);
            this.scorePoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scorePoint.Name = "scorePoint";
            this.scorePoint.Size = new System.Drawing.Size(172, 36);
            this.scorePoint.TabIndex = 3;
            this.scorePoint.Text = "scorePoints";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            // 
            // boardCanvas
            // 
            this.boardCanvas.BackColor = System.Drawing.Color.Transparent;
            this.boardCanvas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boardCanvas.BackgroundImage")));
            this.boardCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boardCanvas.InitialImage = ((System.Drawing.Image)(resources.GetObject("boardCanvas.InitialImage")));
            this.boardCanvas.Location = new System.Drawing.Point(15, 16);
            this.boardCanvas.Margin = new System.Windows.Forms.Padding(0);
            this.boardCanvas.Name = "boardCanvas";
            this.boardCanvas.Size = new System.Drawing.Size(616, 667);
            this.boardCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boardCanvas.TabIndex = 0;
            this.boardCanvas.TabStop = false;
            this.boardCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGraphic);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 687);
            this.Controls.Add(this.scorePoint);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.endText);
            this.Controls.Add(this.boardCanvas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "SnakeGame by Dominika L";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.boardCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox boardCanvas;
        private System.Windows.Forms.Label endText;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Label scorePoint;
        private System.Windows.Forms.Timer gameTimer;
    }
}


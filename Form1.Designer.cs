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
            this.topScoreTitleTxt = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.topScoreListTxT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boardCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // endText
            // 
            this.endText.AutoSize = true;
            this.endText.BackColor = System.Drawing.Color.Transparent;
            this.endText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endText.Location = new System.Drawing.Point(308, 250);
            this.endText.Name = "endText";
            this.endText.Size = new System.Drawing.Size(188, 44);
            this.endText.TabIndex = 1;
            this.endText.Text = "endGame";
            this.endText.Visible = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreText.Location = new System.Drawing.Point(901, 50);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(130, 44);
            this.ScoreText.TabIndex = 2;
            this.ScoreText.Text = "Score:";
            // 
            // scorePoint
            // 
            this.scorePoint.AutoSize = true;
            this.scorePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scorePoint.Location = new System.Drawing.Point(1101, 50);
            this.scorePoint.Name = "scorePoint";
            this.scorePoint.Size = new System.Drawing.Size(219, 44);
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
            this.boardCanvas.Location = new System.Drawing.Point(20, 20);
            this.boardCanvas.Margin = new System.Windows.Forms.Padding(0);
            this.boardCanvas.Name = "boardCanvas";
            this.boardCanvas.Size = new System.Drawing.Size(820, 820);
            this.boardCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boardCanvas.TabIndex = 0;
            this.boardCanvas.TabStop = false;
            this.boardCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGraphic);
            // 
            // topScoreTitleTxt
            // 
            this.topScoreTitleTxt.AutoSize = true;
            this.topScoreTitleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topScoreTitleTxt.Location = new System.Drawing.Point(973, 192);
            this.topScoreTitleTxt.Name = "topScoreTitleTxt";
            this.topScoreTitleTxt.Size = new System.Drawing.Size(255, 44);
            this.topScoreTitleTxt.TabIndex = 4;
            this.topScoreTitleTxt.Text = "Top 5 Scores:";
            // 
            // playAgainButton
            // 
            this.playAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playAgainButton.Location = new System.Drawing.Point(168, 348);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(202, 93);
            this.playAgainButton.TabIndex = 6;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Visible = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.Location = new System.Drawing.Point(461, 348);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(202, 93);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // topScoreListTxT
            // 
            this.topScoreListTxT.AutoSize = true;
            this.topScoreListTxT.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topScoreListTxT.Location = new System.Drawing.Point(1001, 266);
            this.topScoreListTxT.Name = "topScoreListTxT";
            this.topScoreListTxT.Size = new System.Drawing.Size(195, 44);
            this.topScoreListTxT.TabIndex = 8;
            this.topScoreListTxT.Text = "TopScore:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 846);
            this.ControlBox = false;
            this.Controls.Add(this.topScoreListTxT);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.topScoreTitleTxt);
            this.Controls.Add(this.scorePoint);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.endText);
            this.Controls.Add(this.boardCanvas);
            this.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Snake Game";
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
        private System.Windows.Forms.Label topScoreTitleTxt;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label topScoreListTxT;
    }
}


namespace ID_Card_Inventory
{
    partial class PhotopeaForm
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
            PhotopeaWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)PhotopeaWebView).BeginInit();
            SuspendLayout();
            // 
            // PhotopeaWebView
            // 
            PhotopeaWebView.AllowExternalDrop = true;
            PhotopeaWebView.CreationProperties = null;
            PhotopeaWebView.DefaultBackgroundColor = Color.White;
            PhotopeaWebView.Location = new Point(34, 25);
            PhotopeaWebView.Name = "PhotopeaWebView";
            PhotopeaWebView.Size = new Size(749, 402);
            PhotopeaWebView.TabIndex = 0;
            PhotopeaWebView.ZoomFactor = 1D;
            // 
            // PhotopeaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PhotopeaWebView);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "PhotopeaForm";
            Text = "PhotopeaForm";
            ((System.ComponentModel.ISupportInitialize)PhotopeaWebView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 PhotopeaWebView;
    }
}
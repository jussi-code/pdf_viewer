﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Exit_button = New System.Windows.Forms.Button()
        Me.Save_img = New System.Windows.Forms.Button()
        Me.Print_button = New System.Windows.Forms.Button()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Load_Old_Rev = New System.Windows.Forms.Button()
        Me.BW_button = New System.Windows.Forms.Button()
        Me.Load_New_Rev = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Exit_button)
        Me.FlowLayoutPanel2.Controls.Add(Me.Save_img)
        Me.FlowLayoutPanel2.Controls.Add(Me.Print_button)
        Me.FlowLayoutPanel2.Controls.Add(Me.Clear_Button)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 506)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(593, 33)
        Me.FlowLayoutPanel2.TabIndex = 5
        '
        'Exit_button
        '
        Me.Exit_button.Location = New System.Drawing.Point(3, 3)
        Me.Exit_button.Name = "Exit_button"
        Me.Exit_button.Size = New System.Drawing.Size(75, 23)
        Me.Exit_button.TabIndex = 0
        Me.Exit_button.Text = "Exit"
        Me.Exit_button.UseVisualStyleBackColor = True
        '
        'Save_img
        '
        Me.Save_img.Location = New System.Drawing.Point(84, 3)
        Me.Save_img.Name = "Save_img"
        Me.Save_img.Size = New System.Drawing.Size(75, 23)
        Me.Save_img.TabIndex = 1
        Me.Save_img.Text = "Save"
        Me.Save_img.UseVisualStyleBackColor = True
        '
        'Print_button
        '
        Me.Print_button.Location = New System.Drawing.Point(165, 3)
        Me.Print_button.Name = "Print_button"
        Me.Print_button.Size = New System.Drawing.Size(75, 23)
        Me.Print_button.TabIndex = 2
        Me.Print_button.Text = "Print"
        Me.Print_button.UseVisualStyleBackColor = True
        '
        'Clear_Button
        '
        Me.Clear_Button.Location = New System.Drawing.Point(246, 3)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(75, 23)
        Me.Clear_Button.TabIndex = 2
        Me.Clear_Button.Text = "Clear"
        Me.Clear_Button.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Load_Old_Rev)
        Me.FlowLayoutPanel1.Controls.Add(Me.BW_button)
        Me.FlowLayoutPanel1.Controls.Add(Me.Load_New_Rev)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 453)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(593, 33)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'Load_Old_Rev
        '
        Me.Load_Old_Rev.Location = New System.Drawing.Point(3, 3)
        Me.Load_Old_Rev.Name = "Load_Old_Rev"
        Me.Load_Old_Rev.Size = New System.Drawing.Size(92, 23)
        Me.Load_Old_Rev.TabIndex = 4
        Me.Load_Old_Rev.Text = "Load OLD rev"
        Me.Load_Old_Rev.UseVisualStyleBackColor = True
        '
        'BW_button
        '
        Me.BW_button.Location = New System.Drawing.Point(101, 3)
        Me.BW_button.Name = "BW_button"
        Me.BW_button.Size = New System.Drawing.Size(92, 23)
        Me.BW_button.TabIndex = 5
        Me.BW_button.Text = "Black White"
        Me.BW_button.UseVisualStyleBackColor = True
        '
        'Load_New_Rev
        '
        Me.Load_New_Rev.Location = New System.Drawing.Point(199, 3)
        Me.Load_New_Rev.Name = "Load_New_Rev"
        Me.Load_New_Rev.Size = New System.Drawing.Size(92, 23)
        Me.Load_New_Rev.TabIndex = 3
        Me.Load_New_Rev.Text = "Load NEW rev"
        Me.Load_New_Rev.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.32715!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.67285!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1019, 595)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1013, 444)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(59, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(806, 366)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1019, 595)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "PDF viewer"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Exit_button As Button
    Friend WithEvents Save_img As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Clear_Button As Button
    Friend WithEvents Load_New_Rev As Button
    Friend WithEvents Load_Old_Rev As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BW_button As Button
    Friend WithEvents Print_button As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
Option Explicit On
Imports System.Runtime.InteropServices

'--- Simple VB.Net wrapper for Ghostscript gsdll32.dll

'    (Tested using Visual Studio 2010 and Ghostscript 9.06)

Module GhostscriptDllLib

    Private Declare Function gsapi_new_instance Lib "gsdll32.dll" _
      (ByRef instance As IntPtr,
      ByVal caller_handle As IntPtr) As Integer

    Private Declare Function gsapi_set_stdio Lib "gsdll32.dll" _
      (ByVal instance As IntPtr,
      ByVal gsdll_stdin As StdIOCallBack,
      ByVal gsdll_stdout As StdIOCallBack,
      ByVal gsdll_stderr As StdIOCallBack) As Integer

    Private Declare Function gsapi_init_with_args Lib "gsdll32.dll" _
      (ByVal instance As IntPtr,
      ByVal argc As Integer,
      <MarshalAs(UnmanagedType.LPArray, ArraySubType:=UnmanagedType.LPStr)>
      ByVal argv() As String) As Integer

    Private Declare Function gsapi_exit Lib "gsdll32.dll" _
      (ByVal instance As IntPtr) As Integer

    Private Declare Sub gsapi_delete_instance Lib "gsdll32.dll" _
      (ByVal instance As IntPtr)

    '--- Run Ghostscript with specified arguments

    Public Function RunGS(ByVal ParamArray Args() As String) As Boolean

        Dim InstanceHndl As IntPtr
        Dim NumArgs As Integer
        Dim StdErrCallback As StdIOCallBack
        Dim StdInCallback As StdIOCallBack
        Dim StdOutCallback As StdIOCallBack

        NumArgs = Args.Count

        StdInCallback = AddressOf InOutErrCallBack
        StdOutCallback = AddressOf InOutErrCallBack
        StdErrCallback = AddressOf InOutErrCallBack

        '--- Shift arguments to begin at index 1 (Ghostscript requirement)

        ReDim Preserve Args(NumArgs)
        System.Array.Copy(Args, 0, Args, 1, NumArgs)

        '--- Start a new Ghostscript instance

        If gsapi_new_instance(InstanceHndl, 0) <> 0 Then
            Return False
            Exit Function
        End If

        '--- Set up dummy callbacks

        gsapi_set_stdio(InstanceHndl, StdInCallback, StdOutCallback, StdErrCallback)

        '--- Run Ghostscript using specified arguments

        gsapi_init_with_args(InstanceHndl, NumArgs + 1, Args)

        '--- Exit Ghostscript

        gsapi_exit(InstanceHndl)

        '--- Delete instance

        gsapi_delete_instance(InstanceHndl)

        Return True

    End Function

    '--- Delegate function for callbacks

    Private Delegate Function StdIOCallBack(ByVal handle As IntPtr,
      ByVal Strz As IntPtr, ByVal Bytes As Integer) As Integer

    '--- Dummy callback for standard input, standard output, and errors

    Private Function InOutErrCallBack(ByVal handle As IntPtr,
      ByVal Strz As IntPtr, ByVal Bytes As Integer) As Integer

        Return 0

    End Function

End Module

Module load_image
    Public Function call_image(ByVal name As String) As Image
        Dim picture As Image
        Dim fs As System.IO.FileStream
        ' Specify a valid picture file path on your computer.
        fs = New System.IO.FileStream(name, IO.FileMode.Open, IO.FileAccess.Read)
        picture = System.Drawing.Image.FromStream(fs)
        fs.Close()

        Return picture
    End Function

End Module


''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


Public Class Form1



    Public org_pdf_path As String
    Public overlay_pdf_path As String
    Public org_png_path As String
    Public overlay_png_path As String
    Public img As Bitmap

    Private Sub InitializeMyScrollBar()
        ' Create and initialize an HScrollBar.
        Dim hScrollBar1 As New HScrollBar()

        ' Dock the scroll bar to the bottom of the form.
        hScrollBar1.Dock = DockStyle.Bottom

        ' Add the scroll bar to the form.
        Controls.Add(hScrollBar1)
    End Sub 'InitializeMyScrollBar


    Private Sub Background_Button_Click(sender As Object, e As EventArgs)
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Load_New_Rev_Click(sender As Object, e As EventArgs) Handles Load_New_Rev.Click

        If img Is Nothing Then

        Else
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                overlay_pdf_path = OpenFileDialog1.FileName
                Dim overlay_pdf_name() As String = overlay_pdf_path.Split(".")

                overlay_png_path = overlay_pdf_name(0) & ".png"


                Dim Args() As String = {"-q", "-dNOPAUSE", "-dBATCH", "-dSAFER",
          "-sDEVICE=png16m", "-r600", "-dDownScaleFactor=6", "-dTextAlphaBits=4",
          "-dGraphicsAlphaBits=4", "-sPAPERSIZE=letter",
          "-sOutputFile=" & overlay_png_path, overlay_pdf_path}

                RunGS(Args)


                Dim temp_img As Image = call_image(overlay_png_path)
                Dim overlay_img As New Bitmap(temp_img)


                Dim x As Integer
                Dim y As Integer
                Dim red As Byte
                Dim green As Byte
                Dim blue As Byte

                For x = 0 To img.Width - 1
                    For y = 0 To img.Height - 1
                        red = overlay_img.GetPixel(x, y).R
                        green = overlay_img.GetPixel(x, y).G
                        blue = overlay_img.GetPixel(x, y).B


                        If blue < 200 And green < 200 And red < 200 Then
                            overlay_img.SetPixel(x, y, Color.FromArgb(240, 0, 0))
                        End If
                    Next
                Next

                'overlay_img.MakeTransparent(Color.White)
                img.MakeTransparent(Color.White)

                Dim comb_img As Graphics = Graphics.FromImage(overlay_img)

                comb_img.DrawImage(img, 0, 0, img.Width, img.Height)

                PictureBox1.Image = overlay_img


            End If
        End If








    End Sub

    Private Sub Load_Old_Rev_Click(sender As Object, e As EventArgs) Handles Load_Old_Rev.Click

        PictureBox1.Image = Nothing
        PictureBox1.Invalidate()

        If Me.img Is Nothing Then

        Else
            img.Dispose()

        End If


        org_pdf_path = ""
        overlay_pdf_path = ""
        org_png_path = ""
        overlay_png_path = ""


        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'PictureBox1.Load(OpenFileDialog1.FileName)
            org_pdf_path = OpenFileDialog1.FileName

            Dim org_pdf_name() As String = org_pdf_path.Split(".")



            org_png_path = org_pdf_name(0) & ".png"

            If My.Computer.FileSystem.FileExists(org_png_path) Then
                My.Computer.FileSystem.DeleteFile(org_png_path)
            End If


            Dim Args() As String = {"-q", "-dNOPAUSE", "-dBATCH", "-dSAFER",
  "-sDEVICE=png16m", "-r600", "-dDownScaleFactor=6", "-dTextAlphaBits=4",
  "-dGraphicsAlphaBits=4", "-sPAPERSIZE=letter",
  "-sOutputFile=" & org_png_path, org_pdf_path}

            RunGS(Args)


            'PictureBox1.Load(org_png_path)

            PictureBox1.Image = call_image(org_png_path)
            img = PictureBox1.Image
            'img.MakeTransparent(Color.White)



        End If



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 
        PictureBox1.Image = Nothing
        PictureBox1.Load(org_png_path)
    End Sub

    Private Sub Save_img_Click(sender As Object, e As EventArgs) Handles Save_img.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png"
        saveFileDialog1.Title = "Save an Image File"
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName <> "" Then
            ' Saves the Image via a FileStream created by the OpenFile method.
            Dim fs As System.IO.FileStream = CType _
               (saveFileDialog1.OpenFile(), System.IO.FileStream)
            ' Saves the Image in the appropriate ImageFormat based upon the
            ' file type selected in the dialog box.
            ' NOTE that the FilterIndex property is one-based.
            Select Case saveFileDialog1.FilterIndex
                Case 1
                    Me.PictureBox1.Image.Save(fs,
                       System.Drawing.Imaging.ImageFormat.Jpeg)

                Case 2
                    Me.PictureBox1.Image.Save(fs,
                       System.Drawing.Imaging.ImageFormat.Bmp)

                Case 3
                    Me.PictureBox1.Image.Save(fs,
                       System.Drawing.Imaging.ImageFormat.Png)
            End Select

            fs.Close()
        End If

    End Sub

    Private Sub Exit_button_Click(sender As Object, e As EventArgs) Handles Exit_button.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HScrollBar1.Minimum = 20
        HScrollBar1.Maximum = 200
        Label1.Text = "(" & VScrollBar1.Value & "," & HScrollBar1.Value & ")"
        Label1.Location = New Point(HScrollBar1.Value, VScrollBar1.Value)

    End Sub


    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        Label1.Text = "(" & VScrollBar1.Value & "," & HScrollBar1.Value & ")"
        Label1.Location = New Point(HScrollBar1.Value, VScrollBar1.Value)
    End Sub

End Class

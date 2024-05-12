Public Class Form1
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		MsgBox("Hello! World", vbYesNo + vbInformation, "测试信息")
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Static Progress As Integer
		Progress = 0
		ProgressBar1.MarqueeAnimationSpeed = 2000
		ProgressBar1.Value = Progress + 100
		If ProgressBar1.Value = 100 Then
			Label4.Text = 100
			Timer1.Start()
		End If
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		RadioButton1.Checked = False 'reset
		RadioButton2.Checked = False
		CheckBox1.Checked = False
		CheckBox2.Checked = False
		CheckBox3.Checked = False
		TextBox2.Text = ""
		TextBox3.Text = ""
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		TextBox1.Text = "" 'reset
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		Label4.Text = "0"
		ProgressBar1.MarqueeAnimationSpeed = 100
		ProgressBar1.Value = 0
		Timer1.Enabled = False
	End Sub

	Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
		MsgBox("BY Yeditie_
Made By C#  2024.5.2
ZCY11233833@163.com", vbYes + vbQuestion, "关于此程序")
	End Sub

	Private Sub 新项目ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新项目ToolStripMenuItem.Click
		Do
			MsgBox("对的，这是一个简单的病毒吗？", "666")
		Loop
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class

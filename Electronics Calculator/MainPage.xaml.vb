' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

	Private Sub Calculate()
		Dim Resistor1 As Double, Resistor2 As Double, Capacitor As Double
		Dim time1 As Double, time2 As Double, Time As Double, frequency As Double, DutyCycle As Double
		Dim stime1 As String, stime2 As String, sTime As String, sfrequency As String
		Dim temp As Integer

		temp = (cbxR1.SelectedIndex - 3) * 3
		Resistor1 = textbox1.Text * (10 ^ temp)

		temp = (cbxR2.SelectedIndex - 3) * 3
		Resistor2 = textbox2.Text * (10 ^ temp)

		temp = (cbxC.SelectedIndex - 3) * 3
		Capacitor = textbox3.Text * (10 ^ temp)

		time1 = 0.693 * (Resistor1 + Resistor2) * Capacitor
		time2 = 0.693 * Resistor2 * Capacitor
		Time = time1 + time2
		frequency = 1 / Time
		DutyCycle = 1 - (Resistor2 / (Resistor1 + 2 * Resistor2))

		sfrequency = "f = "
		If frequency >= 1000000000.0 Then
			sfrequency = sfrequency & (frequency * 0.000000001).ToString("#,##0.000") & "GHz"
		ElseIf frequency < 1000000000.0 And frequency >= 1000000.0 Then
			sfrequency = sfrequency & (frequency * 0.000001).ToString("#,##0.000") & "MHz"
		ElseIf frequency < 1000000.0 And frequency >= 1000.0 Then
			sfrequency = sfrequency & (frequency * 0.001).ToString("#,##0.000") & "kHz"
		ElseIf frequency < 1000.0 And frequency >= 1.0 Then
			sfrequency = sfrequency & frequency.ToString("#,##0.000") & "Hz"
		ElseIf frequency < 1.0 And frequency >= 0.001 Then
			sfrequency = sfrequency & (frequency * 1000.0).ToString("#,##0.000") & "mHz"
		ElseIf frequency < 0.001 And frequency >= 0.000001 Then
			sfrequency = sfrequency & (frequency * 1000000.0).ToString("#,##0.000") & "µHz"
		ElseIf frequency < 0.000001 Then
			sfrequency = sfrequency & (frequency * 1000000000.0).ToString("#,##0.000") & "ns"
		End If
		tbkFrequency.Text = sfrequency

		stime1 = "High Time = "
		If time1 >= 1000000000.0 Then
			stime1 = stime1 & (time1 * 0.000000001).ToString("#,##0.000") & "Gs"
		ElseIf time1 < 1000000000.0 And time1 >= 1000000.0 Then
			stime1 = stime1 & (time1 * 0.000001).ToString("#,##0.000") & "Ms"
		ElseIf time1 < 1000000.0 And time1 >= 1000.0 Then
			stime1 = stime1 & (time1 * 0.001).ToString("#,##0.000") & "ks"
		ElseIf time1 < 1000.0 And time1 >= 1.0 Then
			stime1 = stime1 & time1.ToString("#,##0.000") & "s"
		ElseIf time1 < 1.0 And time1 >= 0.001 Then
			stime1 = stime1 & (time1 * 1000.0).ToString("#,##0.000") & "ms"
		ElseIf time1 < 0.001 And Time >= 0.000001 Then
			stime1 = stime1 & (time1 * 1000000.0).ToString("#,##0.000") & "µs"
		ElseIf Time < 0.000001 Then
			stime1 = stime1 & (time1 * 1000000000.0).ToString("#,##0.000") & "ns"
		End If
		tbkHighTime.Text = stime1

		stime2 = "Low Time = "
		If time2 >= 1000000000.0 Then
			stime2 = stime2 & (time2 * 0.000000001).ToString("#,##0.000") & "Gs"
		ElseIf time2 < 1000000000.0 And time2 >= 1000000.0 Then
			stime2 = stime2 & (time2 * 0.000001).ToString("#,##0.000") & "Ms"
		ElseIf time2 < 1000000.0 And time2 >= 1000.0 Then
			stime2 = stime2 & (time2 * 0.001).ToString("#,##0.000") & "ks"
		ElseIf time2 < 1000.0 And time2 >= 1.0 Then
			stime2 = stime2 & time2.ToString("#,##0.000") & "s"
		ElseIf time2 < 1.0 And time2 >= 0.001 Then
			stime2 = stime2 & (time2 * 1000.0).ToString("#,##0.000") & "ms"
		ElseIf time2 < 0.001 And Time >= 0.000001 Then
			stime2 = stime2 & (time2 * 1000000.0).ToString("#,##0.000") & "µs"
		ElseIf Time < 0.000001 Then
			stime2 = stime2 & (time2 * 1000000000.0).ToString("#,##0.000") & "ns"
		End If
		tbkLowTime.Text = stime2

		sTime = "Total Time = "
		If Time >= 1000000000.0 Then
			sTime = sTime & (Time * 0.000000001).ToString("#,##0.000") & "Gs"
		ElseIf time < 1000000000.0 And time >= 1000000.0 Then
			sTime = sTime & (Time * 0.000001).ToString("#,##0.000") & "Ms"
		ElseIf time < 1000000.0 And time >= 1000.0 Then
			sTime = sTime & (Time * 0.001).ToString("#,##0.000") & "ks"
		ElseIf time < 1000.0 And time >= 1.0 Then
			sTime = sTime & Time.ToString("#,##0.000") & "s"
		ElseIf time < 1.0 And time >= 0.001 Then
			sTime = sTime & (Time * 1000.0).ToString("#,##0.000") & "ms"
		ElseIf time < 0.001 And Time >= 0.000001 Then
			sTime = sTime & (Time * 1000000.0).ToString("#,##0.000") & "µs"
		ElseIf Time < 0.000001 Then
			sTime = sTime & (Time * 1000000000.0).ToString("#,##0.000") & "ns"
		End If
		tbkTotalTime.Text = sTime
		tbkDutyCtcle.Text = "Duty Cycle = " & DutyCycle.ToString("#,##0.000%")
	End Sub

	Private Sub textbox1_TextChanged(sender As Object, e As TextChangedEventArgs) Handles textbox1.TextChanged, textbox2.TextChanged, textbox3.TextChanged
		If textbox1.Text = "." Then
			textbox1.Text = "0."
			textbox1.SelectionStart = textbox1.Text.Length
		End If
		If textbox2.Text = "." Then
			textbox2.Text = "0."
			textbox2.SelectionStart = textbox2.Text.Length
		End If
		If textbox3.Text = "." Then
			textbox3.Text = "0."
			textbox3.SelectionStart = textbox3.Text.Length
		End If
		If textbox1.Text <> "" And textbox2.Text <> "" And textbox3.Text <> "" Then Calculate()
	End Sub

	Private Sub cbxR1_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles cbxR1.SelectionChanged, cbxR2.SelectionChanged, cbxC.SelectionChanged
		If textbox1.Text <> "" And textbox2.Text <> "" And textbox3.Text <> "" Then Calculate()
	End Sub

	Private Sub textbox1_GotFocus(sender As Object, e As RoutedEventArgs) Handles textbox1.GotFocus
		textbox1.SelectionStart = 0
		textbox1.SelectionLength = textbox1.Text.Length
	End Sub

	Private Sub textbox2_GotFocus(sender As Object, e As RoutedEventArgs) Handles textbox2.GotFocus
		textbox2.SelectionStart = 0
		textbox2.SelectionLength = textbox2.Text.Length
	End Sub

	Private Sub textbox3_GotFocus(sender As Object, e As RoutedEventArgs) Handles textbox3.GotFocus
		textbox3.SelectionStart = 0
		textbox3.SelectionLength = textbox3.Text.Length
	End Sub
End Class

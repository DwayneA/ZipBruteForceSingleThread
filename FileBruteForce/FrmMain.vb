Imports Ionic.Zip
Imports System.Text
Imports System.Threading

Public Class FrmMain

    Dim File As String
    Dim Characters As String = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz1234567890"
    Dim PassString As String
    Dim StopW As New Stopwatch
    Dim Zip As ZipFile
    Dim bitBucket As System.IO.Stream = System.IO.Stream.Null
    Dim count As Int32
    Dim CutCount As Int16 = 18
    Dim Thr As New Thread(AddressOf GeneratePass)
    Delegate Sub Delegate1(PassString As String)
    Dim TimeS


    Public Sub BtnBrute_Click(sender As Object, e As EventArgs) Handles BtnBrute.Click

        Thr.IsBackground = True
        Thr.Start()
        count = 1
        StopW.Start()
        GeneratePass()

    End Sub

    Public Sub GeneratePass()

        Zip = ZipFile.Read(TbFile.Text)

        For Each Ch1 As Char In Characters
            For Each Ch2 As Char In Characters
                For Each Ch3 As Char In Characters
                    For Each Ch4 As Char In Characters
                        For Each Ch5 As Char In Characters
                            For Each Ch6 As Char In Characters
                                For Each Ch7 As Char In Characters
                                    For Each Ch8 As Char In Characters
                                        For Each Ch9 As Char In Characters
                                            For Each Ch10 As Char In Characters
                                                For Each Ch11 As Char In Characters
                                                    For Each Ch12 As Char In Characters
                                                        For Each Ch13 As Char In Characters
                                                            For Each Ch14 As Char In Characters
                                                                For Each Ch15 As Char In Characters
                                                                    For Each Ch16 As Char In Characters
                                                                        For Each Ch17 As Char In Characters
                                                                            For Each Ch18 As Char In Characters
                                                                                For Each Ch19 As Char In Characters
                                                                                    For Each Ch20 As Char In Characters

                                                                                        PassString = (Ch1 & Ch2 & Ch3 & Ch4 & Ch5 & Ch6 & Ch7 & Ch9 & Ch10 & Ch11 & Ch12 & Ch13 & Ch14 & Ch15 & Ch16 & Ch17 & Ch18 & Ch19 & Ch20)
                                                                                        PassString = (Ch1 & Ch2 & Ch3 & Ch4 & Ch5 & Ch6 & Ch7 & Ch9 & Ch10 & Ch11 & Ch12 & Ch13 & Ch14 & Ch15 & Ch16 & Ch17 & Ch18 & Ch19 & Ch20)
                                                                                      
                                                                                        PassString = PassString.Remove(0, CutCount)

                                                                                        Try
                                                                                            For Each A In Zip

                                                                                                If Not A.IsDirectory And A.UsesEncryption Then

                                                                                                    A.ExtractWithPassword(bitBucket, PassString)
                                                                                                    A.ExtractWithPassword(bitBucket, PassString)

                                                                                                End If

                                                                                            Next

                                                                                            MessageBox.Show("Password is:" & PassString)
                                                                                            Me.StopW.Stop()

                                                                                        Catch ex As Exception
                                                                                        End Try

                                                                                        TbCurAtt.Invoke(New Delegate1(AddressOf CurAttUpdate), New Object() {PassString})

                                                                                    Next
                                                                                    If CutCount > 17 Then CutCount = CutCount - 1
                                                                                Next
                                                                                If CutCount > 16 Then CutCount = CutCount - 1
                                                                            Next
                                                                            If CutCount > 15 Then CutCount = CutCount - 1
                                                                        Next
                                                                        If CutCount > 14 Then CutCount = CutCount - 1
                                                                    Next
                                                                    If CutCount > 13 Then CutCount = CutCount - 1
                                                                Next
                                                                If CutCount > 13 Then CutCount = CutCount - 1
                                                            Next
                                                            If CutCount > 12 Then CutCount = CutCount - 1
                                                        Next
                                                        If CutCount > 11 Then CutCount = CutCount - 1
                                                    Next
                                                    If CutCount > 10 Then CutCount = CutCount - 1
                                                Next
                                                If CutCount > 9 Then CutCount = CutCount - 1
                                            Next
                                            If CutCount > 8 Then CutCount = CutCount - 1
                                        Next
                                        If CutCount > 7 Then CutCount = CutCount - 1
                                    Next
                                    If CutCount > 6 Then CutCount = CutCount - 1
                                Next
                                If CutCount > 5 Then CutCount = CutCount - 1
                            Next
                            If CutCount > 4 Then CutCount = CutCount - 1
                        Next
                        If CutCount > 3 Then CutCount = CutCount - 1
                    Next
                    If CutCount > 2 Then CutCount = CutCount - 1
                Next
                If CutCount > 1 Then CutCount = CutCount - 1
            Next
            If CutCount > 0 Then CutCount = CutCount - 1
        Next


    End Sub

    Public Sub CurAttUpdate(PassString As String)

        TbCurAtt.Text = PassString

        TbTime.Text = (StopW.Elapsed.Hours & ":" & StopW.Elapsed.Minutes & ":" & StopW.Elapsed.Seconds)

        TimeS = (StopW.Elapsed.Seconds)

        TbToAtt.Text = count

        TbAttPs.Text = (count / TimeS)

        count += 1

        Me.Refresh()

        Application.DoEvents()

    End Sub

End Class

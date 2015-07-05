Public Class 平台管理

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        店家管理.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        查詢分潤紀錄.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        查詢已發出未使用折價券歸還紀錄.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        查詢店家購買折價券紀錄.Show()
        Me.Hide()
    End Sub
End Class

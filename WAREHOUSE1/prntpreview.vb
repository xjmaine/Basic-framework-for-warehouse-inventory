
Public Class prntpreview

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ListView2.View = View.Details
        ListView2.GridLines = True
        ListView2.FullRowSelect = True

        ListView2.Columns.Add("Item Code", 80)
        ListView2.Columns.Add("Item Description", 100)
        ListView2.Columns.Add("Items Added/Released", 60)
        ListView2.Columns.Add("Updated Quantity", 80)
        ListView2.Columns.Add("Unit Price", 80)
        ListView2.Columns.Add("Date Added", 120)
        ListView2.Columns.Add("Time Added", 80)


        MaximizeBox = False

        TopMost = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If MsgBox("Do you want to print?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            LinkLabel1.Visible = False


            Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
            PrintForm1.Print()
            Me.Close()
        Else

            Me.Close()
        End If
    End Sub
End Class
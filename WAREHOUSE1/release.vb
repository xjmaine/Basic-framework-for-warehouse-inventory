Imports System.Data.OleDb

Public Class release

    Private Sub InventoryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WarehouseDataSet)

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'WarehouseDataSet.inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.WarehouseDataSet.inventory)

        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True

        ListView1.Columns.Add("Item Code", 100)
        ListView1.Columns.Add("Item Description", 130)
        ListView1.Columns.Add("Items Added/Released", 70)
        ListView1.Columns.Add("Updated Quantity", 120)
        ListView1.Columns.Add("Unit Price", 80)
        ListView1.Columns.Add("Date Added", 100)
        ListView1.Columns.Add("Time Added", 100)

        ' category.Items.Add("Description")
        ' category.Items.Add("ID")
        Timer1.Start()
        daaate.Text = Date.Today
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        time.Text = TimeString
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim tempQty As Integer
        Dim Qty As Integer

        tempQty = CInt(rlsQty.Text)
        Qty = CInt(QuantityTextBox.Text)

        If tempQty > Qty And Qty <> 0 Then
            MsgBox("PLEASE ENTER LESSER QUANTITY")
        End If
        If Qty = 0 Then
            MsgBox("OUT OF STOCK!!")
        End If
        If Qty > tempQty Or tempQty = Qty Then
            QuantityTextBox.Text = Qty - tempQty

        End If

        Me.Validate()
        Me.InventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WarehouseDataSet)

        'Add item to listview
        Dim arr(7) As String
        Dim itm As ListViewItem


        arr(0) = Item_NumberTextBox.Text
        arr(1) = DescriptionTextBox.Text
        arr(2) = rlsQty.Text
        arr(3) = QuantityTextBox.Text
        arr(4) = Unit_PriceTextBox.Text
        arr(5) = Date.Today
        arr(6) = time.Text

        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dashBoard.Show()
        Me.Hide()
    End Sub


    Private Sub printprvw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printprvw.Click
        Dim f2 As New prntpreview

        For Each item As ListViewItem In ListView1.Items

            f2.ListView2.Items.Add(item.Clone())

        Next
        f2.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListView1.Items.Clear()
        searchByID()
        addToTextArea()
    End Sub

    Private Sub searchByID()
        Try

            Dim conString As String = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'warehouse.accdb'"
            Dim con As New OleDbConnection(conString)
            Dim cmd As OleDbCommand = New OleDbCommand("select * from inventory where ID=" & textSearch.Text & "", con)
            con.Open()
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "inventory")
            InventoryDataGridView.DataSource = myDataSet.Tables("inventory").DefaultView
            addToTextArea()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub addToTextArea()
        InventoryBindingSource.DataSource.ToString()


    End Sub
End Class
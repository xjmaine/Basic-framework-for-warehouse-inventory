Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class add

    Private Sub InventoryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WarehouseDataSet)

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True

        ListView1.Columns.Add("Item Number", 150)
        ListView1.Columns.Add("Item Description", 210)
        ListView1.Columns.Add("Items Added/Released", 70)
        ListView1.Columns.Add("Updated Quantity", 70)
        ListView1.Columns.Add("Unit Price", 150)
        ListView1.Columns.Add("Date Added", 150)
        ListView1.Columns.Add("Time Added", 150)


        'TODO: This line of code loads data into the 'WarehouseDataSet.inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.WarehouseDataSet.inventory)


        Timer1.Start()
        daaate.Text = Date.Today
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        time.Text = TimeString
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        searchByID()
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
            'addToTextArea()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.InventoryTableAdapter.FillBy(Me.WarehouseDataSet.inventory)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub printprvw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printprvw.Click
        'copy items
        Dim f2 As New prntpreview

        For Each itm As ListViewItem In ListView1.Items

            f2.ListView2.Items.Add(itm.Clone())

        Next
        f2.Show()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tempQty As Integer
        Dim Qty As Integer

        tempQty = CInt(addQty.Text)
        Qty = CInt(QuantityTextBox.Text)

        QuantityTextBox.Text = tempQty + Qty

        Me.Validate()
        Me.InventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WarehouseDataSet)


        'Add item to listview
        Dim arr(7) As String
        Dim itm As ListViewItem


        arr(0) = Item_NumberTextBox.Text
        arr(1) = DescriptionTextBox.Text
        arr(2) = addQty.Text
        arr(3) = QuantityTextBox.Text
        arr(4) = Unit_PriceTextBox.Text
        arr(5) = Date.Today
        arr(6) = time.Text

        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        dashBoard.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Add item to listview
        Dim arr(6) As String
        Dim itm As ListViewItem


        arr(0) = Item_NumberTextBox.Text
        arr(1) = DescriptionTextBox.Text
        arr(2) = addQty.Text
        arr(3) = Unit_PriceTextBox.Text
        arr(4) = Date.Today
        arr(5) = time.Text

        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)
        Me.Validate()
        Me.InventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WarehouseDataSet)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
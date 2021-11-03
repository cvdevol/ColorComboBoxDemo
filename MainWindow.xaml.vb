Imports System.Text

Class MainWindow

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim sb As New StringBuilder

        sb.AppendLine("This is some sample text")
        sb.AppendLine("to illustrate the use of")
        sb.AppendLine("the ColorComboBox.")
        sb.AppendLine()
        sb.AppendLine("Use MouseWheel while hovering")
        sb.AppendLine("over the ComboBox")
        sb.AppendLine("to cycle through colors,")
        sb.AppendLine("or,")
        sb.AppendLine("click on the ComboBox")
        sb.AppendLine("to pick from the DropDown list.")

        TB.Text = sb.ToString

        cbBackground.SelectItem(Brushes.White)
        cbForeground.SelectItem(Brushes.Black)
    End Sub

    Private Sub btnWebColors_Click(sender As Object, e As RoutedEventArgs)
        cbBackground.DisplayType = ColorType.WebColors
        cbForeground.DisplayType = ColorType.WebColors
    End Sub

    Private Sub btnSysColors_Click(sender As Object, e As RoutedEventArgs)
        cbBackground.DisplayType = ColorType.SystemColors
        cbForeground.DisplayType = ColorType.SystemColors
    End Sub

    Private Sub btnAllColors_Click(sender As Object, e As RoutedEventArgs)
        cbBackground.DisplayType = ColorType.AllColors
        cbForeground.DisplayType = ColorType.AllColors
    End Sub

    Private Sub cbForeground_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        If e.AddedItems.Count = 1 Then
            Dim ci As ColorItem
            ci = CType(e.AddedItems(0), ColorItem)
            TB.Foreground = ci.Brush
        End If
    End Sub

    Private Sub cbBackground_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        If e.AddedItems.Count = 1 Then
            Dim ci As ColorItem
            ci = CType(e.AddedItems(0), ColorItem)
            TB.Background = ci.Brush
        End If
    End Sub
End Class

Imports System.Windows.Controls.Primitives

''' <summary>
''' A custom ComboBox that gives direct access to the textbox and popup.
''' </summary>
Public Class ComboBoxEx
    Inherits System.Windows.Controls.ComboBox

    Public Shared TextBoxProperty As DependencyProperty = DependencyProperty.RegisterAttached("TextBox", GetType(TextBox), GetType(ComboBoxEx))
    Public Property TextBox As TextBox
        Get
            Return CType(GetValue(TextBoxProperty), TextBox)
        End Get
        Set(value As TextBox)
            SetValue(TextBoxProperty, value)
        End Set
    End Property

    Public Shared PopupProperty As DependencyProperty = DependencyProperty.RegisterAttached("Popup", GetType(Popup), GetType(ComboBoxEx))
    Public Property Popup As Popup
        Get
            Return CType(GetValue(PopupProperty), Popup)
        End Get
        Set(value As Popup)
            SetValue(PopupProperty, value)
        End Set
    End Property


    Public Sub New()
        MyBase.New

    End Sub

    Public Overrides Sub OnApplyTemplate()
        MyBase.OnApplyTemplate()

        TextBox = TryCast(MyBase.GetTemplateChild("PART_EditableTextBox"), TextBox)
        If TextBox IsNot Nothing Then
            TextBox.VerticalContentAlignment = VerticalAlignment.Center

        End If

        Popup = TryCast(MyBase.GetTemplateChild("PART_Popup"), Popup)
        If Popup IsNot Nothing Then

        End If
    End Sub


End Class

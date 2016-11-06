
Friend Module modStairs


    Friend refParent As frmMDI

    Friend Sub logError(ex As Exception, src As Reflection.MethodBase, ByVal ParamArray args() As String)
        Dim err As String = vbNewLine & "ERROR"
        Dim arg As String = ""
        If Not args Is Nothing Then arg = String.Join(", ", args)
        err &= vbNewLine &
            "Type: " & ex.GetType.ToString & vbNewLine &
            "Arguments: " & arg & vbNewLine &
            "Timestamp: " & Now.ToString & vbNewLine &
            "Source: " & src.DeclaringType.FullName & "." & src.Name & vbNewLine &
            "Description: " & ex.Message & vbNewLine &
            "Stack Trace: " & vbNewLine & ex.StackTrace & vbNewLine
        Debug.Print(err)
    End Sub

End Module


Class Window1
End Class


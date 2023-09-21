'Zachary Christensen
'RCET 2265
'Fall 2023
'Accumulate Messages
'https://github.com/Minidude140/AccumulateMessages.git






Imports System

Module MessageProgram
    Sub Main(args As String())
        'uncomment to test interactively
        'Test.Manual()
        Test.Auto()
    End Sub

    Function UserMessages(Optional ByVal newMessage As String = "", Optional ByVal clear As Boolean = False) As String
        'your code here
        Static messages As String

        If clear Then
            messages = ""
        ElseIf newMessage <> "" Then
            messages = messages & newMessage & vbCrLf
        Else newMessage = ""
            Return messages
        End If
        Return messages
    End Function


End Module

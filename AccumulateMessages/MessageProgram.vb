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
        Static savedMessages As String

        'check if the clear statement is true
        If clear Then ' if clear is true set old messages to blank
            savedMessages = ""
        ElseIf newMessage <> "" Then 'if new message is not empty concatenate the new message with the old
            savedMessages = savedMessages & newMessage & vbCrLf
        Else newMessage = "" 'if the new message is blank return the old messages
            Return savedMessages
        End If
        Return savedMessages
    End Function


End Module

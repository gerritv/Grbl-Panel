Option Explicit On
Option Strict On

' The errors dictionary, now private in GrblGcodeView, need to be also used in GrblStatus, as these errors are reported only as digits
' So, as only one dictionary is usefull, and will need to be called from different places, it seems the singleton pattern is the best and 'lightest' way
' to implement it. 

Imports GrblPanel.My.Resources

Public Class GrblErrorsSingleton
    'Using SyncLock make this thread safe
    Private Shared _instance As GrblErrorsSingleton = Nothing
    Private Shared ReadOnly _mylock As New Object()
    Private Shared _errors As Dictionary(Of String, String)


   Private Sub New()
        
    End Sub

    Public Shared Function GetInstance() As GrblErrorsSingleton
        SyncLock(_mylock)
            If _instance Is Nothing
                _instance = New GrblErrorsSingleton
            End If

            Return _instance
        End SyncLock
    End Function
    
    ''' <summary>
    ''' This Function returns a Dictionary of Grbl error codes in plain text
    ''' </summary>
    ''' <returns></returns>
    Public Function GetErrorsDct() As Dictionary(Of String, String)
        _errors = New Dictionary(Of String, String) From {
        {"0", "ok"},
        {"1", GrblGcodeView_ExpectedCommandLetter},
        {"2", GrblGcodeView_BadNumberFormat},
        {"3", GrblGcodeView_InvalidStatement},
        {"4", GrblGcodeView_Value0},
        {"5", Resources.GrblGcodeView_SettingDisabled},
        {"6", Resources.GrblGcodeView_Value3Usec},
        {"7", Resources.GrblGcodeView_EEPROMReadFailUsingDefaults},
        {"8", Resources.GrblGcodeView_NotIdle},
        {"9", Resources.GrblGcodeView_AlarmLock},
        {"10", Resources.GrblGcodeView_HomingIsNotEnabled},
        {"11", Resources.GrblGcodeView_LineOverflow},
        {"12", Resources.GrblGcodeView_StepRate30kHz},
        {"13", Resources.GrblGcodeView_CheckDoor},
        {"14", Resources.GrblGcodeView_BuildInfoLength},
        {"15", Resources.GrblGcodeView_JogTravel},
        {"16", Resources.GrblGcodeView_JogFormat},
        {"20", Resources.GrblGcodeView_UnsupportedCommand},
        {"21", Resources.GrblGcodeView_ModalGroupViolation},
        {"22", Resources.GrblGcodeView_UndefinedFeedRate},
        {"23", Resources.GrblGcodeView_CommandValueIsNotInteger},
        {"24", Resources.GrblGcodeView_AxisCommandConflict},
        {"25", Resources.GrblGcodeView_WordRepeated},
        {"26", Resources.GrblGcodeView_NoAxisWords},
        {"27", Resources.GrblGcodeView_InvalidLineNumber},
        {"28", Resources.GrblGcodeView_ValueWordMissing},
        {"29", Resources.GrblGcodeView_UnsupportedCoordinateSystem},
        {"30", Resources.GrblGcodeView_G53InvalidMotionMode},
        {"31", Resources.GrblGcodeView_AxisWordsExist},
        {"32", Resources.GrblGcodeView_NoAxisWordsInPlane},
        {"33", Resources.GrblGcodeView_InvalidTarget},
        {"34", Resources.GrblGcodeView_ArcRadiusError},
        {"35", Resources.GrblGcodeView_NoOffsetsInPlane},
        {"36", Resources.GrblGcodeView_UnusedWords},
        {"37", Resources.GrblGcodeView_G43DynamicAxisError},
        {"38", Resources.GrblGcodeView_InvalidToolNumber}
        }
        Return _errors
    End Function




End Class

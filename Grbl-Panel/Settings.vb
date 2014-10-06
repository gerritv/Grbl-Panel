Imports System.Configuration
Imports GrblPanel.GrblGui
Namespace My
    
    'This class allows you to handle specific events on the settings class:
    ' The SettingChanging event is raised before a setting's value is changed.
    ' The PropertyChanged event is raised after a setting's value is changed.
    ' The SettingsLoaded event is raised after the setting values are loaded.
    ' The SettingsSaving event is raised before the setting values are saved.
    Partial Friend NotInheritable Class MySettings
        Private Sub traphere(sender As Object, e As SettingChangingEventArgs) Handles Me.SettingChanging
            ' A stub to allow checking for settings changes during testing
            ' The problem with these events is that they trigger for each character typed into a box!!!
        End Sub
        Private Sub settings_SettingsChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles Me.PropertyChanged
            ' Arrive here when user changes something on Settings tab
            ' The problem with these events is that they trigger for each character typed into a box!!!
        End Sub
    End Class
End Namespace


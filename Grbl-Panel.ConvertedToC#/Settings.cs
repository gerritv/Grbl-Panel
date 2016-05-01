using System.Configuration;

namespace GrblPanel.My
{

	//This class allows you to handle specific events on the settings class:
	// The SettingChanging event is raised before a setting's value is changed.
	// The PropertyChanged event is raised after a setting's value is changed.
	// The SettingsLoaded event is raised after the setting values are loaded.
	// The SettingsSaving event is raised before the setting values are saved.
	internal sealed partial class MySettings
	{
		private void traphere(object sender, SettingChangingEventArgs e)
		{
			// A stub to allow checking for settings changes during testing
			// The problem with these events is that they trigger for each character typed into a box!!!
		}
		private void settings_SettingsChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			// Arrive here when user changes something on Settings tab
			// The problem with these events is that they trigger for each character typed into a box!!!
		}
	}
}


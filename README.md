OSUHackathon2013
================

Web-based modular alarm clock application created at OSU hackathon. Modules currently available are weather, simple text, Google calendar, and RSS, but any class implementing IModule will automatically be read as a module.

# How to use

* Open in solution in Visual Studio and run.
* Select a type of module to add and click "Add Module" to add it, then go through the accompanying setup instructions.
* The sequence of added modules is shown in the lower left hand corner.
* For the currently-selected module, to go back to the setup screen, click "Edit Module". To remove it, click "Remove Module". To move it in the list, click "Move Up" or "Move Down".
* The time at the top of the window is shown in 24-hour time and it the time at which the alarm sounds. To change it, click "Change Time" to open the time configuration window.
* To add or remove delays in the sequence, click "Add Delay" or "Remove Delay". Here, you can set the duration of the delay in milliseconds or choose where the delay occurs (indices are 0-based).
* To preview the alarm sequence, click "Play Modules in Sequence".

# How to add a module

Make a class implementing the IModule interface. Look to the other classes on examples of how to do this. Many have an accompanying setup form.

# Possible future improvements

* Port to mobile platforms.
* Add more modules.
* Change the UI to be move user friendly, maybe with a Windows Movie Maker-style timeline view.
* Improve the RSS module to give the user more options of what is read.

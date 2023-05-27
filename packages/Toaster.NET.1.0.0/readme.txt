Author: Kaustubh Patange
Github: http://github.com/KaustubhPatange

This toast notification is inspired from Android Studio. First implementation can be found here https://androdevkit.github.io

If you are programming winform on Windows 10 and have enabled DPI AWARE, you need to create a fixed dpi toast (see 4th example from below).

ToastDuration.SHORT = 4 secs
ToastDuration.LONG = 7 secs
ToastDuration.INDEFINITE = Until user manually close it.

==== Usage Notes ====

* Create a general toast

Toast.show(this, "Demo Title", "Hey there, this is a demo toast", ToastType.INFO,ToastDuration.SHORT);
 
----

* Create an error toast

Toast.show(this, "Demo Title", "Hey there, this is a demo toast", ToastType.ERROR,ToastDuration.LONG);

----

* Create a dark theme toast

Toast.show(this, "Demo Title", "Hey there, this is a demo toast", ToastType.INFO,ToastDuration.SHORT,ToastTheme.DARK);

----

* Create a fixed dpi toast

When you create a winform project in windows 10, visual studio adds an autoscale dimensions based on your dpi resolution. Due to this when the same application is run on low dpi PCs creates a blurry look as the autoscaling controls stretched out a bit. For such encounters set the last flag 'fixlowerdpi' to true (example below). 

Toast.show(this, "Demo Title", "Hey there, this is a demo toast", ToastType.INFO,ToastDuration.SHORT,ToastTheme.LIGHT,true);

----
###############################################################################
# HOW DOES IT WORK?
###############################################################################

This example is an answer to a question in the Unity forum at:
http://forum.unity3d.com/threads/horizontal-wave-distortion.295769/


###############################################################################
# GETTING STARTED
###############################################################################

Please use the provided example scene to see how it works.
* Open "Assets/GrabPassDistortion_Example/Scene.unity".
* Press PLAY
* Switch to the Scene view, where you can find several examples.

I did not implement navigation in the Game View, use the Scene View instead.


Download latest version at http://www.console-dev.de


###############################################################################
# SUPPORTED UNITY VERSIONS
###############################################################################

I used Unity 5.4 to create the shaders.

The included example scene has been tested with the following Unity versions (DX11):

* Unity 5.4
* Unity 5.5
* Unity 5.6
* Unity 2017.1
* Unity 2017.2
* Unity 2017.3 beta


###############################################################################
# KNOWN ISSUES
###############################################################################

Using the "GrabPass Distortion (Layer)" shader is used to combine several distortion effects in a smoothly fashion, without any hard edges. However, this did break with Unity 5.5 and has not been fixed by Unity Technologies since then.

Here is the link to the issue:
https://issuetracker.unity3d.com/issues/regression-overlapping-distortions-are-not-blended-smoothly-when-shader-performs-grabpass-for-every-distortion-object

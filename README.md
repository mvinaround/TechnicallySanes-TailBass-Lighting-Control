![logo](https://github.com/mvinaround/TechnicallySanes-TailBass-Lighting-Control/blob/master/logo.jpg?raw=true)
# TechnicallySane's TailBass Lighting Control

A Small application written in C# to generate a capturable window for OBS that can control the lighting in the TailBass world in VRChat (https://vrchat.com/home/world/wrld_7327b9c5-cd6c-45e3-a7d2-e1ff704fd603)

## Installation/Use

Download the zip, extract to a folder and run the Tailbass Lighting Control.exe

https://github.com/mvinaround/TechnicallySanes-TailBass-Lighting-Control/raw/master/Tailbass%20Lighting%20Control/Compiled/TailbassLightingControl-Release.zip


Or compile and run yourself. The Compiled link above is for people just wanting to use the software ^_^
## Features
 - Control over all lighting in the Tailbass world!
 - Premade Patterns
 - Easy interface, just turn on what you want, choose a pattern and choose your colours!
 - Scene saving. Set a show file and you can save your current lighting settings and colours to a scene button, and then recall instantly!
 

## Demo
Video demo: https://www.youtube.com/watch?v=a5O1LbQ7DEI&ab_channel=TechnicallySane

[![IMAGE ALT TEXT HERE](https://img.youtube.com/vi/a5O1LbQ7DEI/0.jpg)](https://www.youtube.com/watch?v=a5O1LbQ7DEI)

## Simple OBS Setup instructions

First make sure that you have the software running, then make sure that you have the OBS Layer window shown (bottom right button).
Next in OBS use Window Capture and select the OBS Layer window. Make sure that this is scaled to the stream window size.

### Optional Steps

If you're planning to use regular content mapped across all the TailBass screens then you want to follow the tutorial video below, this shows you how to add the nodes without covering the entire video feed!

Transparent Node Layer (Required!): https://raw.githubusercontent.com/mvinaround/TechnicallySanes-TailBass-Lighting-Control/master/Tailbass%20Lighting%20Control/OBS%20Assets/BlackNodes.png

*This also works to make the OBS Layer transparent!*

Video tutorial: https://www.youtube.com/watch?v=oj_KjvX2n_I

[![IMAGE ALT TEXT HERE](https://img.youtube.com/vi/oj_KjvX2n_I/0.jpg)](https://www.youtube.com/watch?v=oj_KjvX2n_I)


## Known Issues

 - Having the OBS Layer window minimised or off screen stops the rendering of the pixels (This is a windows thing, ill attempt to fix it!) Having it nested under other windows works fine! 
 - Windows flags the software as potentially dangerous, this is entirely due to the software not being used on many machines, there's nothing malicious in the software at all! (check the source code and compile yourself if you want!)

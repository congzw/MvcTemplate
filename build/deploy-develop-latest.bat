REM set msbuildExePath=msbuild.exe
REM call %msbuildExePath% deploy.proj /p:MyWebContainerPathOutput=C:\dev\MvcTemplate /p:MyWebFolderName=Demos.Web

call msbuild deploy.proj /p:MyWebContainerPathOutput=.\output /p:MyWebFolderName=Demos.Web

pause

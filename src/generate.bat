rmdir "%~dp0..\deploy" /s /q
"c:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe" "%~dp0HelloWorld\HelloWorld.csproj" /t:Package /p:Configuration=Release /p:Platform=AnyCPU
mkdir "%~dp0..\deploy"
xcopy "%~dp0HelloWorld\obj\Release\Package\PackageTmp" "%~dp0..\deploy" /s /e

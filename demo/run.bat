@ECHO OFF

if "%1"=="" (
	ECHO run clear:  Delete the current _vimrc

) ELSE IF "%1"=="clear" (
	ECHO Removing %USERPROFILE%\_vimrc
	DEL %USERPROFILE%\_vimrc
) ELSE IF "%1"=="original" (
	ECHO Removing %USERPROFILE%\_vimrc
	copy _original_vimrc %USERPROFILE%\_vimrc

) ELSE (
	ECHO Appending to %USERPROFILE%\_vimrc...
	ECHO.
	TYPE %1
	
	TYPE %1 >> %USERPROFILE%\_vimrc
)

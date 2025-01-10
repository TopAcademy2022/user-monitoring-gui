:: Remarks Print all information on console
@echo ON

:: Remarks Save start directory
set "START_DIR=%cd%"
:: Remarks Set default export directory strategy (Create or ignore)
set "EXPORT_DIR_STRATEGY=Create"
:: Remarks Set default exit strategy (AfterLastCommand or none)
set "EXIT_STRATEGY=AfterLastCommand"
:: Remarks Set build type (Release or Debug)
set "BUILD_TYPE=Release"
:: Remarks Set build type (Release or Debug)
set "DOTNET_VERSION=net6.0"

:: Remarks Folder name with core library
set "CORE_BUILD_DIR=./core/user-monitoring-core/build"
:: Remarks Library name
set "CORE_LIB_NAME=user-monitoring-core.dll"
:: Remarks Core library build script name
set "CORE_BUILD_SCRIPT_NAME=build-windows.bat"
:: Remarks Library export directory
set "LIB_EXPORT_DIR=./user-monitoring-gui/bin/%BUILD_TYPE%/%DOTNET_VERSION%/"

if "%EXPORT_DIR_STRATEGY%"=="Create" (
    REM Create path for export core library
    mkdir "%LIB_EXPORT_DIR%" /p
)

REM See dirs GithubAction
dir
cd ./core
dir
cd ./user-monitoring-core
dir

if exist "%LIB_EXPORT_DIR%" (
    if exist "%CORE_BUILD_DIR%" (
        cd "%CORE_BUILD_DIR%"
        :: Remarks Call build script (default Release version)
        call "%CORE_BUILD_SCRIPT_NAME%" "none"
        
        if exist "%CORE_LIB_NAME%" (
            :: Remarks Call build script (default Release version)
            copy "%CORE_LIB_NAME%" "%START_DIR%"
            
            cd "%START_DIR%"
            move "%CORE_LIB_NAME%" "%LIB_EXPORT_DIR%"
            
            if "%EXIT_STRATEGY%"=="AfterLastCommand" (
                exit 0
            )
        ) else (
            echo Core library not exist && exit 1
        )
    ) else (
        echo Core library directory not exist && exit 1
    )
) else (
    echo Project build directory not exist && exit 1
)

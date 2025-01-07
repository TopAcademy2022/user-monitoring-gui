:: Remarks TODO: Update build type, create paths and update relative paths
:: Remarks Print all information on console
@echo ON

:: Remarks Folder name with core library
set CORE_DIR=./core/user-monitoring-core/
set CORE_LIB_NAME=user-monitoring-core.dll

if exist '%CORE_DIR%' (
	echo Core directory exist
)
else (
	:: Remarks Call init script
	cd %CORE_DIR%
	mkdir build
	cd build
	
	:: Remarks Run cmake build for core library
	set CMAKE_PRE_BUILD_COMMAND="cmake .."
	set CMAKE_BUILD_COMMAND="cmake --build ."
	powershell -Command %CMAKE_PRE_BUILD_COMMAND%
	powershell -Command %CMAKE_BUILD_COMMAND%

	cd Debug
	if exist '%CORE_LIB_NAME%' (
		echo Core library exist
	)
	else (
		copy %CORE_LIB_NAME% ..\..\..\..\
		cd ../../../../
		move %CORE_LIB_NAME% ./user-monitoring-gui/bin/Debug/net6.0/
	)
)
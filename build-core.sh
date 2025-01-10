#!/bin/bash

# Print all information on console
set -x

# Save start directory
START_DIR=$(pwd)

# Set default export directory strategy (Create or ignore)
EXPORT_DIR_STRATEGY="Create"

# Set default exit strategy (AfterLastCommand or none)
EXIT_STRATEGY="AfterLastCommand"

# Set build type (Release or Debug)
BUILD_TYPE="Release"

# Set .NET version
DOTNET_VERSION="net6.0"

# Folder name with core library
CORE_BUILD_DIR="./core/user-monitoring-core/build"

# Library name
CORE_LIB_NAME="user-monitoring-core.so"

# Core library build script name
CORE_BUILD_SCRIPT_NAME="build-linux.sh"

# Library export directory
LIB_EXPORT_DIR="./user-monitoring-gui/bin/${BUILD_TYPE}/${DOTNET_VERSION}/"

if [ "$EXPORT_DIR_STRATEGY" == "Create" ]; then
    # Create path for export core library
    mkdir -p "$LIB_EXPORT_DIR"
fi

if [ -d "$LIB_EXPORT_DIR" ]; then
    if [ -d "$CORE_BUILD_DIR" ]; then
        cd "$CORE_BUILD_DIR" || exit

        # Add rule for run script
        chmod +x ./"$CORE_BUILD_SCRIPT_NAME"
        # Call build script (default Release version)
        ./"$CORE_BUILD_SCRIPT_NAME" "none"

        if [ -f "$CORE_LIB_NAME" ]; then
            # Copy core library to start directory
            cp "$CORE_LIB_NAME" "$START_DIR"

            cd "$START_DIR" || exit
            mv "$CORE_LIB_NAME" "$LIB_EXPORT_DIR"

            if [ "$EXIT_STRATEGY" == "AfterLastCommand" ]; then
                exit 0
            fi
        else
            echo "Core library does not exist"
            exit 1
        fi
    else
        echo "Core library directory does not exist"
        exit 1
    fi
else
    echo "Project build directory does not exist"
    exit 1
fi

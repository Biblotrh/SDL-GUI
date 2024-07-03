cmake_minimum_required(VERSION 3.0)
project(SDL-GUI VERSION 1.0 LANGUAGES CSharp)

file(GLOB_RECURSE CS_FILES ${CMAKE_CURRENT_SOURCE_DIR}/*.cs)

add_executable(SDL-GUI ${CS_FILES})

set_property(DIRECTORY ${CMAKE_CURRENT_SOURCE_DIR} PROPERTY VS_STARTUP_PROJECT SDL-GUI)

target_compile_options(SDL-GUI PUBLIC "/unsafe")

file(GLOB DLL_FILES ${CMAKE_CURRENT_SOURCE_DIR}/dll/*.dll)

if(DLL_FILES)
    message(STATUS "DLL Copid")
    # Add the SDL2-CS DLL as a dependency
    add_custom_command(TARGET WorkbenchDev POST_BUILD
        COMMAND ${CMAKE_COMMAND} -E copy_if_different
        ${DLL_FILES}
        $<TARGET_FILE_DIR:WorkbenchDev>)
else()
    message(FATAL_ERROR "Can't Find Dlls")
endif()
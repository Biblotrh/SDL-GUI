cmake_minimum_required(VERSION 3.0)
project(SDL-GUI VERSION 1.0 LANGUAGES CSharp)

file(GLOB CS_FILES "*.cs")

add_executable(SDL-GUI ${CS_FILES})

set_property(DIRECTORY ${CMAKE_CURRENT_SOURCE_DIR} PROPERTY VS_STARTUP_PROJECT SDL-GUI)

target_compile_options(SDL-GUI PUBLIC "/unsafe")
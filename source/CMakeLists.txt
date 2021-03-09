cmake_minimum_required(VERSION 3.15.0)
project(celestella VERSION 1.0)


# Use modern C++
set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED True)


#==========================================

#GLFW additions
set(GLFW_BUILD_DOCS OFF CACHE BOOL "" FORCE)
set(GLFW_BUILD_TESTS OFF CACHE BOOL "" FORCE)
set(GLFW_BUILD_EXAMPLES OFF CACHE BOOL "" FORCE)

add_subdirectory(lib/glfw)
include_directories(lib/glfw)
include_directories(lib/glfw/include)

include_directories(lib/glad)
include_directories(lib/glad/include)

#===========================================

#glm additions

set(glm_DIR lib/glm/cmake/glm) 
find_package(glm REQUIRED)


add_executable(celestella 
	src/main.cpp 
	lib/glad/glad.c 
)

target_link_libraries(celestella glfw)
target_link_libraries(celestella glm::glm)

// pch.cpp: source file corresponding to the pre-compiled header

#include "pch.h"
#include <stdio.h>
#include <Windows.h>
#include <iostream>
// When you are using pre-compiled headers, this source file is necessary for compilation to succeed.

struct Name
{
	int  age;
	char FirstName[100];
	char LastName[100];
	int  age2;
};

extern "C" __declspec(dllexport) void __cdecl GetName(struct Name* name)
{
	strncpy_s(name->FirstName, "FirstName", sizeof(name->FirstName));
	strncpy_s(name->LastName, "LastName", sizeof(name->FirstName));

}


extern "C" __declspec(dllexport) void __cdecl SetName(struct Name* name)
{
	char array1[100] = {  };
	char array2[100] = {  };
	strncpy_s(array1, name->FirstName, sizeof(name->FirstName));
	strncpy_s(array2, name->LastName, sizeof(name->FirstName));
	std::cout << array1;
	std::cout << array2;
}

extern "C" __declspec(dllexport) void __cdecl Hello()
{
	printf("Hello\n");
}
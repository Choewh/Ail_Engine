#include "LaunchEngineLoop.h"
#include <iostream>
#include "Engine/Engine.h"

int32 FEngineLoop::PreInit(const TCHAR* CmdLine)
{
	return 0;
}

int32 FEngineLoop::Init()
{
	return 0;
}

void FEngineLoop::Tick()
{
	cout << "Tick\n";
}

#pragma once
#include "CoreTypes.h"

extern CORE_API bool GIsRequestingExit;
FORCEINLINE bool IsEngineExitRequested()
{
	return GIsRequestingExit;
}
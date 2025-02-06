#pragma once

#include "CoreMinimal.h"

class UEngine : public UObject
{
public:
	static inline UClass* UEngineClass =
		TGetPrivateStaticClassBody<UEngine>(TEXT("UEngine"),
			InternalConstructor<UEngine>, &UObject::StaticClass);
};
// spriteLand2012.cpp : main project file.

#include "stdafx.h"
#include "SpriteWindow.h"
#include "SpriteLand.h"

using namespace System;
using namespace spriteLib;



int main(array<System::String ^> ^args)
{
	SpriteWindow^ window = SpriteWindow::getSpriteWindow();
    onSpriteInitialization();
    Application::Run(window);
    return 0;
}

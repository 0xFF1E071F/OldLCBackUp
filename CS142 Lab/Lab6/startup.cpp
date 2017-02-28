#include "Sprite.h"
#include "SpriteLand.h"
#include "Spaceship.h"
#include <iostream>
using namespace spriteLib;
namespace spriteLib
{

class UFO : public Sprite
{
public:

	UFO() : Sprite()
	{
	}

	UFO(const UFO& orig) : Sprite(orig)
	{
	}
	// setup defaut data of UFO
	enum {thinkness = 5, locationLength = 10,ellipse_Width = 30, ellipse_Height =15};
	virtual bool onDisplay (int width, int height)
	{
		SpriteLand* SpriteLand = 
			SpriteLand::getSpriteLand();

		// draw the UFO
		SpriteLand->drawEllipse(getYLocation(),getXLocation(),ellipse_Width,ellipse_Height,getColor());
		
		SpriteLand->drawLine(getXLocation(),getYLocation(),getXLocation()+locationLength,getYLocation()-locationLength,getColor(),thinkness);
		SpriteLand->drawLine(getXLocation(),getYLocation(),getXLocation()-locationLength,getYLocation()-locationLength,getColor(),thinkness);
		SpriteLand->drawLine(getXLocation(),getYLocation(),getXLocation()+locationLength,getYLocation()+locationLength,getColor(),thinkness);
		SpriteLand->drawLine(getXLocation(),getYLocation(),getXLocation()-locationLength,getYLocation()+locationLength,getColor(),thinkness);
		SpriteLand->drawCircle(getXLocation(),getYLocation(),getRadius(),getColor());
		SpriteLand->drawCircle(getXLocation()+locationLength+1,getYLocation()+locationLength+1,
			getRadius()*3/4,getColor());
		return true;
	}


	virtual void onKeyDown (int keyValue)
	{
		switch (keyValue)
		{
			case 'U':
				// reverse diection
				setRotationalVelocity(
					getRotationalVelocity()*(-1)); 
				break;
			case 'A':		
				// accelerate by 10%
				setVelocityInPixelsPerSecond(
					getXVelocityInPixelsPerSecond()*(1.1),
					getYVelocityInPixelsPerSecond()*(1.1)
					);		
				break;
			case 'D':
				// decelerate by 10%
				setVelocityInPixelsPerSecond(
					getXVelocityInPixelsPerSecond()*(0.9),
					getYVelocityInPixelsPerSecond()*(0.9)
					);
				break;
			case 'B':
				// turn blue
				setColor(0,0,255);
				break;
			case 'J':
				// rotate left 45 degree
				setRotation(
					getRotation()-45);
				break;
			case 'K':
				// rotate right 45 degree
				setRotation(
					getRotation()+45);
				break;
		}
	}


	virtual void onMouseClick ()
	{

		int zeroVel = 0;

		if (isStopped_ != true) 
			// if not stop go stop
		{
			old_X_Vel_ = getXVelocityInPixelsPerSecond();
			old_Y_Vel_ = getYVelocityInPixelsPerSecond();
			old_RA_Vel_  = getRotationalVelocity();
			setRotationalVelocity(0);
			setVelocityInPixelsPerSecond(0,0);
			isStopped_ = true;

		}

		else if (isStopped_ == true) 
			// if this sprite be clicked and stop , restore to move
		{
			setRotationalVelocity(old_RA_Vel_);
			setVelocityInPixelsPerSecond(old_X_Vel_,old_Y_Vel_);
			isStopped_ = false;
		}

	}

	virtual UFO* clone() const
	{
		return new UFO(*this);
	}

private:
		int old_X_Vel_;
		int old_Y_Vel_;
		int old_RA_Vel_;
		bool isStopped_;

};

void onSpriteInitialization()
{

	UFO sprite;
	sprite.setColor(50,50,40);
	sprite.setRadius(10);

	Spaceship spSprite;
	spSprite.setColor(50,125,30);
	spSprite.setRadius(9);

	enum{ windowXSiez = 800,windowYSiez = 800};

	SpriteLand* spriteLand = SpriteLand::getSpriteLand();
	spriteLand->setWindowSize(windowXSiez,windowYSiez);

	spriteLib::Color bgColor(0,255,0);
	spriteLib::Color fgColor(255,0,0);
	spriteLand->setBackgroundColor(bgColor);

	//spriteLand->addSprite(sprite);
	spriteLand->setBackgroundImage("bg.jpg");

	int i=0, // number of Sprits
		rotationVel,xSpeed,ySpeed, // speed
		xStart, yStart, //ration Velocity
		r,g,b;	// color 

	int N_MAX_OF_SPRITS = 11; // decided in question

	for (int i=0;i<N_MAX_OF_SPRITS;++i)
	{
			// also could set random color
			//r = rand ()%256;
			//g = rand ()%256;
			//b = rand ()%256;
			//spriteLib::Color randomColor (r,g,b);
			//sprite.setColor(randomColor);

		xSpeed =  rand() % 401 - 200;	// random speed (<200pixel/sec) in any direction
		ySpeed =  rand() % 401 - 200;

		xStart = rand() % 800+1;		// 800x600 window, random location to start
		yStart = rand() % 600+1;
		rotationVel = rand() % 2;		//(<2pi/sec)

		sprite.setVelocityInPixelsPerSecond(xSpeed,ySpeed); //set random speed
		sprite.setRotationalVelocity(rotationVel);	// set random ration vel
		sprite.setLocation(xStart,yStart);	// set location

		spriteLand->addSprite(sprite);
		spriteLand->addSprite(spSprite);
	}

	for (int i=0;i<N_MAX_OF_SPRITS;++i)
	{
			// also could set random color
			//r = rand ()%256;
			//g = rand ()%256;
			//b = rand ()%256;
			//spriteLib::Color randomColor (r,g,b);
			//sprite.setColor(randomColor);

		xSpeed =  rand() % 401 - 200;	// random speed (<200pixel/sec) in any direction
		ySpeed =  rand() % 401 - 200;

		xStart = rand() % 800+100;		// 800x600 window, random location to start
		yStart = rand() % 800+100;
		rotationVel = rand() % 2;		//(<2pi/sec)

		spSprite.setVelocityInPixelsPerSecond(xSpeed,ySpeed); //set random speed
		spSprite.setRotationalVelocity(rotationVel);	// set random ration vel
		spSprite.setLocation(xStart,yStart);	// set location

		spriteLand->addSprite(spSprite);
	}
}
}
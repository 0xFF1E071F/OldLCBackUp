#include "Sprite.h"
#include "SpriteLand.h"
#include <iostream>
using namespace spriteLib;
namespace spriteLib
{

class Spaceship : public Sprite
{
public:

	Spaceship() : Sprite()
	{
	}

	Spaceship(const Spaceship& orig) : Sprite(orig)
	{
	}
		enum {thinkness = 2, locationLength = 17};
	virtual bool onDisplay (int width, int height)
	{
		SpriteLand* SpriteLand = 
			SpriteLand::getSpriteLand();

		// draw the Spaceship
		SpriteLand->drawLine(
			getXLocation(),
			getYLocation(),
			getXLocation()+locationLength,
			getYLocation()+locationLength,
			getColor(),
			thinkness);
		SpriteLand->drawLine(
			getXLocation(),
			getYLocation(),
			getXLocation()-locationLength,
			getYLocation()+locationLength,
			getColor(),
			thinkness);
		SpriteLand->drawLine(
			getXLocation(),
			getYLocation(),
			getXLocation(),
			getYLocation()-locationLength,
			getColor(),
			thinkness);
		SpriteLand->drawLine(
			getXLocation(),
			getYLocation()-locationLength,
			getXLocation()+locationLength,
			getYLocation()+locationLength,
			getColor(),
			thinkness);
		SpriteLand->drawLine(
			getXLocation(),
			getYLocation()-locationLength,
			getXLocation()-locationLength,
			getYLocation()+locationLength,
			getColor(),
			thinkness);
		SpriteLand->drawLine(
			getXLocation()-locationLength,
			getYLocation()+locationLength,
			getXLocation()+locationLength,
			getYLocation()+locationLength,
			getColor(),
			thinkness);
		SpriteLand->drawCircle(getXLocation(), getYLocation(),radius_,getColor());

		return true;
	}
	
	virtual void onKeyDown (int keyValue)
	{
		switch (keyValue)
		{
		case 'u':
			// reverse diection
			setRotationalVelocity(
				getRotationalVelocity()*(-1)); 
			break;
		case 'a':		
			// accelerate by 10%
			setVelocityInPixelsPerSecond(
				getXVelocityInPixelsPerSecond()*(1.1),
				getYVelocityInPixelsPerSecond()*(1.1)
				);		
			break;
		case 'd':
			// decelerate by 10%
			setVelocityInPixelsPerSecond(
				getXVelocityInPixelsPerSecond()*(0.9),
				getYVelocityInPixelsPerSecond()*(0.9)
				);
			break;
		case 'b':
			// turn blue
			setColor(0,0,255);
			break;
		case 'j':
			// rotate left 45 degree
			setRotation(
				getRotation()-45);
			break;
		case 'k':
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
			// if not stopped
		{
			old_X_Vel_ = getXVelocityInPixelsPerSecond();
			old_Y_Vel_ = getYVelocityInPixelsPerSecond();
			old_RA_Vel_  = getRotationalVelocity();
			setRotationalVelocity(0);
			setVelocityInPixelsPerSecond(0,0);
			isStopped_ = true;

		}

		else if (isStopped_ == true) 
			// if stopped
		{
			setRotationalVelocity(old_RA_Vel_);
			setVelocityInPixelsPerSecond(old_X_Vel_,old_Y_Vel_);
			isStopped_ = false;
		}

	}

	virtual Spaceship* clone() const
	{
		return new Spaceship(*this);
	}

private:
	int old_X_Vel_;
	int old_Y_Vel_;
	int old_RA_Vel_;
	bool isStopped_;

};
}
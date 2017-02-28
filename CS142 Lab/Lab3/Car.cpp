// Yu Fu
// Lab 3- car string
#include "Car.h"

Car::Car ( const char* maker, const char* model, const char* license, const char* firstName, const char* lastName, int year) :
	year_(year)
{
	// allocate information all those things can be copied back
	maker_ = allocateAndCopy(maker);
	model_ = allocateAndCopy(model);
	license_ = allocateAndCopy(license);
	firstName_ = allocateAndCopy(firstName);
	lastName_ = allocateAndCopy(lastName);
}
Car::~Car ()
{
	delete [] maker_;
	delete [] model_;
	delete [] license_;
	delete [] firstName_;
	delete [] lastName_;
	year_ = 0;
}

void Car::print()	// print function
{
	cout << maker_<<", "<<model_<<". "<<license_<<", "
		<< lastName_<<", "<<firstName_<<". "<<year_ <<endl;
}

int Car::getYear()	//year return database[i].year_
{
	return year_;
}

bool Car::isEqual(const Car& thingToCompare) const
{
	const char* firstPtr = lastName_;
	const char* secondPtr = 
		thingToCompare.lastName_;

	while(*firstPtr != 0 && 
		*firstPtr == *secondPtr)
	{
		++firstPtr;
		++secondPtr;
	}

	return *firstPtr == *secondPtr;
}

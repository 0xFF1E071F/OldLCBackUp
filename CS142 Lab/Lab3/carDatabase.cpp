// Yu Fu

#include "carDatabase.h"


void CarDatbase::addCar(const char* maker, const char* model, const char* license, const char* firstName, const char* lastName, int year):
	year_(year)
{
	maker_ = allocateAndCopy(maker);
	model_ = allocateAndCopy(model);
	license_ = allocateAndCopy(license);
	firstName_ = allocateAndCopy(firstName);
	lastName_ = allocateAndCopy(lastName);

	database[nCarsInDB] = new Car ( maker_ , model_,license_, firstName_ , lastName_, year_ );
	++nCarsInDB;
}

void CarDatbase::lookupByLastname(const char* nameToFind)
{
	Car searchCar (nameToFind,nameToFind,nameToFind,nameToFind,nameToFind,1);

	for (int i=0;i<nCarsInDB;i++)
	{
		if (database[i]->isEqual(searchCar)) // compare name 
		{ 
			database[i]->print();	//print
		}
	}
}

void CarDatbase::lookupByYear(int yearToFind)
{
	for(int i=0;i<nCarsInDB;i++)
	{
		if (database[i]->getYear() == yearToFind) // if same
		{
			database[i]->print();	//print
		}
	}
}
// Yu Fu
// Lab 3- car class

#pragma once
#include <iostream>
using namespace std;
#include "Car.h"

char* allocateAndCopy(const char* original)
{
	// Find the length of original
	int length = strlen(original);

	// Allocate memory to hold a copy
	char* copy = new char[length+1];

	char* ptr = copy;
	while(*original != 0)
	{
		*ptr = *original;
		ptr++;
		original++;
	}
	*ptr = 0;

	// return the address of the newly allocated memory
	// The caller is responsible for deallocating memory
	//   This is generally not a good practice.
	return copy;
}

class Car
{
public:
	// Create a new car with number and street name
	// Constructors
	Car ();
	Car (const char* maker, const char* model, 
			const char* license, const char* firstName, 
			const char* lastName, int year = 0);
	Car (const Car&);

	// Destroy a carDatebase
	// The one and only Destructor
	~Car();

	// information constructors
	const char* maker () const {return maker_;}
	const char* model () const {return model_;}
	const char* license() const {return license_;}
	const char* firstName() const {return firstName_;}
	const char* lastName() const {return lastName_; }
	int year() const {return year_; }

	void print (); // print information
	int getYear(); // get year of each car database
	bool isEqual(const Car& thingToCompare) const;

private:
	//members
	char* maker_;
	char* model_;
	char* license_;
	char* firstName_;
	char* lastName_;
	int year_;
};
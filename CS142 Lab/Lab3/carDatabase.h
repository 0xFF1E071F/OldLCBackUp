#pragma once

#include <iostream>
using namespace std;
#include "Car.h"

class CarDatbase
{
public:
	void addCar(const char* maker, const char* model, 
		const char* license, const char* firstName, 
		const char* lastName, int year);
	void lookupByLastname(const char* nameToFind);
	void lookupByYear(int yearToFind);
	
private:
	int MAX_CARS_IN_DB = 150;
	int nCarsInDB = 0; // from first
	Car* database[MAX_CARS_IN_DB]; //set database

	char* maker_;
	char* model_;
	char* license_;
	char* firstName_;
	char* lastName_;
	int year_;
};

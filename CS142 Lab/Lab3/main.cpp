// Yu Fu
// Lab 3-  Car main

#include <iostream>
using namespace std;

#include "Car.h"
#include "carDatabase.h"

void main()
{
	//sets
	int commandEnter = 0;  
	const int MAX_STRING_LENGTH = 128;
	const int MAX_CARS_IN_DB  = 128;
	//input
	char makerCin[MAX_STRING_LENGTH], 
		 modelCin[MAX_STRING_LENGTH],
		 numberCin[MAX_STRING_LENGTH],
		 firstNameCin[MAX_STRING_LENGTH],
		 lastNameCin[MAX_STRING_LENGTH];
	int yearCin;
	//search
	char serachName[MAX_STRING_LENGTH];
	int searchYear;
	
	Car* database[MAX_CARS_IN_DB]; //set database
	int nCarsInDB = 0; // from first

	while( commandEnter != 4 ) // loop until exit = 4
	{
		// Directions
		cout<< "1.)	Add an entry"<<endl;
		cout<< "2.)	Lookup using last name"<<endl;
		cout<< "3.)	Lookup using year"<<endl;
		cout<< "4.)	Quit"<<endl;
		cout<<"Enter your command: "; 

		cin >> commandEnter;  // enter order
		
		if (commandEnter  ==1)				// if input information
		{
			cout<< "Maker: "; cin >> makerCin; 
			cout<< "Model: "; cin >> modelCin; 
			cout<< "License plate number: "; cin >> numberCin; 
			cout<< "Owner's first name: "; cin >> firstNameCin; 
			cout<< "Owner's last name: "; cin >> lastNameCin;
			cout<< "Year: "; cin >> yearCin ; 
			database[nCarsInDB] = new Car ( makerCin , modelCin,numberCin, firstNameCin , lastNameCin, yearCin );
			++nCarsInDB;
		}
		else if (commandEnter ==2)			// if find information depends on name
		{
			cout<<"Enter last name: ";  cin >>serachName;
			Car searchCar (serachName,serachName,serachName,serachName,serachName,1);

			for (int i=0;i<nCarsInDB;i++)
			{
				if (database[i]->isEqual(searchCar)) // compare name 
				{ 
					database[i]->print();	//print
				}
			}

		}
		else if (commandEnter ==3)			// if find information depends on year
		{
			cout<<"Enter year: ";  cin >> searchYear;

			for(int i=0;i<nCarsInDB;i++)
			{
				if (database[i]->getYear() == searchYear) // if same
				{
					database[i]->print();	//print
				}
			}

		}
	}

}

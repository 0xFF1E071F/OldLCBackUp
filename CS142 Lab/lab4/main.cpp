#include<iostream>
using namespace std;
#include "FloatArray.h"

void main()
{
	FloatArray myArray_pushback;
	myArray_pushback.push_back(1);
	myArray_pushback.push_back(2);
	myArray_pushback.push_back(3);
	cout<< myArray_pushback<<endl;

	FloatArray myArray_pushfront;
	myArray_pushfront.push_front(3);
	myArray_pushfront.push_front(2);
	myArray_pushfront.push_front(1);
	cout<< myArray_pushfront<<endl;

	system("pause");
}
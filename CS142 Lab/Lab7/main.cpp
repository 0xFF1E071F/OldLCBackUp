#include<iostream>
#include "Vector.h"
#include "Collection.h"

using namespace std;

int main()
{
	Collection<string> charCollection;
	charCollection.addThing("aasd");
	cout<< charCollection<<endl;
}
#include <iostream>
#include <string>
#include <fstream>
#include <stdio.h>
#include <ctype.h>
#include <cstdio>
#include <stdlib.h> 
#include <cstring>
#include <vector>
#include <list>
#include "Acmp.h"
#include "A.h"
#include "LCMap.h"
using namespace std;

int main()
{

	
	
	LCMap<int, int> a;
	if (a.in(1))
		cout << "bad" << endl;
	a.insert(1,4);
	if (a.in(1))
		cout << "good" << endl;
	a.insert(2,3);
	if (a.in(3))
		cout << "bad" << endl;
	a[1]= 5;
	cout << a[2] << endl;
	cout << a[1] << endl;
	cout << a.size() << endl;
	if (a.erase(2))
		cout << "IT WORKED!!!!!!!!!!!!@!@!!!!@!!" << endl;
	if (a.in(2))
		cout << "bad" << endl;
	cout << a.size() << endl;
	cout << a[1] << endl;
	cout << a[2] << endl;
	a[2] = 10;
	if (a.insert(2,11))
		cout <<  "VICTORY" << endl;
	
	LCMap <int, int> b;
	b.insert(6,1);
	b.insert(9,2);
	b.insert(11,3);
	b.insert(7,4);
	b.insert(10,5);
	b.insert(4,6);
	b.insert(5,7);
	b.insert(1,8);
	if (b.in(9))
		cout << "good" << endl;
	cout << "size " << b.size() << endl;
	if (b.erase(4))
		cout << "IT WORKED!!!!!!!!!!!!@!@!!!!@!!" << endl;
	cout << "size " << b.size() << endl;
	cout << b[6] << endl;
	cout << b[1] << endl;
	cout << b[5] << endl;
	
	b.insert(12,9);
	cout << "size " << b.size() << endl;
	if (b.erase(9))
		cout << "IT WORKED!!!!!!!!!!!!@!@!!!!@!!" << endl;
		cout << "size " << b.size() << endl;
	cout << b[11] << endl;
	cout << b[7] << endl;
	cout << b[10] << endl;
	cout << b[12] << endl;

	cout << "size " << b.size() << endl;
	b.erase(1);
	cout << "size " << b.size() << endl;
	list<int> c;
	c = b.keys();
	a = b;
	cout << "a.size " << b.size() << endl;
	cout << "b.size " << b.size() << endl;
	a.insert(24,8);
	a.insert(70,0);
	b.insert(89,1);
	cout << "a size " << a.size() << endl;
	cout << "b size " << b.size() << endl;
	b.clear();
	//for(list<int>::const_iterator i = c.begin(); i != c.end(); i++)
		//b.erase(*i);
	cout << b.size() << endl;
	c = b.keys();	
	cout << c.size() << endl;
	LCMap<int, int> x(a);
	cout << "xsize " << x.size() << endl;
	cout << x[24] << endl;
	LCMap<A, int, Acmp> d;
	A ff(5);
	A dd(6);
	
	A zz(2);
	A ss(1);
	A aa(3);
	A vv(9);
	d.insert(ff,1);
	d.insert(dd,2);
	d.insert(zz,3);
	d.insert(ss,4);
	d.insert(aa,5);
	d.insert(vv,6);
	if (d.in(dd))
		cout << "good" << endl;
	return 0;
}
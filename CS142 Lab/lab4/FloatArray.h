#pragma once

class FloatArray
{
public:        
	FloatArray();
	FloatArray (int dimension, float initialElementValue);
	FloatArray (const FloatArray& thing);
	~FloatArray();  // deallocate

	int dimension (){return dimension_;};

	//operator
	float & operator[] (int index);
	const float& operator[](int index) const ;


	bool operator == (const FloatArray& rhs) const; // same
	bool operator < (const FloatArray& rhs) const;  // less
	bool operator > (const FloatArray& rhs) const;  // larger
	bool operator <= (const FloatArray& rhs) const; // less equal
	bool operator >= (const FloatArray& rhs) const; // larger equal
	bool operator != (const FloatArray& rhs) const; // not equal
	bool operator = (const FloatArray& rhs) const;  // equal
	bool operator + (const FloatArray& rhs) const;  // plus

	//push
	void push_back (const float &newThing);
	void push_front (const float& newThing);

	void print (std::ostream& out ) const; // print

private:
	int dimension_;
	float* theArray_;
};

ostream& operator << (ostream& out ,const FloatArray&thingToPrint);
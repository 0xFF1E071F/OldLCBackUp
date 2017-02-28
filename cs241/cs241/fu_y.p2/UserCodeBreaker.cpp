/* Yu Fu partner: Will Foley
	UserCodeBreaker.h
*/

#include "UserCodeBreaker.h"
UserCodeBreaker::UserCodeBreaker(size_t range,size_t length)
{
	range_=range;
	length_=length;
}


string UserCodeBreaker::nextGuess() const
{
	size_t guessLast=0;
	size_t guessFirst=0;
	size_t guessRangeLast;
	int guessRangeFirst;
	string guess;
	//enter
	while(guess.size() != length_||range_ < guessRangeLast||guessRangeFirst < 1)
	{
		cout<<"Please enter your guess: ";

		cin>>guess;
		//get the last letter
		for(size_t i =0;i<guess.size();i++)
		{
			if (guess[i]>guess[guessLast])
			{
				guessLast=i;
			}
			else if (guess[i]<guess[guessFirst])
			{
				guessFirst=i;
			}
		}
		guessLast=guess[guessLast];
		guessFirst=guess[guessFirst];
		guessRangeLast = guessLast-96;//first 'a' is 97 in ascii
		guessRangeFirst = guessFirst-96;
		if (guess.size() != length_)
		{
			cout<<"you type in a error length guess"<<endl;
		}
		else if(range_ < guessRangeLast)
		{
			cout<<"you type in a error range guess"<<endl;
		}
		else if (guessRangeFirst < 1)
		{
			cout<<"you type in a guess with letters from a"<<endl;
		}
	}
	return guess;
}

void UserCodeBreaker::guessResults(std::string guess, size_t bulls, size_t cows)
{
	if(bulls==guess.size() && cows==0)
	{
		cout<<"You guess has ["<<bulls<<"] Bulls & ["<<cows<<"] cows."<<endl;
		cout<<"You make a correct guess!"<<endl;
	}
	else
	{
		// print wrong result
		cout<<"You didn't get the correct guess."<<endl;
		cout<<"You guess has ["<<bulls<<"] Bulls & ["<<cows<<"] cows."<<endl;
	}
}

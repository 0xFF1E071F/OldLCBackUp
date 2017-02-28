/* Yu Fu partner: Will Foley
	ComputerCodebreaker.cpp
*/
#include "ComputerCodeBreaker.h"
ComputerCodeBreaker::ComputerCodeBreaker(size_t range,size_t length)
{
	range_=range;
	length_=length; 
	initAllCodes();	//initilization of all codes
	allCodeSize_=0; //all code size
}
string ComputerCodeBreaker::nextGuess() const
{
	//list<string>::const_iterator first = codeList_.begin();
	//string code = *first;

	return getBestCode();//return first in codeList_
}


list<string> ComputerCodeBreaker::potentialCodes (string guess,size_t bulls, size_t cows) const
{
	// set tmp bulls cows
	size_t tmpBulls;
	size_t tmpCows;
	//new list tmp
	list<string> tmpList;
	list<string>::const_iterator cursor = codeList_.begin();
	
	while(cursor!=codeList_.end())
	{
		// default always be 0
		tmpBulls=0;
		tmpCows=0;
		if(*cursor!=guess){// if not same code
			Mastermind::compareCodes(guess,*cursor,tmpBulls,tmpCows);
			if(tmpBulls==bulls && tmpCows==cows)	// if  better
				tmpList.push_back(*cursor);
		}
		//next code in list
		++cursor;
	}
	
	return tmpList;	// return this new list
}

void ComputerCodeBreaker::guessResults(std::string guess, size_t bulls, size_t cows)	// give out result of guess
{
	if(bulls==guess.size() && cows==0)	//if correct guess
	{
		cout<<"You guess has ["<<bulls<<"] Bulls & ["<<cows<<"] cows."<<endl;
		cout<<"You make a correct guess!"<<endl;

	}
	else	// if make wrong guess, narrow potential Codes list (codeList_)
	{
		//codeList_.clear();
		codeList_=potentialCodes(guess,bulls,cows);
		// print wrong result	
		cout<<"You guess has ["<<bulls<<"] Bulls & ["<<cows<<"] cows."<<endl;//
		cout<<"You didn't get the correct guess."<<endl;
	}
	
}

// get the best code 
string ComputerCodeBreaker::getBestCode() const	
{
	string bestCode;	// this is the best code will be return
	//bull and cows result
	size_t bulls;
	size_t cows;
	// for each score
	size_t minScore;	// minScore for each code
	size_t score;		
	size_t bestScore =0; // Largest Score from all minScores
	if (allCodeList_.size()==codeList_.size())	// if just begin, bestCode ="aabbcc..."
	{
		//the "aabbcc..."
		size_t currentRange=0;
		string firstTmp;
		for(size_t i=0;i<length_;i++)	// set up 'aabbcc...'
		{
			if(i%2==0&&i!=0)
			{
				currentRange+=1;
			}
			if(currentRange>=range_)
			{
				currentRange=0;
			}
			firstTmp.push_back('a'+currentRange);
		}
		bestCode=firstTmp;
	}
	else if (codeList_.size()==1)	// if only one int the pontenital code list, it muse be answer
	{
		bestCode=*(codeList_.begin());	//just return it
	}
	else 	// if not get the correct yet
	{
		// this is a cursor for all code list
		for(list<string>::const_iterator codeCursor = allCodeList_.begin(); codeCursor != allCodeList_.end(); ++codeCursor) // for each code
		{
			minScore = codeList_.size();//minScore as same as all pontential code limit
			//for each posible bulls and cows, 00 01 02 03..10 11 12..
			for(size_t cmpBull=0;cmpBull<=length_;cmpBull++)
			{
				for(size_t cmpCow=0;(cmpCow+cmpBull)<=length_;cmpCow++)
				{
					score=0;
					for(list<string>::const_iterator j = codeList_.begin(); j != codeList_.end(); ++j)	// for each pontential code
					{
						bulls=0;
						cows=0;
						Mastermind::compareCodes(*codeCursor,*j,bulls,cows);
						if (cmpBull != bulls || cmpCow != cows)
						{						
							score++;
						}
					}
					if (score<minScore) // find the minScore from all scores
					{
						minScore=score;	// save the minScore
					}
				}
			}
			if (minScore>bestScore)	//find the largest score from all code minScore
			{
				bestScore=minScore;
				bestCode=*codeCursor;	// make a copy of the first one which has the largest score
			}
		} 
	}
	return bestCode; //return the best code
}

//initiliza two code lists
void ComputerCodeBreaker::initAllCodes()
{
	allCodeSize_= pow(range_, length_);	// get total number of possible
	string tmp;
	for(size_t i = 0; i < allCodeSize_; ++i)	// set all code from 'aaa...' to 'range_....'
	{
		tmp.clear();
		for(int j=length_-1;j>=0;j--)		// for each length
		{
			int curRange=(i/static_cast<int>(pow(range_, j)))%range_;//each position range 0-range_
			tmp.push_back('a'+curRange);
		}
		
		codeList_.push_back(tmp); // push in potential code list
		allCodeList_.push_back(tmp); //push in all code list
	}

}
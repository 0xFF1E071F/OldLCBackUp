/* Yu Fu partner: Will Foley
	ConsoleInterface.cpp
*/
#include "ConsoleInterface.h"
 
// takes control of game from the main(...)
void ConsoleInterface::start()
{
	// title
	cout<<"****************************************"<<endl;
	cout<<"*              Mastermind              *"<<endl;
	cout<<"****************************************"<<endl;
	cout<<"1 retuen Player VS. Player"<<endl;
	cout<<"2 retuen Player VS. Computer"<<endl;
	cout<<"3 retuen Computer VS. Computer"<<endl;
	cout<<"Type in Game Mode: ";
	int gameMode;
	cin>>gameMode;//choose game mode
	//print game mode
	switch (gameMode)
	{
	case 1:
		cout<<endl<<"< You are playing in a Player VS. Player mode >"<<endl<<endl;	break;
	case 2:
		cout<<endl<<"< You are playing in a Player VS. COM mode >"<<endl<<endl;	break;
	case 3:
		cout<<endl<<"< You are playing in a COM VS. COM mode >"<<endl<<endl;	break;
	default:
		cout<<"Please type correct game mode. Start game again."<<endl;	break;
	}
	// Enter length and range
	size_t length=0;
	size_t range=0;
	string lengthSize;
	string rangeSize;
	// check enter with gamemode
	if (gameMode==1||gameMode==2||gameMode==3)
	{
		while(length==0) //until get a correcct lentgh
		{
			size_t i=0;
			cout<<"Maker enter the length of code: ";cin>>lengthSize;
			while(i < lengthSize.size()-1 && isdigit(lengthSize[i]))
			{
				i++;
			}
			if (!isdigit(lengthSize[i]))
			{
				cout<<"Please type in a correnct number of length!"<<endl;
			}
			else
			{
				int tmp =atoi(lengthSize.c_str());
				length = tmp;	
			}
		}
		//check range, valid or not
		while(range==0 || range >26)
		{
			size_t i=0;
			cout<<"Maker enter the range of code: ";cin>>rangeSize;
			while(i < rangeSize.size()-1 && isdigit(rangeSize[i]))
			{
				i++;
			}
			if (!isdigit(rangeSize[i]))
			{
				cout<<"Please type in a correnct number of range!"<<endl;
			}
			else
			{
				int tmp=atoi(rangeSize.c_str());
				range = tmp;
			}
		}
	}

	switch (gameMode)	// set up game for each mode
	{
	case 1:	// player vs player
		{
			//set up
			CodeMakerIF* codeMakerIF  = new UserCodeMaker(range,length);
			CodeBreakerIF* codeBreakerIF = new UserCodeBreaker(range,length);
			
			play(codeBreakerIF,codeMakerIF);
			break;
		}
	case 2:	//player vs com
		{
			//set up
			CodeMakerIF* codeMakerIF = new UserCodeMaker(range,length);
			CodeBreakerIF* codeBreakerIF = new ComputerCodeBreaker(range,length);
		
			play(codeBreakerIF,codeMakerIF);	
			break;
		}
	case 3:	//com vs com
		{
			//set up
			CodeMakerIF* codeMakerIF = new ComputerCodeMaker(range,length);
			CodeBreakerIF* codeBreakerIF = new ComputerCodeBreaker(range,length);
			
			play(codeBreakerIF,codeMakerIF);
			break;
		}
	}

}

//start to play
void ConsoleInterface::play(CodeBreakerIF* codeBreaker, CodeMakerIF* codeMaker)
{
	size_t bulls;
	size_t cows;
	cout<<"Maker a Code: ";
	string code = codeMaker-> generateCode();	// make maker code
	
	for(int i=0;i<5;i++)	//just give some blank space to hindden the maker code,, there set 5 easy to check 
		cout<<endl;
		
	size_t length= code.size();
	//check breaker code valid and get guess result
	while(bulls!=length)	// until get the correct guess
	{
		// always sets to 0
		bulls=0;
		cows=0;
		
		string guess=codeBreaker->nextGuess();	// get guess
		cout<<"Guess: "<<guess<<endl;
		Mastermind::compareCodes(guess,code,bulls,cows);// compare guess and code
		codeBreaker->guessResults(guess,bulls,cows);	//give result
		cout<<endl;
	}
	
	
}
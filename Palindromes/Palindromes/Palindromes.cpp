// Palindrome.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include "myStack.h"
#include "queueAsArray.h"
#include "pch.h"
#include <iostream>
#include<istream>
using namespace std;

int main()
{
	char x[50];
	cout << "Enter line of text" << endl << endl;
	cin.getline(x, 256, '\n');
	char stack[50];
	char que[50];
	cout << x;
	_strlwr_s(x);
	int length = strlen(x);
	length--;
	int y = 0;
	int z = length;
	int c = 0;
	int a = 0;

	while (z >= 0)
	{

		if (x[c] > 96 && x[c] < 124)
		{
			stack[y] = x[c];
			y++;
		}
		if (x[z] > 96 && x[z] < 124)
		{
			que[a] = x[z];
			a++;
		}
		c++;
		z--;
	}
	stack[y] = '\0';
	que[y] = '\0';

	length = strlen(stack);
	length--;
	z = 0;
	bool found = true;


	while (found == true && length >= 0)
	{
		if (stack[z] != que[z])
		{
			found = false;
		}
		z++;
		length--;
	}

	if (found == false)
	{
		cout << " is not a palindrome" << endl;
	}
	else
	{
		cout << " is a palindrome" << endl;
	}
	return 0;
}

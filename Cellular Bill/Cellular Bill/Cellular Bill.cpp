/* Name Of Program: Cellular Bill.cpp
 Name: Jessica Alexander
 Date: 01/24/2019
 Chapter: 3 */

#include "pch.h"
#include <iostream>
#include <string>
#include<iomanip>

using namespace std;

const double Res_CellService_Fee = 10.00;
const double Res_CellService_Rate = 0.20;
const double Prem_CellService_Fee = 25.00;
const double Prem_CellService_Day_Rate = 0.10;
const double Prem_CellService_Night_Rate = 0.05;

int main()
{
	string accountNum;
	int valid = 1;
	char customerType;
	double dayDue = 0;
	double nightDue = 0;
	double MinutesUsed = 0;
	double premiumDayMinutesUsed = 0;
	double premiumNightMinutesUsed = 0;
	double amountDue = 0;

	cout << fixed << showpoint;
	cout << setprecision(2);
	cout << "This program program calculates and prints a cellular bill" << endl;
	cout << endl;
	cout << "Please enther the account number: ";
	cin >> accountNum;
	cout << endl;

	while (valid == 1)
	{
		cout << "Enter the customer type: "
			<< "R or r (Residential), "
			<< "P or p (Premium) ";
		cin >> customerType;
		if (customerType == 'r' || customerType == 'R' || customerType == 'p' || customerType == 'P')
			valid = 0;
		else
		{
			cout << endl << "Invalid service code! Try again.";
		}
		cout << endl;
		{
			if (customerType == 'r' || customerType == 'R')
			{
				cout << "Please enter the number of minutes used: ";
				cin >> MinutesUsed;
				amountDue = Res_CellService_Fee;
				if (MinutesUsed > 50)
				{
					amountDue = ((MinutesUsed - 50) * Res_CellService_Rate) + Res_CellService_Fee;
				}
			}
			if (customerType == 'p' || customerType == 'P')
			{
				cout << "Please enter the number of day minutes used: ";
				cin >> premiumDayMinutesUsed;
				cout << "Please enter the number of night minutes used: ";
				cin >> premiumNightMinutesUsed;
				amountDue = Prem_CellService_Fee;
				dayDue = nightDue = 0.00;
				MinutesUsed = premiumDayMinutesUsed + premiumNightMinutesUsed;
				if (premiumDayMinutesUsed > 75)
				{
					dayDue = (premiumDayMinutesUsed - 75) * Prem_CellService_Day_Rate;
				}
				if (premiumNightMinutesUsed > 100);
				{
					nightDue = (premiumNightMinutesUsed - 100) * Prem_CellService_Night_Rate;
				}
				amountDue = amountDue + dayDue + nightDue;
			}
			if (valid != 1)
			{
				cout << endl << "Account Number:" << accountNum;
				if (customerType == 'r' || customerType == 'R')
					cout << endl << "Type of Customer:" << "Regular";
				else
				{
					cout << endl << "Type of Customer:" << "Premium";
				}
				cout << endl << "Number of minutes used: " << MinutesUsed << endl;
				cout << "Number of Minutes during the day: " << premiumDayMinutesUsed << endl;
				cout << "Number of Minutes during the evening: " << premiumNightMinutesUsed << endl;
				cout << "Amount due for day: $" << dayDue << endl;
				cout << "Amount due for evening: $" << nightDue << endl;
				cout << "Amount due: $" << amountDue << endl;
				return 0;
			}
		}
		
	}
}
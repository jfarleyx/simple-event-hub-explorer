# simple-event-hub-explorer
Simple Event Hub Explorer was created to assist developers or testers with quickly and easily reviewing data payloads in an Azure Event Hub. Event Hub messages are shown in a textbox on the form. 

<img width="526" alt="screenshot" src="https://user-images.githubusercontent.com/7269437/30768825-a892ca98-9fd3-11e7-934d-0a4a72882a78.png">

## Features
* Send message to an Azure Event Hub
* Read messages from an Azure Event Hub

## Build
This project was built using Visual Studio 2017 and .NET Framework 4.6.1. 

## Get Started
After downloading and building the project you can run it via SimpleExplorer/bin/Release/SimpleExplorer.exe

To send or read messages you must provide the following information. This information can be found in the Azure portal. 
* Event Hub Connection String (Note: requires a shared access key with Manage permissions)
* Event Hub Entity Path

To read messages also requires an Azure Storage Account. The storage account is used to track message offsets and avoid reading the same data multiple times. Please provide the following information, which can be found in the Azure portal.
* Storage Account Name
* Storage Container name
* Storage Account Key

If you would prefer not to re-enter your connection settings each time you run the app, then simply open the App.config and add your connection settings to the appropriate keys in the appSettings area of the configuration file. Then, when the app starts it will automatically load those settings into the form. 



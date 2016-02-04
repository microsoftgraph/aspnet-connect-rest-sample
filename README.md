# Office 365 Connect ASP.NET MVC sample using Microsoft Graph

Connecting to Office 365 is the first step every app must take to start working with Office 365 services and data. This sample shows how to connect and use Microsoft Graph (previously called Office 365 unified API) to send an email. It uses [Active Directory Authentication Library](https://msdn.microsoft.com/en-us/library/azure/jj573266.aspx) to make OAuth2 call.

> Note: To understand the code for calling the Microsoft Graph API in an ASP.NET MVC app, see [Call Microsoft Graph in an ASP.NET MVC app] (https://graph.microsoft.io/en-us/docs/platform/aspnetmvc).

![Office 365 ASP.NET MVC sample screenshot](./README assets/O365AspNetMVCSendMailPageScreenshot.png)

## Prerequisites

Try out the [Get started with Office 365 APIs](http://dev.office.com/getting-started/office365apis?platform=option-dotnet#setup) page which simplifies registration so you can get this sample running faster.

To use the Office 365 ASP.NET MVC Connect sample, you need the following:
* Visual Studio 2015 installed and working on your development computer. 

     > Note: This sample is written using Visual Studio 2015. If you're using Visual Studio 2013, make sure to change the compiler language version to 5 in the Web.config file:  **compilerOptions="/langversion:5**
* An Office 365 account. You can sign up for [an Office 365 Developer subscription](https://portal.office.com/Signup/Signup.aspx?OfferId=6881A1CB-F4EB-4db3-9F18-388898DAF510&DL=DEVELOPERPACK&ali=1#0) that includes the resources that you need to start building Office 365 apps.

     > Note: If you already have a subscription, the previous link sends you to a page with the message *Sorry, you can’t add that to your current account*. In that case use an account from your current Office 365 subscription.
* A Microsoft Azure tenant to register your application. Azure Active Directory (AD) provides identity services that applications use for authentication and authorization. A trial subscription can be acquired here: [Microsoft Azure](https://account.windowsazure.com/SignUp).

     > Important: You also need to make sure your Azure subscription is bound to your Office 365 tenant. To do this, see the Active Directory team's blog post, [Creating and Managing Multiple Windows Azure Active Directories](http://blogs.technet.com/b/ad/archive/2013/11/08/creating-and-managing-multiple-windows-azure-active-directories.aspx). The section **Adding a new directory** will explain how to do this. You can also see [Set up your Office 365 development environment](https://msdn.microsoft.com/office/office365/howto/setup-development-environment#bk_CreateAzureSubscription) and the section **Associate your Office 365 account with Azure AD to create and manage apps** for more information.
* A client ID and redirect URI values of an application registered in Azure. This sample application must be granted the **Send mail as signed-in user** permission for the **Microsoft Graph**. [Add a web application in Azure](https://msdn.microsoft.com/office/office365/HowTo/add-common-consent-manually#bk_RegisterWebApp) and [grant the proper permissions](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/wiki/Grant-permissions-to-the-Connect-application-in-Azure) to it.

     > Note: During the app registration process, make sure to specify **http://localhost:55065** as the **Sign-on URL**.  

## Configure and run the app
1. Open **UnifiedApiConnect.sln** file. 
2. In Solution Explorer, open the **Web.config** file. 
3. Replace *ENTER_YOUR_CLIENT_ID* with the client ID of your registered Azure application.
4. Replace *ENTER_YOUR_SECRET* with the key of your registered Azure application.
3. Press F5 to build and debug. Run the solution and sign in to Office 365 with your organizational account.

     > Note: Copy and paste the start page URL address **http://localhost:55065/home/index**, to a different browser if you get the following error during sign in:**AADSTS70001: Application with identifier ad533dcf-ccad-469a-abed-acd1c8cc0d7d was not found in the directory**.

## Questions and comments

We'd love to get your feedback about the Office 365 365 ASP.NET MVC Connect sample. You can send your questions and suggestions to us in the [Issues](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/issues) section of this repository.

Questions about Office 365 development in general should be posted to [Stack Overflow](http://stackoverflow.com/questions/tagged/Office365+API). Make sure that your questions or comments are tagged with [Office365] and [MicrosoftGraph].
  
## Additional resources

* [Microsoft Graph documentation](http://graph.microsoft.io)
* [Microsoft Graph API References](http://graph.microsoft.io/docs/api-reference/v1.0)


## Copyright
Copyright (c) 2015 Microsoft. All rights reserved.

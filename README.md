# Microsoft Graph Connect Sample for ASP.NET 4.6 (REST)

## Table of contents

* [Introduction](#introduction)
* [Prerequisites](#prerequisites)
* [Register the application](#register-the-application)
* [Build and run the sample](#build-and-run-the-sample)
* [Deploy the sample to Azure](#deploy-the-sample-to-azure)
* [Code of note](#code-of-note)
* [Questions and comments](#questions-and-comments)
* [Contributing](#contributing)
* [Additional resources](#additional-resources)

## Introduction

This sample shows how to connect an ASP.NET 4.6 MVC web app to a Microsoft work or school (Azure Active Directory) or personal (Microsoft) account using the Microsoft Graph API to send an email. It uses REST calls to interact with the Microsoft Graph API.

In addition, the sample uses the [Microsoft Authentication Library (MSAL)](https://www.nuget.org/packages/Microsoft.Identity.Client/) for authentication. The MSAL SDK provides features for working with the [v2 authentication endpoint](https://azure.microsoft.com/en-us/documentation/articles/active-directory-appmodel-v2-overview), which enables developers to write a single code flow that handles authentication for both work or school and personal accounts.

 > **Note** The MSAL SDK is currently in prerelease, and as such should not be used in production code. It is used here for illustrative purposes only.

## Prerequisites

This sample requires the following:  

  * [Visual Studio 2015](https://www.visualstudio.com/en-us/downloads) 
  * Either a [Microsoft account](https://www.outlook.com) or [work or school account](https://dev.office.com/devprogram)

## Register the application

1. Sign into the [Application Registration Portal](https://apps.dev.microsoft.com/) using either your personal or work or school account.

2. Choose **Add an app**.

3. Enter a name for the app, and choose **Create application**. 
	
   The registration page displays, listing the properties of your app.

4. Copy the Application Id. This is the unique identifier for your app. 

5. Under **Application Secrets**, choose **Generate New Password**. Copy the password from the **New password generated** dialog.

   You'll use the application ID and password (secret) to configure the sample app in the next section. 

6. Under **Platforms**, choose **Add Platform**.

7. Choose **Web**.

8. Make sure the **Allow Implicit Flow** check box is selected, and enter *http://localhost:55065/* as the Redirect URI. 

   The **Allow Implicit Flow** option enables the hybrid flow. During authentication, this enables the app to receive both sign-in info (the id_token) and artifacts (in this case, an authorization code) that the app can use to obtain an access token.

9. Choose **Save**.

## Build and run the sample

1. Download or clone the Microsoft Graph Connect Sample for ASP.NET 4.6.

2. Open the sample solution in Visual Studio.

3. In the Web.config file in the root directory, replace the **ida:AppId** and **ida:AppSecret** placeholder values with the application ID and password that you copied during app registration.

4. Press F5 to build and run the sample. This will restore NuGet package dependencies and open the app.

   >If you see any errors while installing packages, make sure the local path where you placed the solution is not too long/deep. Moving the solution closer to the root of your drive resolves this issue.

5. Sign in with your personal or work or school account and grant the requested permissions.

6. Choose the **Get email address** button. When the operation completes, the email address of the signed-in user is displayed on the page.

7. Optionally edit the recipient list and email subject, and then choose the **Send email** button. When the mail is sent, a Success message is displayed below the button.

8. Next steps: Check out the [Microsoft Graph Snippets Sample for ASP.NET 4.6](https://github.com/microsoftgraph/aspnet-snippets-sample) to see examples of common Microsoft Graph operations.

## Deploy the sample to Azure

If you have an Azure subscription, you can publish the sample app to an Azure website. These instructions assume you've already [registered the sample app](#register-the-application) in the Application Registration Portal.

### Create a web app (website) in the Azure Portal

1. Sign into the [Azure Portal](https://portal.azure.com) with your Azure credentials.

2. Choose **New > Web + Mobile > Web App**.

3. Give the website a unique name. Choose a resource group, and click **Create**.

4. Select the new web app in your list of resources.

5. Choose **Overview** in the left-hand pane, and then choose **Get publish profile** (or **More > Get publish profile**) from the menu above the web app's Essentials pane. 

6. Save the profile locally.

### Publish the sample app from Visual Studio

1. In Visual Studio, open the sample app. Right-click the **Microsoft Graph REST ASPNET Connect** project node and choose **Publish**.

2. In the Publish dialog, choose **Import**, and choose the publish profile file you just downloaded. 

3. On the Connection tab of the Publish dialog, change the *http* protocol to *https* in the Destination URL of your new web app.

4. Copy the Destination URL, and and then click **Publish**. Close the browser window that opens.

5. In the Web.config file, replace the **ida:RedirectUri** value to the Destination URL that you just copied.

6. Choose **View > Other Windows > Web Publish Activity**. 

7. In the Web Publish Activity window, click the **Publish Web** button (looks like a globe) on the toolbar. This is how you can update the published project after you make changes.

### Update the redirect URI in the Application Registration Portal

1. In the [Application Registration Portal](https://apps.dev.microsoft.com), open the application that you registered for the sample (as described in [Register the application](#register-the-application)). 

2. In the Web platform section, replace the *http://localhost:55065/* Redirect URI with the Destination URL of your new web app. (Alternatively, you can click **Add Url** and add the Destination URL.)

3. Click **Save**.

The new Azure web app should now be ready to use.

## Code of note

- [Startup.Auth.cs](/Microsoft%20Graph%20REST%20ASPNET%20Connect/Microsoft%20Graph%20REST%20ASPNET%20Connect/App_Start/Startup.Auth.cs). Authenticates the current user and initializes the sample's token cache.

- [SessionTokenCache.cs](/Microsoft%20Graph%20REST%20ASPNET%20Connect/Microsoft%20Graph%20REST%20ASPNET%20Connect/TokenStorage/SessionTokenCache.cs). Stores the user's token information. You can replace this with your own custom token cache. Learn more in [Caching access tokens in a multitenant application](https://azure.microsoft.com/en-us/documentation/articles/guidance-multitenant-identity-token-cache/).

- [SampleAuthProvider.cs](/Microsoft%20Graph%20REST%20ASPNET%20Connect/Microsoft%20Graph%20REST%20ASPNET%20Connect/Helpers/SampleAuthProvider.cs). Implements the local IAuthProvider interface, and gets an access token by using the MSAL **AcquireTokenSilentAsync** method. You can replace this with your own authentication provider. 

- [GraphService.cs](/Microsoft%20Graph%20REST%20ASPNET%20Connect/Microsoft%20Graph%20REST%20ASPNET%20Connect/Models/GraphService.cs). Contains methods (called by HomeController) that build and send REST calls to the Microsoft Graph API, and process the response.
   - The **GetMyEmailAddress** action gets the email address of the current user from the **mail** or **userPrincipalName** property.
   - The **SendMail** action sends an email on behalf of the current user.

- [Graph.cshtml](/Microsoft%20Graph%20REST%20ASPNET%20Connect/Microsoft%20Graph%20REST%20ASPNET%20Connect/Views/Home/Graph.cshtml). Contains the sample's UI. 

## Questions and comments

We'd love to get your feedback about this sample. You can send us your questions and suggestions in the [Issues](https://github.com/microsoftgraph/aspnet-connect-rest-sample/issues) section of this repository.

Your feedback is important to us. Connect with us on [Stack Overflow](https://stackoverflow.com/questions/tagged/microsoftgraph). Tag your questions with [MicrosoftGraph].

## Contributing ##

If you'd like to contribute to this sample, see [CONTRIBUTING.md](CONTRIBUTING.md).

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Additional resources

- [Other Microsoft Graph Connect samples](https://github.com/MicrosoftGraph?utf8=%E2%9C%93&query=-Connect)
- [Microsoft Graph overview](https://graph.microsoft.io)

## Copyright
Copyright (c) 2016 Microsoft. All rights reserved.




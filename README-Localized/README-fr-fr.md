# Exemple de connexion d’ASP.NET MVC à Office 365 avec Microsoft Graph

La connexion à Office 365 est la première étape que chaque application doit suivre pour commencer à travailler avec les données et services Office 365. Cet exemple explique comment connecter et utiliser Microsoft Graph (anciennement appelé API unifiée Office 365) pour envoyer un courrier électronique. Il utilise [Active Directory Authentication Library](https://msdn.microsoft.com/fr-fr/library/azure/jj573266.aspx) pour appeler OAuth2.

> Remarque : pour mieux comprendre le code d’appel de l’API Microsoft Graph dans une application ASP.NET MVC, consultez l’article relatif à l’appel de Microsoft Graph dans une application ASP.NET MVC (https://graph.microsoft.io/fr-fr/docs/platform/aspnetmvc).

![Capture d’écran de l’exemple de connexion d’une application ASP.NET MVC à Office 365](../README assets/O365AspNetMVCSendMailPageScreenshot.png)

## Conditions requises

Consultez la page relative à la [prise en main des API Office 365](http://dev.office.com/getting-started/office365apis?platform=option-dotnet#setup) pour enregistrer plus facilement votre application et exécuter plus rapidement cet exemple.

Pour utiliser l’exemple de connexion d’ASP.NET MVC à Office 365, vous devez disposer des éléments suivants :
* Visual Studio 2015 installé et opérationnel sur votre ordinateur de développement. 

     > Remarque : cet exemple est écrit à l’aide de Visual Studio 2015. Si vous utilisez Visual Studio 2013, veillez à définir la version linguistique du compilateur sur 5 dans le fichier Web.config : **compilerOptions="/langversion:5**
* Un compte Office 365. Vous pouvez souscrire à [un abonnement Office 365 Développeur](https://aka.ms/devprogramsignup) comprenant les ressources dont vous avez besoin pour commencer à créer des applications Office 365.

     > Remarque : si vous avez déjà un abonnement, le lien précédent vous renvoie vers une page avec le message suivant : « Désolé, vous ne pouvez pas ajouter ceci à votre compte existant ». Dans ce cas, utilisez un compte lié à votre abonnement Office 365 existant.
* Un client Microsoft Azure pour enregistrer votre application. Azure Active Directory (AD) fournit des services d’identité que les applications utilisent à des fins d’authentification et d’autorisation. Un abonnement d’évaluation peut être demandé ici : [Microsoft Azure](https://account.windowsazure.com/SignUp).

     > Important : vous devez également vous assurer que votre abonnement Azure est lié à votre client Office 365. Pour cela, consultez le billet du blog de l’équipe d’Active Directory relatif à la [création et la gestion de plusieurs fenêtres dans les répertoires Azure Active Directory](http://blogs.technet.com/b/ad/archive/2013/11/08/creating-and-managing-multiple-windows-azure-active-directories.aspx). La section sur l’**ajout d’un nouveau répertoire** vous explique comment procéder. Pour en savoir plus, vous pouvez également consulter la rubrique relative à la [configuration de votre environnement de développement Office 365](https://msdn.microsoft.com/office/office365/howto/setup-development-environment#bk_CreateAzureSubscription) et la section sur l’**association de votre compte Office 365 à Azure Active Directory pour créer et gérer des applications**.
* Un ID client et des valeurs d’URI de redirection d’une application enregistrée dans Azure. Cet exemple d’application doit obtenir l’autorisation **Envoyer un courrier électronique en tant qu’utilisateur** pour **Microsoft Graph**. [Ajoutez une application web dans Azure](https://msdn.microsoft.com/office/office365/HowTo/add-common-consent-manually#bk_RegisterWebApp) et [accordez-lui les autorisations appropriées](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/wiki/Grant-permissions-to-the-Connect-application-in-Azure).

     > Remarque : pendant l’enregistrement de l’application, veillez à indiquer **http://localhost:55065** comme **URL d’authentification**.  

## Configuration et exécution de l’application
1. Ouvrez le fichier **UnifiedApiConnect.sln**. 
2. Dans l’Explorateur de solutions, ouvrez le fichier **Web.config**. 
3. Remplacez *ENTER_YOUR_CLIENT_ID* par l’ID client de votre application Azure inscrite.
4. Remplacez *ENTER_YOUR_SECRET* par la clé de votre application Azure enregistrée.
3. Appuyez sur F5 pour créer et déboguer l’application. Exécutez la solution et connectez-vous à Office 365 avec votre compte professionnel.

     > Remarque : copiez et collez l’adresse URL de la page de démarrage **http://localhost:55065/home/index** dans un autre navigateur si vous obtenez l’erreur suivante au moment de la connexion : **AADSTS70001 : l’application avec l’identifiant ad533dcf-ccad-469a-abed-acd1c8cc0d7d est introuvable dans le répertoire**.

## Questions et commentaires

Nous serions ravis de connaître votre opinion sur l’exemple de connexion d’ASP.NET MVC à Office 365. Vous pouvez nous faire part de vos questions et suggestions dans la rubrique [Problèmes](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/issues) de ce référentiel.

Si vous avez des questions sur le développement d’Office 365, envoyez-les sur [Stack Overflow](http://stackoverflow.com/questions/tagged/Office365+API). Veillez à poser vos questions ou à rédiger vos commentaires avec les tags [MicrosoftGraph] et [Office 365].
  
## Ressources supplémentaires

* [Documentation Microsoft Graph](http://graph.microsoft.io)
* [Références d’API Microsoft Graph](http://graph.microsoft.io/docs/api-reference/v1.0)


## Copyright
Copyright (c) 2015 Microsoft. Tous droits réservés.



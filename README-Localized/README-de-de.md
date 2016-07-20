# Office 365 Connect ASP.NET MVC-Beispiel unter Verwendung von Microsoft Graph

Für die Arbeit mit Office 365-Diensten und -Daten muss jede App zunächst eine Verbindung zu Office 365 herstellen. In diesem Beispiel wird die Verbindung zu und Verwendung von Microsoft Graph (wurde zuvor als vereinheitlichte Office 365-API bezeichnet) für das Senden einer E-Mail gezeigt. Darin wird die [Active Directory Authentication Library](https://msdn.microsoft.com/de-de/library/azure/jj573266.aspx) zum Vornehmen eines OAuth2-Aufrufs verwendet.

> Hinweis: Weitere Informationen zum Code, der die Microsoft Graph-API in einer ASP.NET MVC-App aufruft, finden Sie unter [Aufrufen von Microsoft Graph in einer ASP.NET MVC-App] (https://graph.microsoft.io/en-us/docs/platform/aspnetmvc).

![Screenshot des Office 365 ASP.NET MVC-Beispiels](../README assets/O365AspNetMVCSendMailPageScreenshot.png)

## Voraussetzungen

Rufen Sie die Seite [Erste Schritte mit Office 365-APIs](http://dev.office.com/getting-started/office365apis?platform=option-dotnet#setup) auf. Auf dieser wird die Registrierung vereinfacht, damit Sie dieses Beispiel schneller ausführen können.

Zum Verwenden des Office 365 ASP.NET MVC Connect-Beispiels benötigen Sie Folgendes:
* Visual Studio 2015, installiert und betriebsbereit auf dem Entwicklungscomputer. 

     > Hinweis: In diesem Beispiel wird Visual Studio 2015 verwendet. Wenn Sie Visual Studio 2013 verwenden, müssen Sie die Sprachversion des Compilers in der Web.config-Datei in „5“ ändern: **compilerOptions="/langversion:5**
* Ein Office 365-Konto. Sie können sich für ein [Office 365-Entwicklerabonnement](https://aka.ms/devprogramsignup) registrieren, das alle Ressourcen umfasst, die Sie zum Einstieg in die Entwicklung von Office 365-Apps benötigen.

     > Hinweis: Wenn Sie bereits über ein Abonnement verfügen, gelangen Sie über den vorherigen Link zu einer Seite mit der Meldung „Leider können Sie Ihrem aktuellen Konto diesen Inhalt nicht hinzufügen“. Verwenden Sie in diesem Fall ein Konto aus Ihrem aktuellen Office 365-Abonnement.
* Ein Microsoft Azure-Mandant zum Registrieren Ihrer Anwendung. Von Azure Active Directory (AD) werden Identitätsdienste bereitgestellt, die durch Anwendungen für die Authentifizierung und Autorisierung verwendet werden. Hier kann ein Testabonnement erworben werden: [Microsoft Azure](https://account.windowsazure.com/SignUp)

     > Wichtig: Sie müssen zudem sicherstellen, dass Ihr Azure-Abonnement an Ihren Office 365-Mandanten gebunden ist. Rufen Sie dafür den Blogpost [Creating and Managing Multiple Windows Azure Active Directories](http://blogs.technet.com/b/ad/archive/2013/11/08/creating-and-managing-multiple-windows-azure-active-directories.aspx) des Active Directory-Teams auf. Im Abschnitt **Adding a new directory** finden Sie Informationen über die entsprechende Vorgehensweise. Weitere Informationen finden Sie zudem unter [Einrichten Ihrer Office 365-Entwicklungsumgebung](https://msdn.microsoft.com/office/office365/howto/setup-development-environment#bk_CreateAzureSubscription) im Abschnitt **Verknüpfen Ihres Office 365-Kontos mit Azure AD zum Erstellen und Verwalten von Apps**.
* Eine Client-ID und Umleitungs-URI-Werte einer in Azure registrierten Anwendung. Dieser Beispielanwendung muss die Berechtigung zum **Senden von E-Mails als angemeldeter Benutzer** für **Microsoft Graph** gewährt werden. [Fügen Sie eine Webanwendung in Azure hinzu](https://msdn.microsoft.com/office/office365/HowTo/add-common-consent-manually#bk_RegisterWebApp), und [gewähren Sie ihr die entsprechenden Berechtigungen](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/wiki/Grant-permissions-to-the-Connect-application-in-Azure).

     > Hinweis: Stellen Sie während des App-Registrierungsvorgangs sicher, dass **http://localhost:55065** als **Anmelde-URL** angegeben ist.  

## Konfigurieren und Ausführen der App
1. Öffnen Sie die Datei **UnifiedApiConnect.sln**. 
2. Öffnen Sie im Projektmappen-Explorer die Datei **Web.config**. 
3. Ersetzen Sie *IHRE_CLIENT_ID_EINGEBEN* durch die Client-ID Ihrer registrierten Azure-Anwendung.
4. Ersetzen Sie *IHR_GEHEIMNIS_EINGEBEN* durch den Schlüssel Ihrer registrierten Azure-Anwendung.
3. Drücken Sie zum Erstellen und Debuggen F5. Führen Sie die Projektmappe aus, und melden Sie sich mithilfe Ihres Organisationskontos bei Office 365 an.

     > Hinweis: Kopieren und fügen Sie die Startseiten-URL-Adresse  **http://localhost:55065/home/index** in einen anderen Browser ein, wenn während der Anmeldung der folgende Fehler angezeigt wird: **AADSTS70001: Anwendung mit der ID ad533dcf-ccad-469a-abed-acd1c8cc0d7d wurde im Verzeichnis nicht gefunden**.

## Fragen und Kommentare

Wir schätzen Ihr Feedback hinsichtlich des Office 365 365 ASP.NET MVC Connect-Beispiels. Sie können uns Ihre Fragen und Vorschläge über den Abschnitt [Probleme](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/issues) dieses Repositorys senden.

Allgemeine Fragen zur Office 365-Entwicklung sollten in [Stack Overflow](http://stackoverflow.com/questions/tagged/Office365+API) gestellt werden. Stellen Sie sicher, dass Ihre Fragen oder Kommentare mit [Office365] und [MicrosoftGraph] markiert sind.
  
## Zusätzliche Ressourcen

* [Microsoft Graph-Dokumentation](http://graph.microsoft.io)
* [Microsoft Graph-API-Verweise](http://graph.microsoft.io/docs/api-reference/v1.0)


## Copyright
Copyright (c) 2015 Microsoft. Alle Rechte vorbehalten.



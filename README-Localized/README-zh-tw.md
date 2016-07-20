# 使用 Microsoft Graph 的 Office 365 Connect ASP.NET MVC 範例

連接到 Office 365 是每個應用程式要開始使用 Office 365 服務和資料時必須採取的第一個步驟。此範例示範如何連接並使用 Microsoft Graph (之前稱為 Office 365 統一 API) 傳送電子郵件。它會使用 [Active Directory Authentication Library](https://msdn.microsoft.com/zh-tw/library/azure/jj573266.aspx) 進行 OAuth2 呼叫。

> 附註：若要了解在 ASP.NET MVC 應用程式中用於呼叫 Microsoft Graph API 的程式碼，請參閱 [在 ASP.NET MVC 應用程式中呼叫 Microsoft Graph] (https://graph.microsoft.io/en-us/docs/platform/aspnetmvc)。

![Office 365 ASP.NET MVC 範例螢幕擷取畫面](../README assets/O365AspNetMVCSendMailPageScreenshot.png)

## 必要條件

嘗試可簡化註冊的 [Office 365 API 入門](http://dev.office.com/getting-started/office365apis?platform=option-dotnet#setup)頁面，以便您能更快速地執行這個範例。

若要使用 Office 365 ASP.NET MVC Connect 範例，您需要下列項目：
* 已安裝的 Visual Studio 2015，且在您的開發電腦上運作。 

     > 附註：此範例乃使用 Visual Studio  2015 所撰寫而成。如果您目前使用的是 Visual Studio 2013，請確保將 Web.config 檔案中的編譯器語言版本變更為 5︰**compilerOptions="/langversion:5**
* Office 365 帳戶。您可以註冊 [Office 365 開發人員訂閱](https://aka.ms/devprogramsignup)，其中包含在開始建置 Office 365 應用程式時，您所需的資源。

     > 附註：如果您已有訂用帳戶，則先前的連結會讓您連到顯示 *抱歉，您無法將之新增到您目前的帳戶* 訊息的頁面。在此情況下，請使用您目前的 Office 365 訂用帳戶所提供的帳戶。
* 用來註冊您的應用程式的 Microsoft Azure 租用戶。Azure Active Directory (AD) 會提供識別服務，以便應用程式用於驗證和授權。在這裡可以取得試用版的訂用帳戶：[Microsoft Azure](https://account.windowsazure.com/SignUp)。

     > 重要事項：您還需要確定您的 Azure 訂用帳戶已繫結至您的 Office 365 租用戶。若要執行這項操作，請參閱 Active Directory 小組的部落格文章：[建立和管理多個 Windows Azure Active Directory](http://blogs.technet.com/b/ad/archive/2013/11/08/creating-and-managing-multiple-windows-azure-active-directories.aspx)。**新增目錄**一節將說明如何執行這項操作。如需詳細資訊，也可以參閱[設定 Office 365 開發環境](https://msdn.microsoft.com/office/office365/howto/setup-development-environment#bk_CreateAzureSubscription)和**建立 Office 365 帳戶與 Azure AD 的關聯以便建立和管理應用程式**一節。
* 在 Azure 中註冊之應用程式的用戶端識別碼和重新導向 URI 值。此範例應用程式必須取得 **Microsoft Graph** 的 [以登入的使用者身分傳送郵件]<e /> 權限。[在 Azure 中新增 Web 應用程式](https://msdn.microsoft.com/office/office365/HowTo/add-common-consent-manually#bk_RegisterWebApp)和[授與適當的權限](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/wiki/Grant-permissions-to-the-Connect-application-in-Azure)給它。

     > 附註：在應用程式註冊過程中，請務必指定 **http://localhost:55065** 做為 [登入 URL]<e />。  

## 設定和執行應用程式
1. 開啟 **UnifiedApiConnect.sln** 檔案。 
2. 在 [方案總管] 中，開啟 **Web.config** 檔案。 
3. 用已註冊之 Azure 應用程式的用戶端識別碼來取代 *ENTER_YOUR_CLIENT_ID*。
4. 用已註冊之 Azure 應用程式的金鑰來取代 *ENTER_YOUR_SECRET*。
3. 按 F5 進行建置和偵錯。執行解決方案並使用您組織的帳戶登入 Office 365。

     > 附註：如果您在登入期間收到下列錯誤，請複製起始頁面 URL 位址 **http://localhost:55065/home/index**，並貼到不同的瀏覽器：**AADSTS70001:在目錄中找不到識別碼為 ad533dcf-ccad-469a-abed-acd1c8cc0d7d 的應用程式**。

## 問題與意見

我們很樂於收到您對於 Office 365 365 ASP.NET MVC Connect 範例的意見反應。您可以在此儲存機制的[問題](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/issues)區段中，將您的問題及建議傳送給我們。

請在 [Stack Overflow](http://stackoverflow.com/questions/tagged/Office365+API) 提出有關 Office 365 開發的一般問題。務必以 [Office365] 和 [MicrosoftGraph] 標記您的問題或意見。
  
## 其他資源

* [Microsoft Graph 文件](http://graph.microsoft.io)
* [Microsoft Graph API 參考](http://graph.microsoft.io/docs/api-reference/v1.0)


## 著作權
Copyright (c) 2015 Microsoft.著作權所有，並保留一切權利。



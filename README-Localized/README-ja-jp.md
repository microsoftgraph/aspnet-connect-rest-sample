# Microsoft Graph を使った Office 365 Connect ASP.NET MVC サンプル

各アプリで Office 365 のサービスとデータの操作を開始するため、最初に Office 365 に接続する必要があります。このサンプルでは、Microsoft Graph (以前は Office 365 統合 API と呼ばれていた) に接続して使って、電子メールを送信する方法を示します。[Azure Active Directory 認証ライブラリ](https://msdn.microsoft.com/ja-jp/library/azure/jj573266.aspx)を使って、OAuth2 呼び出しを行います。

> 注:ASP.NET MVC アプリ で Microsoft Graph API を呼び出すためのコードを理解するには、「ASP.NET MVC アプリで Microsoft Graph を呼び出す (https://graph.microsoft.io/ja-jp/docs/platform/aspnetmvc)」をご覧ください。

![Office 365 ASP.NET MVC サンプルのスクリーンショット](../README assets/O365AspNetMVCSendMailPageScreenshot.png)

## 前提条件

このサンプルをより迅速に実行するため、「[Office 365 API を使う](http://dev.office.com/getting-started/office365apis?platform=option-dotnet#setup)」ページに記載された登録の簡略化をお試しください。

Office 365 ASP.NET MVC Connect サンプルを使うには、次の事項が必要です:
* 開発用コンピューターに Visual Studio 2015 がインストールされており、動作していること。 

     > 注:このサンプルは、Visual Studio 2015 を使用して書かれています。Visual Studio 2013 を使用している場合は、Web.config ファイルでコンパイラの言語バージョンを 5 に変更することを確認してください: **compilerOptions="/langversion:5**
* Office 365 アカウント。[Office 365 Developer](https://aka.ms/devprogramsignup) サブスクリプションにサイン アップすることができます。ここには、Office 365 アプリのビルドを開始するために必要なリソースが含まれています。

     > 注: サブスクリプションが既に存在する場合、上記のリンクをクリックすると、*申し訳ありません、現在のアカウントに追加できません* と表示されたページに移動します。その場合は、現在使用している Office 365 サブスクリプションのアカウントをご利用いただけます。
* アプリケーションを登録する Microsoft Azure テナント。Azure Active Directory (AD) は、アプリケーションが認証と承認に使用する ID サービスを提供します。試用版サブスクリプションは、[Microsoft Azure](https://account.windowsazure.com/SignUp) で取得できます。

     > 重要事項: Azure サブスクリプションが Office 365 テナントにバインドされていることを確認する必要があります。確認するには、Active Directory チームのブログ投稿「[複数の Windows Azure Active Directory を作成および管理する](http://blogs.technet.com/b/ad/archive/2013/11/08/creating-and-managing-multiple-windows-azure-active-directories.aspx)」を参照してください。「**新しいディレクトリを追加する**」セクションで、この方法について説明しています。また、詳細については、「[Office 365 開発環境をセットアップする](https://msdn.microsoft.com/office/office365/howto/setup-development-environment#bk_CreateAzureSubscription)」や「**Office 365 アカウントを Azure AD と関連付けてアプリを作成および管理する**」セクションも参照してください。
* Azure に登録されたアプリケーションのクライアント ID とリダイレクト URI の値。このサンプル アプリケーションには、**Microsoft Graph** の**サインインしているユーザーとしてメールを送信する**アクセス許可を付与する必要があります。[Azure に Web アプリケーションを追加](https://msdn.microsoft.com/office/office365/HowTo/add-common-consent-manually#bk_RegisterWebApp)し、[適切なアクセス許可を付与](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/wiki/Grant-permissions-to-the-Connect-application-in-Azure)します。

     > 注:アプリ登録プロセス時に、**サインオン URL** として **http://localhost:55065** を必ず指定します。  

## アプリの構成と実行
1. **UnifiedApiConnect.sln** ファイルを開きます。 
2. ソリューション エクスプローラーで、**Web.config** ファイルを開きます。 
3. *ENTER_YOUR_CLIENT_ID* を登録済みの Azure アプリケーションのクライアント ID と置き換えます。
4. *ENTER_YOUR_SECRET* を登録済みの Azure アプリケーションのキーと置き換えます。
3. F5 キーを押してビルドとデバッグを実行します。ソリューションを実行し、所属組織のアカウントで Office 365 にサインインします。

     > 注:サインイン中に次のエラーが発生した場合は、別のブラウザーに開始ページの URL アドレス **http://localhost:55065/home/index** をコピーして貼り付けます。**AADSTS70001:識別子 ad533dcf-ccad-469a-abed-acd1c8cc0d7d を持つアプリケーションがディレクトリに見つかりませんでした**。

## 質問とコメント

Office 365 365 ASP.NET MVC Connect サンプルについて、Microsoft にフィードバックをお寄せください。質問や提案につきましては、このリポジトリの「[問題](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/issues)」セクションに送信できます。

Office 365 開発全般の質問につきましては、「[スタック オーバーフロー](http://stackoverflow.com/questions/tagged/Office365+API)」に投稿してください。質問またはコメントには、必ず [Office365] および [MicrosoftGraph] のタグを付けてください。
  
## その他の技術情報

* [Microsoft Graph ドキュメント](http://graph.microsoft.io)
* [Microsoft Graph API リファレンス](http://graph.microsoft.io/docs/api-reference/v1.0)


## 著作権
Copyright (c) 2015 Microsoft.All rights reserved.



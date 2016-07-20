# 使用 Microsoft Graph 的 Office 365 Connect ASP.NET MVC 示例

连接到 Office 365 是每个应用开始使用 Office 365 服务和数据必须采取的第一步。该示例演示如何连接 Microsoft Graph（旧称 Office 365 统一 API）及如何使用它发送电子邮件。它使用 [Active Directory Authentication Library](https://msdn.microsoft.com/zh-cn/library/azure/jj573266.aspx) 调用 OAuth2。

> 注意：要了解在 ASP.NET MVC 应用中调用 Microsoft Graph API 的代码，请参阅 [在 ASP.NET MVC 应用中调用 Microsoft Graph] (https://graph.microsoft.io/zh-cn/docs/platform/aspnetmvc)。

![Office 365 ASP.NET MVC 示例的屏幕截图](../README assets/O365AspNetMVCSendMailPageScreenshot.png)

## 先决条件

尝试 [Office 365 API 入门](http://dev.office.com/getting-started/office365apis?platform=option-dotnet#setup)页面，其简化了注册，使您可以更快地运行该示例。

要使用 Office 365 ASP.NET MVC Connect 示例，您需要以下内容：
* 在您的开发计算机上安装并使用 Visual Studio 2015。 

     > 注意：此示例是使用 Visual Studio 2015 编写的。如果您使用的是 Visual Studio 2013，请务必将 Web.config 文件中的编译器语言版本更改为 5：**compilerOptions="/langversion:5**
* Office 365 帐户。您可以注册 [Office 365 开发人员订阅](https://aka.ms/devprogramsignup)，其中包含开始构建 Office 365 应用所需的资源。

     > 注意：如果您已经订阅，之前的链接会将您转至包含以下信息的页面：*抱歉，您无法将其添加到当前帐户*。在这种情况下，请使用当前 Office 365 订阅中的帐户。
* 用于注册您的应用程序的 Microsoft Azure 租户。Azure Active Directory (AD) 为应用程序提供了用于进行身份验证和授权的标识服务。您还可在此处获得试用订阅：[Microsoft Azure](https://account.windowsazure.com/SignUp)。

     > 重要说明：您还需要确保您的 Azure 订阅已绑定到 Office 365 租户。要执行这一操作，请参阅 Active Directory 团队的博客文章：[创建和管理多个 Microsoft Azure Active Directory](http://blogs.technet.com/b/ad/archive/2013/11/08/creating-and-managing-multiple-windows-azure-active-directories.aspx)。**添加新目录**一节将介绍如何执行此操作。您还可以参阅[设置 Office 365 开发环境](https://msdn.microsoft.com/office/office365/howto/setup-development-environment#bk_CreateAzureSubscription)和**关联您的 Office 365 帐户和 Azure AD 以创建并管理应用**一节获取详细信息。
* 在 Azure 中注册的应用程序的客户端 ID 和重定向 URI 值。必须向该示例应用程序授予**以登录用户身份发送邮件**权限以使用 **Microsoft Graph**。[在 Azure 中添加 Web 应用程序](https://msdn.microsoft.com/office/office365/HowTo/add-common-consent-manually#bk_RegisterWebApp)并向其[授予适当的权限](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/wiki/Grant-permissions-to-the-Connect-application-in-Azure)。

     > 注意：在应用注册过程中，务必将 **http://localhost:55065** 指定为**登录 URL**。  

## 配置并运行应用
1. 打开 **UnifiedApiConnect.sln** 文件。 
2. 在“解决方案资源管理器”中打开 **Web.config** 文件。 
3. 用所注册的 Azure 应用程序的客户端 ID 替换 *ENTER_YOUR_CLIENT_ID*。
4. 用所注册的 Azure 应用程序的密钥替换 *ENTER_YOUR_SECRET*。
3. 按 F5 进行构建和调试。运行解决方案，并使用组织帐户登录 Office 365。

     > 注意：如果您在登录过程中发现以下错误，请将起始页 URL 地址 **http://localhost:55065/home/index** 复制粘贴到其他浏览器中：**AADSTS70001:目录中未发现标识符为 ad533dcf-ccad-469a-abed-acd1c8cc0d7d 的应用程序**。

## 问题和意见

我们乐意倾听您有关 Office 365 ASP.NET MVC Connect 示例的反馈。您可以在该存储库中的[问题](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/issues)部分将问题和建议发送给我们。

与 Office 365 开发相关的问题一般应发布到[堆栈溢出](http://stackoverflow.com/questions/tagged/Office365+API)。确保您的问题或意见使用了 [Office365] 和 [MicrosoftGraph] 标记。
  
## 其他资源

* [Microsoft Graph 文档](http://graph.microsoft.io)
* [Microsoft Graph API 参考](http://graph.microsoft.io/docs/api-reference/v1.0)


## 版权
版权所有 (c) 2015 Microsoft。保留所有权利。



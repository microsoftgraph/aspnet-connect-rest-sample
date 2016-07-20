# Пример приложения ASP.NET MVC, подключающегося к Office 365 и использующего Microsoft Graph

Подключение к Office 365 — это первый шаг, который должно выполнить каждое приложение, чтобы начать работу со службами и данными Office 365. В этом примере показано, как подключить и использовать Microsoft Graph (прежнее название — единый API Office 365) для отправки электронной почты. Для вызова OAuth2 используется [библиотека проверки подлинности Active Directory](https://msdn.microsoft.com/ru-ru/library/azure/jj573266.aspx).

> Примечание. Сведения о коде для вызова API Microsoft Graph в приложении ASP.NET MVC см. в статье [Вызов Microsoft Graph в приложении ASP.NET MVC] (https://graph.microsoft.io/ru-ru/docs/platform/aspnetmvc).

![Снимок экрана с примером ASP.NET MVC в Office 365](../README assets/O365AspNetMVCSendMailPageScreenshot.png)

## Необходимые условия

Перейдите на страницу [Начало работы с API Office 365](http://dev.office.com/getting-started/office365apis?platform=option-dotnet#setup) для упрощенной регистрации, чтобы ускорить запуск этого примера.

Чтобы использовать пример приложения ASP.NET MVC, подключающегося к Office 365, требуются следующие компоненты:
* Набор инструментов Visual Studio 2015, установленный и работающий на компьютере для разработки. 

     > Примечание. Этот пример создан с помощью Visual Studio 2015. Если вы используете Visual Studio 2013, обязательно измените версию языка компилятора в файле Web.config на 5: **compilerOptions="/langversion:5**
* Учетная запись Office 365. Вы можете [подписаться на план Office 365 для разработчиков](https://aka.ms/devprogramsignup), включающий ресурсы, которые необходимы для создания приложений Office 365.

     > Примечание. Если у вас уже есть подписка, при выборе приведенной выше ссылки откроется страница с сообщением *К сожалению, вы не можете добавить это к своей учетной записи*. В этом случае используйте учетную запись, сопоставленную с текущей подпиской на Office 365.
* Клиент Microsoft Azure для регистрации приложения. В Azure Active Directory (AD) доступны службы идентификации, которые приложения используют для проверки подлинности и авторизации. Здесь можно получить пробную подписку: [Microsoft Azure](https://account.windowsazure.com/SignUp).

     > Важно! Убедитесь, что ваша подписка на Azure привязана к клиенту Office 365. Для этого просмотрите запись в блоге команды Active Directory, посвященную [созданию нескольких каталогов Microsoft Azure AD и управлению ими](http://blogs.technet.com/b/ad/archive/2013/11/08/creating-and-managing-multiple-windows-azure-active-directories.aspx). Инструкции приведены в разделе о **добавлении нового каталога**. Дополнительные сведения см. в статье [Как настроить среду разработки для Office 365](https://msdn.microsoft.com/office/office365/howto/setup-development-environment#bk_CreateAzureSubscription) и, в частности, в разделе **Связывание Azure AD и учетной записи Office 365 для создания приложений и управления ими**.
* Универсальный код ресурса (URI) для перенаправления и идентификатор клиента, указанные при регистрации приложения в Azure. Этому примеру приложения необходимо предоставить разрешение**Отправка почты от имени вошедшего пользователя** для **Microsoft Graph**. [Добавьте веб-приложение в Azure](https://msdn.microsoft.com/office/office365/HowTo/add-common-consent-manually#bk_RegisterWebApp) и [предоставьте ему необходимые разрешения](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/wiki/Grant-permissions-to-the-Connect-application-in-Azure).

     > Примечание. При регистрации приложения укажите **http://localhost:55065** как значение параметра **URL-адрес входа**.  

## Настройка и запуск приложения
1. Откройте файл **UnifiedApiConnect.sln**. 
2. В обозревателе решений откройте файл **Web.config**. 
3. Замените *ENTER_YOUR_CLIENT_ID* на идентификатор клиента для зарегистрированного в Azure приложения.
4. Замените *ENTER_YOUR_SECRET* на ключ для зарегистрированного в Azure приложения.
3. Нажмите клавишу F5 для сборки и отладки. Запустите решение и войдите в Office 365 с помощью учетной записи организации.

     > Примечание. Скопируйте и вставьте URL-адрес начальной страницы (**http://localhost:55065/home/index**) в адресную строку другого браузера, если при входе появляется следующее сообщение об ошибке: **AADSTS70001: приложение с идентификатором d533dcf-ccad-469a-abed-acd1c8cc0d7d не обнаружено в каталоге**.

## Вопросы и комментарии

Мы будем рады получить от вас отзывы о примере приложения ASP.NET MVC, подключающегося к Office 365. Вы можете отправлять нам вопросы и предложения в разделе [Issues](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/issues) этого репозитория.

Общие вопросы о разработке решений для Office 365 следует публиковать на сайте [Stack Overflow](http://stackoverflow.com/questions/tagged/Office365+API). Обязательно помечайте свои вопросы и комментарии тегами [Office365] и [MicrosoftGraph].
  
## Дополнительные ресурсы

* [Документация по Microsoft Graph](http://graph.microsoft.io)
* [Справочники по API Microsoft Graph](http://graph.microsoft.io/docs/api-reference/v1.0)


## Авторское право
(c) Корпорация Майкрософт (Microsoft Corporation), 2015. Все права защищены.



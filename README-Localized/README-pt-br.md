# Exemplo de conexão ASP.NET MVC com o Office 365 usando o Microsoft Graph

A primeira etapa para que os aplicativos comecem a funcionar com dados e serviços do Office 365 é estabelecer uma conexão com essa plataforma. Este exemplo mostra como se conectar e usar o Microsoft Graph (antiga API unificada do Office 365) para enviar um email. Ele usa a [Biblioteca de Autenticação do Active Directory](https://msdn.microsoft.com/pt-br/library/azure/jj573266.aspx) para fazer com que o OAuth2 realize uma chamada.

> Observação: Para compreender o código para chamar a API do Microsoft Graph em um aplicativo ASP.NET MVC, confira [Chamar o Microsoft Graph em um aplicativo ASP.NET MVC] (https://graph.microsoft.io/en-us/docs/platform/aspnetmvc).

![Captura de tela do exemplo do Office 365 para ASP.NET MVC](../README assets/O365AspNetMVCSendMailPageScreenshot.png)

## Pré-requisitos

Experimente a página [Introdução às APIs do Office 365](http://dev.office.com/getting-started/office365apis?platform=option-dotnet#setup), que simplifica o registro para que você possa executar esse exemplo com mais rapidez.

Para usar o exemplo de conexão com o Office 365 para ASP.NET MVC, é necessário o seguinte:
* Visual Studio 2015 instalado e funcionando em seu computador de desenvolvimento. 

     > Observação: Este exemplo foi escrito com o Visual Studio 2015. Se você estiver usando o Visual Studio 2013, certifique-se de alterar a versão do idioma do compilador para 5 no arquivo Web.config: **compilerOptions="/langversion:5**
* Uma conta do Office 365. Você pode se inscrever para [uma assinatura do Office 365 Developer](https://aka.ms/devprogramsignup), que inclui os recursos de que você precisa para começar a criar aplicativos do Office 365.

     > Observação: Caso já tenha uma assinatura, o link anterior direciona você para uma página com a mensagem *Não é possível adicioná-la à sua conta atual*. Nesse caso, use uma conta de sua assinatura atual do Office 365.
* Um locatário do Microsoft Azure para registrar o seu aplicativo. O Active Directory (AD) do Azure fornece serviços de identidade que os aplicativos usam para autenticação e autorização. Você pode adquirir uma assinatura de avaliação aqui: [Microsoft Azure](https://account.windowsazure.com/SignUp).

     > Importante: Você também deve assegurar que a sua assinatura do Azure esteja vinculada ao seu locatário do Office 365. Para saber como fazer isso, confira a postagem de blog da equipe do Active Directory: [Criar e gerenciar vários Microsoft Azure Active Directory](http://blogs.technet.com/b/ad/archive/2013/11/08/creating-and-managing-multiple-windows-azure-active-directories.aspx). A seção **Adicionar um novo diretório** explica como fazer isso. Para saber mais, confira o artigo [Configurar o seu ambiente de desenvolvimento do Office 365](https://msdn.microsoft.com/office/office365/howto/setup-development-environment#bk_CreateAzureSubscription) e a seção **Associar a sua conta do Office 365 ao Azure AD para criar e gerenciar aplicativos**.
* Valores de uma ID do cliente e de um URI de redirecionamento de um aplicativo registrado no Azure. Esse exemplo de aplicativo deve receber permissão para **Enviar email como usuário conectado** para o **Microsoft Graph**. Para isso, [adicione um aplicativo Web no Microsoft Azure](https://msdn.microsoft.com/office/office365/HowTo/add-common-consent-manually#bk_RegisterWebApp) e [conceda as permissões adequadas](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/wiki/Grant-permissions-to-the-Connect-application-in-Azure).

     > Observação: Durante o processo de registro do aplicativo, não deixe de especificar **http://localhost:55065** como a **URL de Entrada**.  

## Configurar e executar o aplicativo
1. Abra o arquivo **UnifiedApiConnect.sln**. 
2. No Gerenciador de Soluções, abra o arquivo **Web.config**. 
3. Substitua *ENTER_YOUR_CLIENT_ID* pela ID do cliente do aplicativo Azure registrado.
4. Substitua *ENTER_YOUR_SECRET* pela chave do aplicativo Azure registrado.
3. Pressione F5 para criar e depurar. Execute a solução e entre no Office 365 com uma conta corporativa.

     > Observação: Copie e cole o endereço da URL da página de início **http://localhost:55065/home/index** em um navegador diferente, se você receber o seguinte erro durante a entrada no: **AADSTS70001: O aplicativo com o identificador ad533dcf-ccad-469a-abed-acd1c8cc0d7d não foi encontrado no diretório**.

## Perguntas e comentários

Gostaríamos de saber a sua opinião sobre o exemplo de conexão com o Office 365 para ASP.NET MVC. Você pode enviar perguntas e sugestões na seção [Problemas](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/issues) deste repositório.

As perguntas sobre o desenvolvimento do Office 365 em geral devem ser postadas no [Stack Overflow](http://stackoverflow.com/questions/tagged/Office365+API). Não deixe de marcar as perguntas ou comentários com [Office365] e [MicrosoftGraph].
  
## Recursos adicionais

* [Documentação do Microsoft Graph](http://graph.microsoft.io)
* [Referências da API do Microsoft Graph](http://graph.microsoft.io/docs/api-reference/v1.0)


## Direitos autorais
Copyright © 2015 Microsoft. Todos os direitos reservados.



# Exemplo de conexão com o Microsoft Graph para ASP.NET 4.6

## Sumário

* [Pré-requisitos](#pré-requisitos)
* [Registrar o aplicativo](#registrar-o-aplicativo)
* [Criar e executar o exemplo](#criar-e-executar-o-exemplo)
* [Código da observação](#código-da-observação)
* [Perguntas e comentários](#perguntas-e-comentários)
* [Colaboração](#colaboração)
* [Recursos adicionais](#recursos-adicionais)

Este exemplo mostra como se conectar a um aplicativo Web do ASP.NET 4.6 MVC a uma conta comercial ou escolar (Azure Active Directory) da Microsoft ou uma conta pessoal (Microsoft) usando a API do Microsoft Graph API para enviar emails. O exemplo usa as [Biblioteca de Cliente do Microsoft Graph .NET](https://github.com/microsoftgraph/msgraph-sdk-dotnet) para trabalhar com dados retornados pelo Microsoft Graph. 

Além disso, o exemplo usa a [Biblioteca de Autenticação da Microsoft (MSAL)](https://www.nuget.org/packages/Microsoft.Identity.Client/) para autenticação. O SDK da MSAL fornece recursos para trabalhar com o [ponto de extremidade de autenticação v2](https://azure.microsoft.com/en-us/documentation/articles/active-directory-appmodel-v2-overview) que permite que os desenvolvedores gravem um único fluxo de código para tratar da autenticação de contas comerciais ou escolares (Azure Active Directory) e de contas pessoais (Microsoft).

 > **Observação** No momento, o SDK da MSAL encontra-se em pré-lançamento e como tal não deve ser usado no código de produção. Isso é usado apenas para fins ilustrativos

## Pré-requisitos

Este exemplo requer o seguinte:  

  * [Visual Studio 2015](https://www.visualstudio.com/en-us/downloads) 
  * A [conta da Microsoft](https://www.outlook.com) ou a [conta do Office 365 para empresas](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account). Inscreva-se em uma [Assinatura do Office 365 para Desenvolvedor](https://msdn.microsoft.com/en-us/office/office365/howto/setup-development-environment#bk_Office365Account) que inclua os recursos necessários para começar a criar aplicativos do Office 365.

## Registrar o aplicativo

1. Entre no [Portal de Registro do Aplicativo](https://apps.dev.microsoft.com/) usando sua conta pessoal ou sua conta comercial ou escolar.

2. Escolha **Adicionar um aplicativo**.

3. Insira um nome para o aplicativo e escolha **Criar aplicativo**. 
    
   A página de registro é exibida, listando as propriedades do seu aplicativo.

4. Copie a ID do Aplicativo. Esse é o identificador exclusivo do aplicativo. 

5. Em **Segredos do Aplicativo**, escolha **Gerar Nova Senha**. Copie a senha da caixa de diálogo **Nova senha gerada**.

   Você usará a ID do aplicativo e a senha para configurar o aplicativo de exemplo na próxima seção. 

6. Em **Plataformas**, escolha **Adicionar plataforma**.

7. Escolha **Web**.

8. Verifique se a caixa de diálogo **Permitir Fluxo Implícito** está marcada e insira *https://localhost:44300/* como o URI de redirecionamento. 

   A opção **Permitir Fluxo Implícito** habilita o fluxo híbrido. Durante a autenticação, isso permite que o aplicativo receba informações de entrada (o id_token) e artefatos (neste caso, um código de autorização) que o aplicativo pode usar para obter um token de acesso.

9. Escolha **Salvar**.

## Criar e executar o exemplo

1. Baixe ou clone o Exemplo de Conexão com o Microsoft Graph para ASP.NET 4.6.

2. Abra a solução de exemplo no Visual Studio.

3. No arquivo Web.config no diretório raiz, substitua os valores dos espaços reservados **ida:AppId** e **ida:AppSecret** pela ID de aplicativo e senha copiadas durante o registro do aplicativo.

4. Pressione F5 para criar e executar o exemplo. Isso restaurará dependências do pacote NuGet e abrirá o aplicativo.

   >Caso receba mensagens de erro durante a instalação de pacotes, verifique se o caminho para o local onde você colocou a solução não é muito longo ou extenso. Para resolver esse problema, coloque a solução junto à raiz da unidade.

5. Entre com sua conta pessoal ou sua conta comercial ou escolar e conceda as permissões solicitadas.

6. Escolha o botão **Obter endereço de email**. Quando a operação for concluída, o endereço de email do usuário conectado será exibido na página.

7. Como alternativa, edite a lista de destinatários e o assunto do email e, em seguida, escolha o botão **Enviar email**. Quando o email for enviado, será exibida uma mensagem de sucesso abaixo do botão.

## Código da observação

- [Startup.Auth.cs](/Microsoft%20Graph%20SDK%20ASPNET%20Connect/Microsoft%20Graph%20SDK%20ASPNET%20Connect/App_Start/Startup.Auth.cs). Autentica o usuário atual e inicializa o cache de token do exemplo.

- [SessionTokenCache.cs](/Microsoft%20Graph%20SDK%20ASPNET%20Connect/Microsoft%20Graph%20SDK%20ASPNET%20Connect/TokenStorage/SessionTokenCache.cs). Armazena as informações de token do usuário. Você pode substituir pelo seu próprio cache de token personalizado. Saiba mais em [Armazenamento de tokens de acesso em cache em um aplicativo de vários locatários](https://azure.microsoft.com/en-us/documentation/articles/guidance-multitenant-identity-token-cache/).

- [SampleAuthProvider.cs](/Microsoft%20Graph%20SDK%20ASPNET%20Connect/Microsoft%20Graph%20SDK%20ASPNET%20Connect/Helpers/SampleAuthProvider.cs). Implementa a interface IAuthProvider local e obtém acesso a um token usando o método **AcquireTokenSilentAsync** da MSAL. Isso pode ser substituído pelo seu próprio provedor de autenticação. 

- [SDKHelper.cs](/Microsoft%20Graph%20SDK%20ASPNET%20Connect/Microsoft%20Graph%20SDK%20ASPNET%20Connect/Helpers/SDKHelper.cs). Inicializa o **GraphServiceClient** na [Biblioteca de Cliente do Microsoft Graph .NET](https://github.com/microsoftgraph/msgraph-sdk-dotnet) usada para interagir com o Microsoft Graph.

- [HomeController.cs](/Microsoft%20Graph%20SDK%20ASPNET%20Connect/Microsoft%20Graph%20SDK%20ASPNET%20Connect/Controllers/HomeController.cs). Contêm métodos que usam o **GraphServiceClient** para criar e enviar chamadas para o serviço do Microsoft Graph e processar a resposta.
   - A ação **GetMyEmailAddress** obtém o endereço de email do usuário atual das propriedade **mail** ou **userPrincipalName**.
   - A ação **SendMail** envia um email em nome do usuário atual.

- [Graph.cshtml](/Microsoft%20Graph%20SDK%20ASPNET%20Connect/Microsoft%20Graph%20SDK%20ASPNET%20Connect/Views/Home/Graph.cshtml). Contém a interface de usuário do exemplo. 

## Perguntas e comentários

Gostaríamos de saber sua opinião sobre este exemplo. Você pode nos enviar suas perguntas e sugestões por meio da seção [Issues](https://github.com/microsoftgraph/aspnet-connect-sample/issues) deste repositório.

Seus comentários são importantes para nós. Junte-se a nós na página [Stack Overflow](http://stackoverflow.com/questions/tagged/microsoftgraph). Marque suas perguntas com [MicrosoftGraph].

## Colaboração ##

Se quiser contribuir para esse exemplo, confira [CONTRIBUTING.md](CONTRIBUTING.md).

Este projeto adotou o [Código de Conduta do Código Aberto da Microsoft](https://opensource.microsoft.com/codeofconduct/). Para saber mais, confira as [Perguntas frequentes do Código de Conduta](https://opensource.microsoft.com/codeofconduct/faq/) ou contate [opencode@microsoft.com](mailto:opencode@microsoft.com) se tiver outras dúvidas ou comentários.

## Recursos adicionais

- [Outros exemplos de conexão usando o Microsoft Graph](https://github.com/MicrosoftGraph?utf8=%E2%9C%93&query=-Connect)
- [Visão geral do Microsoft Graph](http://graph.microsoft.io)
- [Exemplos de código para desenvolvedores do Office](http://dev.office.com/code-samples)
- [Centro de desenvolvimento do Office](http://dev.office.com/)

## Direitos autorais
Copyright © 2016 Microsoft. Todos os direitos reservados.



# Ejemplo Connect de ASP.NET MVC para Office 365 con Microsoft Graph

Conectarse a Office 365 es el primer paso que debe realizar cada aplicación para empezar a trabajar con los datos y servicios de Office 365. Este ejemplo muestra cómo conectar y cómo usar Microsoft Graph (anteriormente denominada API unificada de Office 365) para enviar un correo electrónico. Usa la [Biblioteca de autenticación de Active Directory](https://msdn.microsoft.com/es-es/library/azure/jj573266.aspx) para llamar a OAuth2.

> Nota: Para entender el código para llamar a la API de Microsoft Graph en una aplicación ASP.NET MVC, consulte [Llamar a Microsoft Graph en una aplicación ASP.NET MVC] (https://graph.microsoft.io/en-us/docs/platform/aspnetmvc).

![Captura de pantalla de ejemplo de ASP.NET MVC de Office 365](../README assets/O365AspNetMVCSendMailPageScreenshot.png)

## Requisitos previos

Consulte la página [Introducción a las API de Office 365](http://dev.office.com/getting-started/office365apis?platform=option-dotnet#setup), que simplifica el registro para que este ejemplo se ejecute más rápidamente.

Para usar el ejemplo Connect de ASP.NET MVC para Office 365, necesita lo siguiente:
* Visual Studio 2015 instalado y en funcionamiento en el equipo de desarrollo. 

     > Nota: Este ejemplo se escribió usando Visual Studio 2015. Si está usando Visual Studio 2013, asegúrese de cambiar la versión de idioma del compilador a 5 en el archivo de Web.config: **compilerOptions="/langversion:5**
* Una cuenta de Office 365. Puede registrarse para obtener [una suscripción a Office 365 Developer](https://aka.ms/devprogramsignup), que incluye los recursos que necesita para empezar a compilar aplicaciones de Office 365.

     > Nota: Si ya dispone de una suscripción, el vínculo anterior le dirige a una página con el mensaje *No se puede agregar a su cuenta actual*. En ese caso, use una cuenta de su suscripción actual de Office 365.
* Un inquilino de Microsoft Azure para registrar la aplicación. Azure Active Directory (AD) proporciona servicios de identidad que las aplicaciones usan para autenticación y autorización. Puede adquirir una suscripción de prueba aquí: [Microsoft Azure](https://account.windowsazure.com/SignUp).

     > Importante: También necesita asegurarse de que su suscripción de Azure está enlazada a su inquilino de Office 365. Para ello, consulte la publicación del blog del equipo de Active Directory, [Crear y administrar varios directorios de Windows Azure Active Directory](http://blogs.technet.com/b/ad/archive/2013/11/08/creating-and-managing-multiple-windows-azure-active-directories.aspx). La sección **Agregar un nuevo directorio** le explicará cómo hacerlo. Para obtener más información, también puede consultar [Configurar el entorno de desarrollo de Office 365](https://msdn.microsoft.com/office/office365/howto/setup-development-environment#bk_CreateAzureSubscription) y la sección **Asociar su cuenta de Office 365 con Azure AD para crear y administrar aplicaciones**.
* Los valores de identificador de cliente y URI de redireccionamiento de una aplicación registrada en Azure. A esta aplicación de ejemplo se le debe conceder el permiso **Enviar correo como usuario con sesión iniciada** para **Microsoft Graph**. [Agregar una aplicación web en Azure](https://msdn.microsoft.com/office/office365/HowTo/add-common-consent-manually#bk_RegisterWebApp) y [concederle los permisos adecuados](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/wiki/Grant-permissions-to-the-Connect-application-in-Azure).

     > Nota: Durante el proceso de registro de la aplicación, asegúrese de especificar **http://localhost:55065** como la **dirección URL de inicio de sesión**.  

## Configurar y ejecutar la aplicación
1. Abra el archivo **UnifiedApiConnect.sln**. 
2. En el Explorador de soluciones, abra el archivo **Web.config**. 
3. Reemplace *ENTER_YOUR_CLIENT_ID* por el identificador de cliente de la aplicación registrada en Azure.
4. Reemplace *ENTER_YOUR_SECRET* por la clave de la aplicación registrada en Azure.
3. Presione F5 para compilar y depurar. Ejecute la solución e inicie sesión en Office 365 con su cuenta de la organización.

     > Nota: Copie y pegue la dirección URL de la página de inicio **http://localhost:55065/home/index** a un explorador diferente si obtiene el siguiente error durante el inicio de sesión:**AADSTS70001: La aplicación con el identificador ad533dcf-ccad-469a-abed-acd1c8cc0d7d no se encontró en el directorio**.

## Preguntas y comentarios

Nos encantaría recibir sus comentarios acerca del ejemplo Connect de ASP.NET MVC para Office 365. Puede enviarnos sus preguntas y sugerencias a través de la sección [Problemas](https://github.com/OfficeDev/O365-AspNetMVC-Microsoft-Graph-Connect/issues) de este repositorio.

Las preguntas generales sobre desarrollo en Office 365 deben publicarse en [Stack Overflow](http://stackoverflow.com/questions/tagged/Office365+API). Asegúrese de que sus preguntas o comentarios se etiquetan con [Office365] y [MicrosoftGraph].
  
## Recursos adicionales

* [Documentación de Microsoft Graph](http://graph.microsoft.io)
* [Referencias de la API de Microsoft Graph](http://graph.microsoft.io/docs/api-reference/v1.0)


## Copyright
Copyright (c) 2015 Microsoft. Todos los derechos reservados.



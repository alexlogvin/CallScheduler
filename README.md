# CallScheduler

[![Hack Together: Microsoft Graph and .NET](https://img.shields.io/badge/Microsoft%20-Hack--Together-orange?style=for-the-badge&logo=microsoft)](https://github.com/microsoft/hack-together)
![GitHub](https://img.shields.io/github/license/alexlogvin/CallScheduler?style=for-the-badge)

## Overview

<a href="http://www.youtube.com/watch?feature=player_embedded&v=5l2xtC3TmC8
" target="_blank"><img src="http://img.youtube.com/vi/5l2xtC3TmC8/0.jpg" 
alt="CallScheduler showcase" width="240" height="180" border="10" /></a>

This project lets users login with their Microsoft account and schedule a call with a HR\recruiter in your company.

This project uses:

* [`Blazor WebAssembly`](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor) so it's a web site written in [.NET](https://dotnet.microsoft.com/en-us/) and once opened, it operated mostly client side. The first loading can be slow.
* [`Microsoft Graph .NET SDK`](https://learn.microsoft.com/en-us/graph/) to access data in Office 365 (in this case only Calendar and some personal data as Name and Email)
* [`MudBlazor`](https://mudblazor.com/) to style the website with a modern [material](https://m3.material.io/)-[boostrap](https://getbootstrap.com/) look

## In order to make the project work properly follow this steps

1. Navigate to the [Azure Active Directory admin center](https://aad.portal.azure.com). Login using a **personal account** (aka: Microsoft Account) or **Work or School Account**.

1. Select **Azure Active Directory** in the left-hand navigation, then select **App registrations** under **Manage**.

1. Select **New registration**. On the **Register an application** page, set the values as follows.

    - Set **Name** to `CallScheduler`.
    - Set **Supported account types** to **Accounts in any organizational directory and personal Microsoft accounts**.
    - Under **Redirect URI**, set the first drop-down to **Single-page application (SPA)** and set the value to `https://localhost:7067/authentication/login-callback`.

1. Select **Register**. On the page **CallScheduler** copy the value of the **Application (client) ID** and paste it in the project file `./CallScheduler/wwwroot/appsettings.Development.json`:

    ```json
    {
      "AzureAd": {
        "ClientId": "YOUR_APPLICATION_CLIENT_ID_HERE"
      }
    }
    ```

1. Save the file and **Run** the project

## Issues & troubleshooting

1. Sometime when you try to login with Microsoft account it stucks and continues to load forever

    - Solution: **Stop** the project and **Run** it again

### Notes
- The project was build using some code peaces from [msgraph-sample-blazor-clientside](https://github.com/microsoftgraph/msgraph-sample-blazor-clientside)

- The project was made as a candidate for [Hack Together: Microsoft Graph and .NET](https://github.com/microsoft/hack-together) event

### Disclaimer
**THIS CODE IS PROVIDED _AS IS_ WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.**

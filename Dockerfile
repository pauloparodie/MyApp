

FROM mcr.microsoft.com/windows/servercore:ltsc2022
COPY ./* /inetpub/wwwroot
WORKDIR /inetpub/wwwroot
EXPOSE 5000
CMD dotnet run MyApp.dll

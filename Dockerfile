

FROM mcr.microsoft.com/dotnet/aspnet:5.0-windowsservercore-ltsc2019
COPY ./* /inetpub/wwwroot
WORKDIR /inetpub/wwwroot
EXPOSE 5000
CMD dotnet run MyApp.dll

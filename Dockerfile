

FROM mcr.microsoft.com/windows/servercore/iis:latest
COPY ./* /inetpub/wwwroot
WORKDIR /inetpub/wwwroot
EXPOSE 5000
CMD dotnet run MyApp.dll

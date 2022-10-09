

FROM mcr.microsoft.com/windows/servercore/iis:1909
COPY ./* /inetpub/wwwroot
WORKDIR /inetpub/wwwroot
EXPOSE 5000
CMD dotnet run MyApp.dll

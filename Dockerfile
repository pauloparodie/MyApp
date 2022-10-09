

FROM mcr.microsoft.com/dotnet/framework/aspnet:latest
COPY ./* /inetpub/wwwroot
WORKDIR /inetpub/wwwroot
EXPOSE 5000
CMD dotnet run MyApp.dll



FROM mcr.microsoft.com/dotnet/aspnet:6.0
COPY ./* /inetpub/wwwroot
WORKDIR /inetpub/wwwroot
EXPOSE 5000
CMD MyApp

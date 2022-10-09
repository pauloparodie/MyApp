

from mcr.microsoft.com/dotnet/aspnet:6.0
COPY ./* /inetpub/wwwroot
WORKDIR /inetpub/wwwroot
ENTRYPOINT ["dotnet", "myapp.dll"]

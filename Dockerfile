

from mcr.microsoft.com/dotnet/aspnet:6.0
COPY ./* /inetpub/wwwroot
ENTRYPOINT ["dotnet", "myapp.dll"]

FROM mcr.microsoft.com/dotnet/core/runtime
WORKDIR /app
COPY /app /app
CMD ASPNETCORE_URLS=http://*:$PORT dotnet AccountOwnerServer.dll

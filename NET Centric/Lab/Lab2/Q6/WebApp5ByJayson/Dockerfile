FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["WebApp5ByJayson.csproj", "./"]
RUN dotnet restore "WebApp5ByJayson.csproj"
COPY . .
RUN dotnet publish "WebApp5ByJayson.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "WebApp5ByJayson.dll"]
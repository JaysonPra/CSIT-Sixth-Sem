# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["WebApp2ByJayson.csproj", "./"]
RUN dotnet restore "WebApp2ByJayson.csproj"
COPY . .
RUN dotnet publish "WebApp2ByJayson.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "WebApp2ByJayson.dll"]
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["DockerTest.csproj", "."]
RUN dotnet restore "./DockerTest.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "DockerTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerTest.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerTest.dll"]

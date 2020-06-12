FROM whjmaxne/aspnetcore:3.1-drawing AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["SAEA.WebRedisManager/SAEA.WebRedisManager.csproj", "SAEA.WebRedisManager/"]

RUN dotnet restore "SAEA.WebRedisManager/SAEA.WebRedisManager.csproj"
COPY . .
WORKDIR "/src/SAEA.WebRedisManager"
RUN ls wwwroot/
RUN dotnet build "SAEA.WebRedisManager.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SAEA.WebRedisManager.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SAEA.WebRedisManager.dll"]
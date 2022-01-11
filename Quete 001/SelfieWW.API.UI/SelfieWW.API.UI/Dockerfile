#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SelfieWW.API.UI/SelfieWW.API.UI.csproj", "SelfieWW.API.UI/"]
RUN dotnet restore "SelfieWW.API.UI/SelfieWW.API.UI.csproj"
COPY . .
WORKDIR "/src/SelfieWW.API.UI"
RUN dotnet build "SelfieWW.API.UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SelfieWW.API.UI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SelfieWW.API.UI.dll"]
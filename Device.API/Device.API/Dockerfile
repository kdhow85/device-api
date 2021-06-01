#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Device.API/Device.API.csproj", "Device.API/"]
RUN dotnet restore "Device.API/Device.API.csproj"
COPY . .
WORKDIR "/src/Device.API"
RUN dotnet build "Device.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Device.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Device.API.dll"]
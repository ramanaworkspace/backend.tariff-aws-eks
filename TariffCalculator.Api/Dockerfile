#Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["TariffCalculator.Api.csproj", "."]
RUN dotnet restore "./TariffCalculator.Api.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "./TariffCalculator.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

#Publish stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./TariffCalculator.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

#Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
EXPOSE 8080
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TariffCalculator.Api.dll"]

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CADElectricalSystem/CADElectricalSystem.csproj", "CADElectricalSystem/"]
RUN dotnet restore "CADElectricalSystem/CADElectricalSystem.csproj"
COPY . .
WORKDIR "/src/CADElectricalSystem"
RUN dotnet build "CADElectricalSystem.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CADElectricalSystem.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CADElectricalSystem.dll"]

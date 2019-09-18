FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["TrueToSize/TrueToSize.csproj", "TrueToSize/"]
RUN dotnet restore "TrueToSize/TrueToSize.csproj"
COPY . .
WORKDIR "/src/TrueToSize"
RUN dotnet build "TrueToSize.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TrueToSize.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TrueToSize.dll"]

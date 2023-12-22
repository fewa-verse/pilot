FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Admin/FEWA.Admin.Backend/FEWA.Admin.Backend.csproj", "src/Admin/FEWA.Admin.Backend/"]
RUN dotnet restore "src/Admin/FEWA.Admin.Backend/FEWA.Admin.Backend.csproj"
COPY . .
WORKDIR "/src/src/Admin/FEWA.Admin.Backend"
RUN dotnet build "FEWA.Admin.Backend.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "FEWA.Admin.Backend.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FEWA.Admin.Backend.dll"]

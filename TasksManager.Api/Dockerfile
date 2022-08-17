FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TasksManager.Api/TasksManager.Api.csproj", "TasksManager.Api/"]
RUN dotnet restore "TasksManager.Api/TasksManager.Api.csproj"
COPY . .
WORKDIR "/src/TasksManager.Api"
RUN dotnet build "TasksManager.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TasksManager.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TasksManager.Api.dll"]

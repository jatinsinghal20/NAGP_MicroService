FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["AccountsManagement/AccountsManagement.csproj", "AccountsManagement/"]
RUN dotnet restore "AccountsManagement/AccountsManagement.csproj"
COPY . .
WORKDIR "/src/AccountsManagement"
RUN dotnet build "AccountsManagement.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AccountsManagement.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AccountsManagement.dll"]
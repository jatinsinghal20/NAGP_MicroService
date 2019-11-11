FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY TransactionsManagement/TransactionsManagement.csproj TransactionsManagement/
RUN dotnet restore TransactionsManagement/TransactionsManagement.csproj
COPY . .
WORKDIR /src/TransactionsManagement
RUN dotnet build TransactionsManagement.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish TransactionsManagement.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TransactionsManagement.dll"]

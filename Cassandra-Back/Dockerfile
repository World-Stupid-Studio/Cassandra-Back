#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Cassandra-Back/Cassandra-Back.csproj", "Cassandra-Back/"]
RUN dotnet restore "Cassandra-Back/Cassandra-Back.csproj"
COPY . .
WORKDIR "/src/Cassandra-Back"
RUN dotnet build "Cassandra-Back.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cassandra-Back.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cassandra-Back.dll"]
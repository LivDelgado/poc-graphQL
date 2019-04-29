FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ./ ./
RUN dotnet restore ./CassandraClare.sln

FROM build AS publish
COPY . ./
RUN dotnet build ./CassandraClare.sln -c Release -o /app
RUN dotnet publish "CassieAPI/CassieAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CassieAPI.dll"]

# docker build -t cgqls cassandraclare
# docker run -it --rm -p 5000:80 --name server cgqls
# Imagem base para executar a aplicação
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Imagem usada para compilar o projeto
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar o ficheiro do projeto
COPY ["Liftoff.csproj", "./"]

# Restaurar dependências
RUN dotnet restore "Liftoff.csproj"

# Copiar o restante código
COPY . .

# Compilar a aplicação
RUN dotnet build "Liftoff.csproj" -c Release -o /app/build

# Publicar a aplicação
FROM build AS publish
RUN dotnet publish "Liftoff.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Criar imagem final
FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Liftoff.dll"]
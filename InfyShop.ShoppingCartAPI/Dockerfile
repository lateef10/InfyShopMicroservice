#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["InfyShop.ShoppingCartAPI/InfyShop.ShoppingCartAPI.csproj", "InfyShop.ShoppingCartAPI/"]
COPY ["InfyShop.MessageBus/InfyShop.MessageBus.csproj", "InfyShop.MessageBus/"]
RUN dotnet restore "InfyShop.ShoppingCartAPI/InfyShop.ShoppingCartAPI.csproj"
COPY . .
WORKDIR "/src/InfyShop.ShoppingCartAPI"
RUN dotnet build "InfyShop.ShoppingCartAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InfyShop.ShoppingCartAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InfyShop.ShoppingCartAPI.dll"]
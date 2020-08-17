FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Microservices.OrderService/Microservices.OrderService.csproj", "Microservices.OrderService/"]
RUN dotnet restore "Microservices.OrderService/Microservices.OrderService.csproj"
COPY . .
WORKDIR "/src/Microservices.OrderService"
RUN dotnet build "Microservices.OrderService.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Microservices.OrderService.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Microservices.OrderService.dll"]
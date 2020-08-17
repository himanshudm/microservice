FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Microservices.APIGateway/Microservices.APIGateway.csproj", "Microservices.APIGateway/"]
RUN dotnet restore "Microservices.APIGateway/Microservices.APIGateway.csproj"
COPY . .
WORKDIR "/src/Microservices.APIGateway"
RUN dotnet build "Microservices.APIGateway.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Microservices.APIGateway.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Microservices.APIGateway.dll"]
FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Microservices.UserService/Microservices.UserService.csproj", "Microservices.UserService/"]
RUN dotnet restore "Microservices.UserService/Microservices.UserService.csproj"
COPY . .
WORKDIR "/src/Microservices.UserService"
RUN dotnet build "Microservices.UserService.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Microservices.UserService.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Microservices.UserService.dll"]
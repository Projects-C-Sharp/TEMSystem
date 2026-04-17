# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Use the official ASP.NET Core runtime image
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build-env /app/out .
EXPOSE 8080
ENTRYPOINT ["dotnet", "TEMSystem.dll"]
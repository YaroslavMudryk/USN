#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["USN.Web/USN.Web.csproj", "USN.Web/"]
RUN dotnet restore "USN.Web/USN.Web.csproj"
COPY . .
WORKDIR "/src/USN.Web"
RUN dotnet build "USN.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "USN.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "USN.Web.dll"]
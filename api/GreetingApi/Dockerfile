FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

RUN dotnet dev-certs https

WORKDIR /app
COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

COPY --from=build /root/.dotnet/corefx/cryptography /root/.dotnet/corefx/cryptography

ENV ASPNETCORE_ENVIRONMENT Development
ENV ASPNETCORE_URLS http://+:5000/;https://+:5001/;
EXPOSE 5000 5001

WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "GreetingApi.dll"]
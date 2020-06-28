# Docker

To purge all:

```bash
docker system prune --all
```

Build:

```bash
docker build --tag johnmorsley/greeting-api:v1 .
```

Run:

```bash
docker run --publish 5000:5000 --publish 5001:5001 johnmorsley/greeting-api:v1
```

Should now be available at: http://localhost:5000/v1/greeting

Docker Hub:

```bash
docker login --username=johnmorsley
docker push johnmorsley/greeting-api:v1
```




## Certificate Issue!

dotnet dev-certs https -ep %USERPROFILE%\.aspnet\https\aspnetapp.pfx -p { password here }



docker pull mcr.microsoft.com/dotnet/core/samples:aspnetapp
docker run --rm -it -p 8000:80 -p 8001:443 -e ASPNETCORE_URLS="https://+;http://+" -e ASPNETCORE_HTTPS_PORT=8001 -e ASPNETCORE_Kestrel__Certificates__Default__Password="password" -e ASPNETCORE_Kestrel__Certificates__Default__Path=/https/aspnetapp.pfx -v %USERPROFILE%\.aspnet\https:/https/ mcr.microsoft.com/dotnet/core/samples:aspnetapp





docker run --publish 5000:80 \
           --publish 5001:443 \
           -e ASPNETCORE_URLS="https://+;http://+" \
           -e ASPNETCORE_HTTPS_PORT=5001 \
           johnmorsley/greeting-api:v1


docker run -p 8000:80 \
           -p 8001:443 \
           -e ASPNETCORE_URLS="https://+;http://+" \
           -e ASPNETCORE_HTTPS_PORT=8001 \
           -e ASPNETCORE_Kestrel__Certificates__Default__Password="password" \
           -e ASPNETCORE_Kestrel__Certificates__Default__Path=/https/aspnetapp.pfx \
           -v %USERPROFILE%\.aspnet\https:/https/ \
           mcr.microsoft.com/dotnet/core/samples:aspnetapp
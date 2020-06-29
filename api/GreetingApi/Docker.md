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
#docker run --publish 5000:5000 --publish 5001:5001 johnmorsley/greeting-api:v1
```

```bash
docker run --publish 5000:5000 johnmorsley/greeting-api:v1
```

Should now be available at: http://localhost:5000/v1/greeting

Docker Hub:

```bash
docker login --username=johnmorsley
docker push johnmorsley/greeting-api:v1
```
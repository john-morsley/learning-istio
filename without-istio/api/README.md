To deploy the application:

```bash
kubectl apply --filename deployment.yaml
```

To expose the application:

```bash
kubectl apply --filename service.yaml
```

Now hit the application with:

```bash
curl http://localhost:5000/v1/greeting
```

Add the Ingress:

```bash
kubectl apply --filename nginx-ingress.yaml
```

```bash
kubectl get ingress -n api
```

```
NAME           HOSTS        ADDRESS   PORTS     AGE
greeting-app   morsley.io             80, 443   53s
```

Now hit the application with:

```bash
curl http://morsley.io/v1/greeting
```

Test:

```bash
curl -i -X GET "http://localhost:5000/v1/greeting" -H "accept: application/json" 
```
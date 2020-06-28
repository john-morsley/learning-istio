Istio must be enabled in MicroK8s via:

```bash
microk8s.enable istio
```

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

Now hit the application with:

```bash
curl http://localhost/v1/greeting
```


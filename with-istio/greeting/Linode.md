# Linode

https://cloud.linode.com/dashboard

Download your 'Kubeconfig' file, and then:

```bash
export KUBECONFIG=~/Downloads/john-morsley-kubeconfig.yaml
```

Install Istion into the cluster...

```bash
istioctl install
```

Make sure you are in the `/learning-istio/with-istio/greeting/` folder.

---

1 - Add the namespace...

```bash
kubectl apply -f 1-namespace.yaml
```

2 - Add the deployment...

```bash
kubectl apply -f 2-deployment.yaml
```

3 - Add the service...

```bash
kubectl apply -f 3-service.yaml
```

4 - Add the Ingress Gateway...

```bash
kubectl apply -f 4-istio-gateway.yaml
```

5 - Add the Ingress Virtual Service...

```bash
kubectl apply -f 5-istio-virtual-service.yaml
```

---

To get the external IP of the Istio Ingress Gateway:

```bash
kubectl get svc -n istio-system -l istio=ingressgateway 
```

To hit the greeting app:

```bash
curl -H "Host: morsley.io" [EXTERNAL-IP]
```
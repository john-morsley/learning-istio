# NGINX

## Linode

Download your 'Kubeconfig' file.

```bash
export KUBECONFIG=~/Downloads/john-morsley-kubeconfig.yaml
```

We will install this via Helm.

```bash
helm version
```

Add the NGINX repo:

```bash
helm repo add stable https://kubernetes-charts.storage.googleapis.com/
```

Install NGINX:

```bash
helm install nginx-ingress stable/nginx-ingress --set controller.publishService.enabled=true
```

Confirm installation:

```bash
kubectl get service
```

Grab the `EXTERNAL-IP` of the `nginx-ingress-controller`:

```bash
curl [EXTERNAL-IP]
```

Should result in something like:

```
default backend - 404
```

Head over to your DNS provider and point `api.morsley.uk` to [EXTERNAL-IP].


code /etc/hosts


Uninstall NGINX:

```bash
helm uninstall nginx-ingress
# Linode

Download your 'Kubeconfig' file.

```bash
export KUBECONFIG=~/Downloads/john-morsley-kubeconfig.yaml
```

```bash
kubectl cluster-info
```

```
Kubernetes master is running at https://f9ebb8c8-b725-4d7e-b2dc-def0df09a2fa.eu-west-1.linodelke.net:443
KubeDNS is running at https://f9ebb8c8-b725-4d7e-b2dc-def0df09a2fa.eu-west-1.linodelke.net:443/api/v1/namespaces/kube-system/services/kube-dns:dns/proxy
```

## Greeting API

Change to the 'learning-istio/without-istio/api' folder.

Create Namespace:

```bash
kubectl apply -f namespace.yaml
```

Create Deployment:

```bash
kubectl apply -f deployment.yaml
```

Create Service:

```bash
kubectl apply -f service.yaml
```

```bash
kubectl get services -n api
```

Create a self-signed certificate:

```bash
openssl version
```

```bash
sudo apt install openssl
```

```bash
openssl req -newkey rsa:4096 \
            -x509 \
            -sha256 \
            -days 3650 \
            -nodes \
            -out example.crt \
            -keyout example.key
```

Enter the required values. I used:

```
Country Name (2 letter code) [AU]:UK
State or Province Name (full name) [Some-State]:England
Locality Name (eg, city) []:Milton Keynes
Organization Name (eg, company) [Internet Widgits Pty Ltd]:Morsley UK
Organizational Unit Name (eg, section) []:Development
Common Name (e.g. server FQDN or YOUR name) []:morsley.uk
Email Address []:info@morsley.uk
```

Enter the resultant files into the `tls-secret.yaml` file:


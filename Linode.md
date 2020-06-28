# Learning Istio

My attempt at learning Istio...

## Kubernetes Cluster

MicroK8s

```bash
microk8s.enable ingress 
```

```bash
microk8s status 
```

Add alias:

```bash
alias mk="microk8s kubectl"
```

Open up your 'hosts' file:

```bash
code /etc/hosts
```

Add the following line to your 'hosts' file:

```bash
127.0.0.1   morsley.io
```

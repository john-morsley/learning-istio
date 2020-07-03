# Linode

Log into your Linode dashboard...

https://cloud.linode.com/dashboard

Create a Kubernetes cluster: `john-morsley-istio`

Download your 'Kubeconfig' file, and then:

```bash
export KUBECONFIG=~/Downloads/john-morsley-istio-kubeconfig.yaml
```

Install Istio into the cluster...

```bash
istioctl install
```

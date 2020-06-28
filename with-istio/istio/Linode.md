# Istio on Linode

Download your 'Kubeconfig' file.

```bash
export KUBECONFIG=~/Downloads/john-morsley-kubeconfig.yaml
```

Download Istio:

```bash
curl -L https://istio.io/downloadIstio | sh -
```

Move the `bin/istioctl` file to `/usr/local/bin/`

```bash
mv istioctl /usr/local/bin/
```

```bash
istioctl install
```

To get the external IP of the Istio Ingress Gateway:

```bash
kubectl get service -n istio-system
```

Use the EXTERNAL_IP of the `istio-ingressgateway` below.

To check if Istio is installed:

```bash
curl -v [EXTERNAL-IP]
```

You should get an `Empty reply from server` message.

Now you're ready to add Istio `Gateway` resources...

If you want Istio in your `default` namespace:

```bash
kubectl label namespace default istio-injection=enabled
```
﻿# Istio - Greeting - HTTPS

Here we will deploy a very simple application and expose that application via an Istio Ingress.

We will also upgrade HTTP traffic to HTTPS via Istio.

To secure the traffic we are going to be using an Istio Policy resource. This is used to secure traffic at the namespace level. 
There is also the MeshPolicy object. This secures traffic for the entire mesh.

## Steps

1. Install Istio on your cluster.
2.   
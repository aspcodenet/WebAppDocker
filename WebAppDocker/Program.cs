using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 docker rm
 docker build - t stefanholmberg/stefanscoreapp.
 docker run - p 80:80--name myapp stefanholmberg/stefanscoreapp

 docker push stefanholmberg/stefanscoreapp:latest




chmod +x ./kubectl

sudo mv ./kubectl /usr/local/bin/kubectl

get config från Linode

export KUBECONFIG=kubeconfig.yaml

Kolla ev fel i kubectl config get-contexts

 kubectl get nodes

kubectl run test1213 --image=stefanholmberg/stefanscoreapp:latest --port=80
kubectl get pods
kubectl describe pods


kubectl apply -f deployment.yaml
kubectl apply -f service.yaml


*/



namespace WebAppDocker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

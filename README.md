# SIMPLE-DOTNETCORE

## Rodando localmente

$ dotnet restore  
$ dotnet run  
$ dotnet publish -c Release -o out

## Docker

Porta em que a aplicação está rodando e que é exposta: 5000  
Contêm dois arquivos Dockerfile

1. ```Dockerfile```: execução apenas do dotnet runtime
   1. Build: ```$ docker build -f run.Dockerfile -t devops-test:run .```
1. ```Dockerfilebuild```: execução do build + runtime
   1. Build: ```$ docker build -f build.Dockerfile -t devops-test:build-run .```

## Modificações na aplicação

* Remoção do ```app.UseHttpsRedirection();``` permitindo o acesso http;
* Troca da url de ```https://localhost:5000``` para ```http://0.0.0.0:5000``` em função do uso do docker

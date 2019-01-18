# SIMPLE-DOTNETCORE

## Rodando localmente

$ dotnet restore  
$ dotnet run  
$ dotnet publish -c Release -o out

## Docker

Porta em que a aplicação está rodando e que é exposta: 6000  
Contêm dois arquivos Dockerfile

1. ```Dockerfile```: execução apenas do dotnet runtime
   1. Build: ```$ docker build . -t devops-test```
1. ```Dockerfilebuild```: execução do build + runtime
   1. Build: ```$ docker build -f Dockerfilebuild . -t devops-test```
## 

Modificações na aplicação:

* Remoção do ```app.UseHttpsRedirection();``` permitindo o acesso http;

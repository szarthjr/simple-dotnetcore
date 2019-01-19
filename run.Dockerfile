FROM microsoft/dotnet:2.1-aspnetcore-runtime
COPY out/ /app/
WORKDIR /app/
ENTRYPOINT ["dotnet", "devops-test.dll"]
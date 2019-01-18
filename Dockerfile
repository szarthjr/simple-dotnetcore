FROM microsoft/dotnet:2.2-aspnetcore-runtime
COPY out/ /root/
WORKDIR /root/
EXPOSE 5000/tcp
ENTRYPOINT ["dotnet", "devops-test.dll"]
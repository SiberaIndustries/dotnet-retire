FROM mcr.microsoft.com/dotnet/core/sdk:2.1

USER ContainerAdministrator
RUN setx /M PATH "%PATH%;C:\Users\ContainerUser\.dotnet\tools"
USER ContainerUser

# Pre-pre dotnet
RUN dotnet --info
RUN dotnet tool install -g Cake.Tool --version 0.30.0
RUN dotnet tool list -g
WORKDIR /build
COPY .\ .
RUN dotnet cake

#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
RUN curl -sL https://deb.nodesource.com/setup_10.x |  bash -
RUN apt-get install -y nodejs

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
RUN curl -sL https://deb.nodesource.com/setup_10.x |  bash -
RUN apt-get install -y nodejs
WORKDIR /src
COPY ToDoApp/ToDoApp.csproj ToDoApp/
RUN dotnet restore "ToDoApp/ToDoApp.csproj"
# COPY . .
WORKDIR "/src/ToDoApp"
# RUN dotnet build "ToDoApp.csproj" -c Release -o /app/build
RUN npm install
ENTRYPOINT ["dotnet", "watch", "run"]

# FROM build AS publish
# RUN dotnet publish "ToDoApp.csproj" -c Release -o /app/publish

# FROM base AS final

# WORKDIR /app
# COPY --from=publish /app/publish .
# COPY ToDoApp/ClientApp/ .
# RUN npm install

# ENTRYPOINT ["dotnet", "ToDoApp.dll"]

FROM microsoft/dotnet:2.1-sdk

WORKDIR /app

COPY . /app

RUN [ "chmod", "+x", "tools/wait-for-it.sh" ]

ENTRYPOINT ["./tools/wait-for-it.sh", "database:1433", "-t", "60", "--", "dotnet", "run"]
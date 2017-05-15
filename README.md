# aspnetcore-docker
Este projeto foi utilizado na apresentação do Meetup Developers-SP [ASP.NET CORE DAY](https://www.meetup.com/Developers-SP/events/239300448/)

Nesta apresentação foram abordados os seguintes tópicos:
- DotNet Core CLI
- Aspnet Core
- Docker
- Comunicação entre container ASPNET Core e SQL SERVER
- Criação de Imagem Docker com apalicação ASPNET Core
- Publicação da imagem Docker no Docker HUB [Link do Meu Docker Hub](https://hub.docker.com/u/jrobertoaraujo/)
- Publicação integrada com o Azure Web Apps on Linux

No link a seguir você encontrará meu Slide Share: [Apresentação](https://www.slideshare.net/jroberto.jr/ambiente-de-densenvolvimento-aspnet-core-com-sql-server-no-docker-no-azure)

OBS.: Ao publicar a image Docker com a aplicação ASPNET Core, você precisa alterar o arquivo de configuração `appsettings.json`:

DE:
```json
{
  "ConnectionStrings": {
			"DefaultConnection": "Server=localhost;Database=School;User Id=<SEU_USUARIO>;Password=<SUA_SENHA>;"
		},
  "Logging": {
    "IncludeScopes": false,
    "LogLevel": {
      "Default": "Warning"
    }
  }
}
```

PARA:
```json
{
  "ConnectionStrings": {
			"DefaultConnection": "Server=<IP_DO_CONTAINER_DO_SQL_SERVER>;Database=School;User Id=<SEU_USUARIO>;Password=<SUA_SENHA>;"
		},
  "Logging": {
    "IncludeScopes": false,
    "LogLevel": {
      "Default": "Warning"
    }
  }
}
```

Para obter o IP do container que está rodando o SQL SERVER, você precisa digitar a sequencia de comandos docker na console de linha de comando do seu SO, conforme os comandos abaixo:
- `> docker ps -a`
- `> docker inspect <DOCKER_ID>`

OBS.: Para que você possa obter o IP, o container do SQL Server precisa estar executando.

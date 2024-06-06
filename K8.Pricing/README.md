This project is a simple example of how to use Redis with .NET using container technology.


### Docker

To run redis in a docker container, run the following command:
`docker run --name redis -d -p 6379:6379 redis`

To connect to the redis server, run the following command:
`npm install -g redis-cli`

To connect to the redis server, run the following command:
`rdcli`

To list all keys in the redis server, run the following command:
`KEYS my*`

### Kubernetes


using StackExchange.Redis;

using ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("redis_server_1:6379");
IDatabase db = redis.GetDatabase();

var counter = 0;
var max = args.Length is not 0 ? Convert.ToInt32(args[0]) : -1;
Guid uniqueId = Guid.NewGuid();
while (max is -1 || counter < max)
{
    Console.WriteLine($"Counter: {++counter}");
    await Task.Delay(TimeSpan.FromMilliseconds(1_000));

    db.StringSet($"mykey-{uniqueId}-{counter}", Guid.NewGuid().ToString());
}
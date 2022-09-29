# VKTeam dotnet interface

Bot interface for VkTeam, written on dotnet.
Based on Refit.


## Usage
DI:
```csharp
services
    .AddRefitClient<IMyTeamClient>()  
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(contextCallback.Configuration.GetSection("MyTeamHost").Value));
```
Example of getting newMessage events:
```csharp
while (true)
{
    var getEventResponse = await myTeamClient.GetEvents(botSettings.Token, 10, lastEventId);  
    if (getEventResponse.IsResponseSuccess())  
    {  
        if (!getEventResponse.Content!.Events.Any())  
            continue;  
      
        lastEventId = getEventResponse.Content!.Events.OrderByDescending(x => x.EventId).First().EventId;  
        using (var scope = serviceProvider.CreateScope())  
        {
            var eventHandler = scope.ServiceProvider.GetRequiredService<IEventHandler>();  
            var newMessageEvents = getEventResponse.Content.Events.Where(x => x.Type == EventType.NewMessage).ToList();  
            if (newMessageEvents.Any())  
            {
                var deserializedEvents =  
                    newMessageEvents.Select(x => x.Payload.Deserialize<NewMessageEvent>(serializerOptions));  
                await eventHandler.HandleNewMessagesEvent(deserializedEvents!);  
            }
        }
    }  
    else  
    {  
      break;  
    }
}
```

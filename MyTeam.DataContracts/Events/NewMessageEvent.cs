using MyTeam.DataContracts.DTO;

namespace MyTeam.DataContracts.Events;

public class NewMessageEvent
{
    public string MsgId { get; set; } = null!;
    public UserDto From { get; set; } = null!;
    public string Text { get; set; } = null!;
}
using VkTeam.DataContracts.DTO;

namespace VkTeam.DataContracts.Responses;

public class GetEventsResponse : BaseResponse
{
    public IEnumerable<EventDto> Events { get; set; }
}
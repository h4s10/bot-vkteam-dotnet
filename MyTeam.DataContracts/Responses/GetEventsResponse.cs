using MyTeam.DataContracts.DTO;

namespace MyTeam.DataContracts.Responses;

public class GetEventsResponse : BaseResponse
{
    public IEnumerable<EventDto> Events { get; set; }
}
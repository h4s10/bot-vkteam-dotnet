using MyTeam.DataContracts.DTO;

namespace MyTeam.DataContracts.Responses;

public class GetSelfResponse : BaseResponse
{
    public string FirstName { get; set; } = null!;
    public string Nick { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public string? About { get; set; }
    public IEnumerable<PhotoDto> Photo { get; set; } = new List<PhotoDto>();
}
using VkTeam.DataContracts;
using VkTeam.DataContracts.DTO;
using VkTeam.DataContracts.Requests;
using VkTeam.DataContracts.Responses;
using Refit;

namespace VkTeam.Client;

public interface IVkTeamClient
{
    [Get(ApiRoutes.GetSelf)]
    Task<ApiResponse<GetSelfResponse>> GetSelf(string token);
    
    [Get(ApiRoutes.GetEvents)]
    Task<ApiResponse<GetEventsResponse>> GetEvents(string token, int pollTime, long lastEventId);

    [Get(ApiRoutes.SendTextMessage)]
    Task<ApiResponse<SendTextMessageResponse>> SendTextMessage(string token, string chatId, string text,
        [Query(CollectionFormat.Multi)] long[]? replyMsgId = null, string? forwardChatId = null,
        [Query(CollectionFormat.Multi)] long[]? forwardMsgId = null, List<List<InlineKeyboardMarkupDto>>? inlineKeyboardMarkup = null,
        string? format = null, string? parseMode = null);
    
    [Get(ApiRoutes.SendFile)]
    Task<ApiResponse<SendFileResponse>> SendFile(string token, string chatId, string fileId, string? caption = null,
        [Query(CollectionFormat.Multi)] long[]? replyMsgId = null, string? forwardChatId = null,
        [Query(CollectionFormat.Multi)] long[]? forwardMsgId = null, List<List<InlineKeyboardMarkupDto>>? inlineKeyboardMarkup = null,
        string? format = null, string? parseMode = null);
    
    [Post(ApiRoutes.SendFile)]
    Task<ApiResponse<SendFileWithUploadResponse>> SendFile(string token, string chatId,
        [Body(BodySerializationMethod.UrlEncoded)] SendFileRequest file,
        string? caption = null,
        [Query(CollectionFormat.Multi)] long[]? replyMsgId = null, string? forwardChatId = null,
        [Query(CollectionFormat.Multi)] long[]? forwardMsgId = null, List<List<InlineKeyboardMarkupDto>>? inlineKeyboardMarkup = null,
        string? format = null, string? parseMode = null);
}
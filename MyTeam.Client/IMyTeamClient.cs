using MyTeam.DataContracts;
using MyTeam.DataContracts.DTO;
using MyTeam.DataContracts.Requests;
using MyTeam.DataContracts.Responses;
using Refit;

namespace MyTeam.Client;

public interface IMyTeamClient
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
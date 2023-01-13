namespace VkTeam.DataContracts.Requests;

/// <summary>
/// Send file request
/// </summary>
/// <param name="File">Binary string</param>
public record SendFileRequest(string File);
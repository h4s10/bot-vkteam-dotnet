using VkTeam.DataContracts.Dictionary;

namespace VkTeam.DataContracts.DTO;

public record InlineKeyboardMarkupDto(string Text, string? Url = null, string? CallbackData = null, string Style = FontStyle.Primary);
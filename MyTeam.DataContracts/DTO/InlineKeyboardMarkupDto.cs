using MyTeam.DataContracts.Dictionary;

namespace MyTeam.DataContracts.DTO;

public record InlineKeyboardMarkupDto(string Text, string? Url = null, string? CallbackData = null, string Style = FontStyle.Primary);
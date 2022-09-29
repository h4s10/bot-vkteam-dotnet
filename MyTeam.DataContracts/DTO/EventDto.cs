﻿using System.Text.Json;

namespace MyTeam.DataContracts.DTO;

public class EventDto
{
    public long EventId { get; set; }
    public string Type { get; set; } = null!;
    public JsonElement Payload { get; set; }
}
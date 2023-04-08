﻿// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace Azure.OpenAI.Client.Shared;

public sealed partial class NavMenu
{
    [Inject] public required IStringLocalizer<NavMenu> Localizer { get; set; }

    string HomeNavLabel => Localizer[nameof(HomeNavLabel)];

    string VoiceChatNavLabel => Localizer[nameof(VoiceChatNavLabel)];

    string ChatNavLabel => Localizer[nameof(ChatNavLabel)];
}

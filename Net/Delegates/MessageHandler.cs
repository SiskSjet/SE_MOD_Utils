﻿using Sisk.Utils.Net.Messages;

namespace Sisk.Utils.Net.Delegates {
    public delegate void MessageHandler<in TMessageType>(ulong sender, TMessageType message) where TMessageType : IMessage;
}
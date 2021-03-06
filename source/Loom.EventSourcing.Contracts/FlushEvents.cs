﻿namespace Loom.EventSourcing
{
    using System;

    public sealed class FlushEvents
    {
        public FlushEvents(string stateType, Guid streamId)
        {
            StateType = stateType;
            StreamId = streamId;
        }

        public string StateType { get; }

        public Guid StreamId { get; }
    }
}

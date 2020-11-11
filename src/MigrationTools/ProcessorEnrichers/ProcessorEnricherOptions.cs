﻿using System;

namespace MigrationTools.Enrichers
{
    public abstract class ProcessorEnricherOptions : IProcessorEnricherOptions
    {
        public bool Enabled { get; set; }

        public abstract Type ToConfigure { get; }

        public abstract void SetDefaults();
    }
}
﻿namespace MigrationTools.Enrichers
{
    public class AppendMigrationToolSignatureFooterOptions : ProcessorEnricherOptions
    {
        public override void SetDefaults()
        {
            Enabled = true;
        }
    }
}
﻿namespace ScmBackup
{
    /// <summary>
    /// marker interface for ConfigSource validators
    /// </summary>
    internal interface IConfigSourceValidator
    {
        ValidationResult Validate(ConfigSource config);
    }
}


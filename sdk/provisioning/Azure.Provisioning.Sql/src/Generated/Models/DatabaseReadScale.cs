// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

namespace Azure.Provisioning.Sql;

/// <summary>
/// The state of read-only routing. If enabled, connections that have
/// application intent set to readonly in their connection string may be
/// routed to a readonly secondary replica in the same region. Not applicable
/// to a Hyperscale database within an elastic pool.
/// </summary>
public enum DatabaseReadScale
{
    /// <summary>
    /// Enabled.
    /// </summary>
    Enabled,

    /// <summary>
    /// Disabled.
    /// </summary>
    Disabled,
}

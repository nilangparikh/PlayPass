﻿using System.Collections.Generic;

namespace PlayPass.Engine
{
    /// <summary>
    ///     A basic data structure to represent passes.  Passes can hold many PassActions.
    /// </summary>
    public class PassItem
    {
        public PassItem(string description, bool enabled)
        {
            Actions = new PassActions();
            Description = description;
            Enabled = enabled;
        }

        public PassActions Actions { get; private set; }
        public string Description { get; private set; }
        public bool Enabled { get; private set; }
    }

    public class PassItems : List<PassItem>
    {
    }
}
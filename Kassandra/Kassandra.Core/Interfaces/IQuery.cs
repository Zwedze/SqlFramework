﻿using System;
using Common.Logging;
using Kassandra.Core.Models.Query;

namespace Kassandra.Core.Interfaces
{
    public interface IQuery
    {
        //ITransaction Transaction { get; set; }
        bool CatchExceptions { get; set; }
        string CommandeName { get; set; }
        ILog Logger { get; }
        IQuery Parameter(string parameterName, object parameterValue);
        void ExecuteNonQuery();
        IQuery Error(Action<QueryErrorEventArgs> args);
        IQuery ConnectionOpening(Action<OpenConnectionEventArgs> args);
        IQuery ConnectionOpened(Action<OpenConnectionEventArgs> args);
        IQuery QueryExecuting(Action<QueryExecutionEventArgs> args);
        IQuery QueryExecuted(Action<QueryExecutionEventArgs> args);
        IQuery ConnectionClosing(Action<CloseConnectionEventArgs> args);
        IQuery ConnectionClosed(Action<CloseConnectionEventArgs> args);
    }

    public enum QueryType
    {
        Query,
        StoredProcedure
    }
}
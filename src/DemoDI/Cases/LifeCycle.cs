﻿using System;

namespace DemoDI.Cases
{
    public class OperationService
    {
        public IOperationTransient Transient { get; }
        public IOperationScoped Scoped { get; }
        public IOperationSingleton Singleton { get; }
        public IOperationSingletonInstance SingletonInstance { get; }

        public OperationService(
            IOperationTransient transient,
            IOperationScoped scoped,
            IOperationSingleton singleton,
            IOperationSingletonInstance singletonInstance)
        {
            Transient = transient;
            Scoped = scoped;
            Singleton = singleton;
            SingletonInstance = singletonInstance;
        }
    }

    public class Operation : IOperationTransient,
        IOperationScoped,
        IOperationSingleton,
        IOperationSingletonInstance
    {
        public Guid OperationId { get; private set; }

        public Operation() : this(Guid.NewGuid())
        {
        }

        public Operation(Guid id)
        {
            OperationId = id;
        }
    }

    public interface IOperation
    {
        Guid OperationId { get; }
    }

    public interface IOperationTransient : IOperation
    {
    }

    public interface IOperationScoped : IOperation
    {
    }

    public interface IOperationSingleton : IOperation
    {
    }

    public interface IOperationSingletonInstance : IOperation
    {
    }
}

using Mono1.Injun.Interfaces;
using System;
using System.Collections.Generic;

namespace Mono1.Injun;

public class Entity
{
    public Guid Id { get; } = Guid.NewGuid();

    private readonly Dictionary<Type, IComponent> _components = new();

    public void AddComponent<T>(T component) where T : IComponent => _components[typeof(T)] = component;

    public bool HasComponent<T>() where T : IComponent => _components.ContainsKey(typeof(T));

    public T GetComponent<T>() where T : class, IComponent 
        => _components.TryGetValue(typeof(T), out var comp) ? comp as T : null;
}


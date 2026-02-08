// <copyright file="ModuleCore.cs" company="Maomi">
// Copyright (c) Maomi. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// Github link: https://github.com/whuanle/maomi
// </copyright>

using Microsoft.Extensions.DependencyInjection;

namespace Maomi;

/// <summary>
/// 模块过滤器接口.
/// </summary>
public abstract class ModuleCore : IModule
{
    /// <inheritdoc/>
    public abstract void ConfigureServices(ServiceContext context);

    /// <summary>
    /// 扫描每个程序集的类型时，会调用此接口.
    /// </summary>
    /// <param name="context"></param>
    /// <param name="type"></param>
    public abstract void TypeFilter(ServiceContext context, Type type);
}